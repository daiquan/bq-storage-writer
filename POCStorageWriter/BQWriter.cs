
using Google.Api.Gax.Grpc;
using Google.Cloud.BigQuery.Storage.V1;
using Google.Cloud.BigQuery.V2;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using static Google.Cloud.BigQuery.Storage.V1.AppendRowsRequest.Types;

public class BQWriter
{
    

    public async Task AppendRowsPendingAsync(string projectId, string datasetId, string tableId)
    {
        BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
        // Initialize a write stream for the specified table.
        // When creating the stream, choose the type. Use the Pending type to wait
        // until the stream is committed before it is visible. See:
        // https://cloud.google.com/bigquery/docs/reference/storage/rpc/google.cloud.bigquery.storage.v1#google.cloud.bigquery.storage.v1.WriteStream.Type
        WriteStream stream = new WriteStream { Type = WriteStream.Types.Type.Pending };
        TableName tableName = TableName.FromProjectDatasetTable(projectId, datasetId, tableId);

        stream = await bigQueryWriteClient.CreateWriteStreamAsync(tableName, stream);

        // Initialize streaming call, retrieving the stream object
        BigQueryWriteClient.AppendRowsStream rowAppender = bigQueryWriteClient.AppendRows();

        // Sending requests and retrieving responses can be arbitrarily interleaved.
        // Exact sequence will depend on client/server behavior.
        // Create task to do something with responses from server.
        Task appendResultsHandlerTask = Task.Run(async () =>
        {
            AsyncResponseStream<AppendRowsResponse> appendRowResults = rowAppender.GetResponseStream();
            while (await appendRowResults.MoveNextAsync())
            {
                AppendRowsResponse responseItem = appendRowResults.Current;
                // Do something with responses.
                Console.WriteLine($"Appending rows resulted in: {responseItem.AppendResult}");
            }
            // The response stream has completed.
        });

        // List of records to be appended in the table.
        var records = new List<MessageRecord>
        {
            new MessageRecord { MessageType ="test",Owner="est",Message="{\"test\":1}",LastModified=Timestamp.FromDateTimeOffset(DateTimeOffset.UtcNow)}
        };

        // Create a batch of row data by appending serialized bytes to the
        // SerializedRows repeated field.
        ProtoData protoData = new ProtoData
        {
            WriterSchema = new ProtoSchema { ProtoDescriptor = MessageRecord.Descriptor.ToProto() },
            Rows = new ProtoRows { SerializedRows = { records.Select(r => r.ToByteString()) } }
        };

        // Initialize the append row request.
        AppendRowsRequest appendRowRequest = new AppendRowsRequest
        {
            WriteStreamAsWriteStreamName = stream.WriteStreamName,
            ProtoRows = protoData
        };

        // Stream a request to the server.
        await rowAppender.WriteAsync(appendRowRequest);

        // Complete writing requests to the stream.
        await rowAppender.WriteCompleteAsync();

        // Await the handler. This will complete once all server responses have been processed.
        await appendResultsHandlerTask;

        // A Pending type stream must be "finalized" before being committed. No new
        // records can be written to the stream after this method has been called.
        await bigQueryWriteClient.FinalizeWriteStreamAsync(stream.Name);
        BatchCommitWriteStreamsRequest batchCommitWriteStreamsRequest = new BatchCommitWriteStreamsRequest
        {
            Parent = tableName.ToString(),
            WriteStreams = { stream.Name }
        };

        BatchCommitWriteStreamsResponse batchCommitWriteStreamsResponse =
            await bigQueryWriteClient.BatchCommitWriteStreamsAsync(batchCommitWriteStreamsRequest);
        if (batchCommitWriteStreamsResponse.StreamErrors?.Count > 0)
        {
            // Handle errors here.
            Console.WriteLine("Error committing write streams. Individual errors:");
            foreach (StorageError error in batchCommitWriteStreamsResponse.StreamErrors)
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }
        else
        {
            Console.WriteLine($"Writes to stream {stream.Name} have been committed.");
        }
    }
}



public class BuildTable
{
    public static void CreateTable(string projectId,string datasetId,string tableName)
    {
        Google.Apis.Bigquery.v2.Data.TableSchema tableSchema = new TableSchemaBuilder
        {
            { "message_type", BigQueryDbType.String },
            { "owner", BigQueryDbType.String },
            { "message", BigQueryDbType.Json },
            { "last_modified", BigQueryDbType.Timestamp },
        }.Build();

        BigQueryClient Client = BigQueryClient.Create(projectId);
        BigQueryDataset dataSet = Client.GetOrCreateDataset(datasetId);

        dataSet.GetOrCreateTable(tableName, tableSchema);
    }
}