// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: health.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.Health.V1 {

  /// <summary>Holder for reflection information generated from health.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class HealthReflection {

    #region Descriptor
    /// <summary>File descriptor for health.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HealthReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxoZWFsdGgucHJvdG8SDmdycGMuaGVhbHRoLnYxIiUKEkhlYWx0aENoZWNr",
            "UmVxdWVzdBIPCgdzZXJ2aWNlGAEgASgJIpQBChNIZWFsdGhDaGVja1Jlc3Bv",
            "bnNlEkEKBnN0YXR1cxgBIAEoDjIxLmdycGMuaGVhbHRoLnYxLkhlYWx0aENo",
            "ZWNrUmVzcG9uc2UuU2VydmluZ1N0YXR1cyI6Cg1TZXJ2aW5nU3RhdHVzEgsK",
            "B1VOS05PV04QABILCgdTRVJWSU5HEAESDwoLTk9UX1NFUlZJTkcQAjJaCgZI",
            "ZWFsdGgSUAoFQ2hlY2sSIi5ncnBjLmhlYWx0aC52MS5IZWFsdGhDaGVja1Jl",
            "cXVlc3QaIy5ncnBjLmhlYWx0aC52MS5IZWFsdGhDaGVja1Jlc3BvbnNlQhGq",
            "Ag5HcnBjLkhlYWx0aC5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::Grpc.Health.V1.HealthCheckRequest), global::Grpc.Health.V1.HealthCheckRequest.Parser, new[]{ "Service" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Grpc.Health.V1.HealthCheckResponse), global::Grpc.Health.V1.HealthCheckResponse.Parser, new[]{ "Status" }, null, new[]{ typeof(global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class HealthCheckRequest : pb::IMessage<HealthCheckRequest> {
    private static readonly pb::MessageParser<HealthCheckRequest> _parser = new pb::MessageParser<HealthCheckRequest>(() => new HealthCheckRequest());
    public static pb::MessageParser<HealthCheckRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Health.V1.HealthReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public HealthCheckRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public HealthCheckRequest(HealthCheckRequest other) : this() {
      service_ = other.service_;
    }

    public HealthCheckRequest Clone() {
      return new HealthCheckRequest(this);
    }

    /// <summary>Field number for the "service" field.</summary>
    public const int ServiceFieldNumber = 1;
    private string service_ = "";
    public string Service {
      get { return service_; }
      set {
        service_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as HealthCheckRequest);
    }

    public bool Equals(HealthCheckRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Service != other.Service) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Service.Length != 0) hash ^= Service.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Service.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Service);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Service.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Service);
      }
      return size;
    }

    public void MergeFrom(HealthCheckRequest other) {
      if (other == null) {
        return;
      }
      if (other.Service.Length != 0) {
        Service = other.Service;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Service = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class HealthCheckResponse : pb::IMessage<HealthCheckResponse> {
    private static readonly pb::MessageParser<HealthCheckResponse> _parser = new pb::MessageParser<HealthCheckResponse>(() => new HealthCheckResponse());
    public static pb::MessageParser<HealthCheckResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Health.V1.HealthReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public HealthCheckResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public HealthCheckResponse(HealthCheckResponse other) : this() {
      status_ = other.status_;
    }

    public HealthCheckResponse Clone() {
      return new HealthCheckResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus status_ = global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus.UNKNOWN;
    public global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as HealthCheckResponse);
    }

    public bool Equals(HealthCheckResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus.UNKNOWN) hash ^= Status.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus.UNKNOWN) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Status != global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus.UNKNOWN) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      return size;
    }

    public void MergeFrom(HealthCheckResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus.UNKNOWN) {
        Status = other.Status;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            status_ = (global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the HealthCheckResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum ServingStatus {
        UNKNOWN = 0,
        SERVING = 1,
        NOT_SERVING = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
