// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: kmessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from kmessage.proto</summary>
public static partial class KmessageReflection {

  #region Descriptor
  /// <summary>File descriptor for kmessage.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static KmessageReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg5rbWVzc2FnZS5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5w",
          "cm90byJ4Cg1NZXNzYWdlUmVjb3JkEhQKDG1lc3NhZ2VfdHlwZRgBIAEoCRIN",
          "CgVvd25lchgCIAEoCRIPCgdtZXNzYWdlGAMgASgJEjEKDWxhc3RfbW9kaWZp",
          "ZWQYBCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MessageRecord), global::MessageRecord.Parser, new[]{ "MessageType", "Owner", "Message", "LastModified" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class MessageRecord : pb::IMessage<MessageRecord>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MessageRecord> _parser = new pb::MessageParser<MessageRecord>(() => new MessageRecord());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MessageRecord> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::KmessageReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MessageRecord() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MessageRecord(MessageRecord other) : this() {
    messageType_ = other.messageType_;
    owner_ = other.owner_;
    message_ = other.message_;
    lastModified_ = other.lastModified_ != null ? other.lastModified_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MessageRecord Clone() {
    return new MessageRecord(this);
  }

  /// <summary>Field number for the "message_type" field.</summary>
  public const int MessageTypeFieldNumber = 1;
  private string messageType_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string MessageType {
    get { return messageType_; }
    set {
      messageType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "owner" field.</summary>
  public const int OwnerFieldNumber = 2;
  private string owner_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Owner {
    get { return owner_; }
    set {
      owner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "message" field.</summary>
  public const int MessageFieldNumber = 3;
  private string message_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "last_modified" field.</summary>
  public const int LastModifiedFieldNumber = 4;
  private global::Google.Protobuf.WellKnownTypes.Timestamp lastModified_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Google.Protobuf.WellKnownTypes.Timestamp LastModified {
    get { return lastModified_; }
    set {
      lastModified_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MessageRecord);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MessageRecord other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MessageType != other.MessageType) return false;
    if (Owner != other.Owner) return false;
    if (Message != other.Message) return false;
    if (!object.Equals(LastModified, other.LastModified)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (MessageType.Length != 0) hash ^= MessageType.GetHashCode();
    if (Owner.Length != 0) hash ^= Owner.GetHashCode();
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (lastModified_ != null) hash ^= LastModified.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (MessageType.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(MessageType);
    }
    if (Owner.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Owner);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Message);
    }
    if (lastModified_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(LastModified);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (MessageType.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(MessageType);
    }
    if (Owner.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Owner);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Message);
    }
    if (lastModified_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(LastModified);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (MessageType.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageType);
    }
    if (Owner.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Owner);
    }
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    if (lastModified_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastModified);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MessageRecord other) {
    if (other == null) {
      return;
    }
    if (other.MessageType.Length != 0) {
      MessageType = other.MessageType;
    }
    if (other.Owner.Length != 0) {
      Owner = other.Owner;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    if (other.lastModified_ != null) {
      if (lastModified_ == null) {
        LastModified = new global::Google.Protobuf.WellKnownTypes.Timestamp();
      }
      LastModified.MergeFrom(other.LastModified);
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
    if ((tag & 7) == 4) {
      // Abort on any end group tag.
      return;
    }
    switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          MessageType = input.ReadString();
          break;
        }
        case 18: {
          Owner = input.ReadString();
          break;
        }
        case 26: {
          Message = input.ReadString();
          break;
        }
        case 34: {
          if (lastModified_ == null) {
            LastModified = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(LastModified);
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
    if ((tag & 7) == 4) {
      // Abort on any end group tag.
      return;
    }
    switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          MessageType = input.ReadString();
          break;
        }
        case 18: {
          Owner = input.ReadString();
          break;
        }
        case 26: {
          Message = input.ReadString();
          break;
        }
        case 34: {
          if (lastModified_ == null) {
            LastModified = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(LastModified);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
