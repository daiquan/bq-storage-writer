// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// BuildTable.CreateTable("kore-edw-lake-dev","etl_dcdp","final_test");

var sample = new BQWriter();
await sample.AppendRowsPendingAsync("kore-edw-lake-dev", "etl_dcdp", "final_test");





