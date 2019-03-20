// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/dreamview/proto/point_cloud.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Dreamview {

  /// <summary>Holder for reflection information generated from modules/dreamview/proto/point_cloud.proto</summary>
  public static partial class PointCloudReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/dreamview/proto/point_cloud.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PointCloudReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ciltb2R1bGVzL2RyZWFtdmlldy9wcm90by9wb2ludF9jbG91ZC5wcm90bxIQ",
            "YXBvbGxvLmRyZWFtdmlldyIZCgpQb2ludENsb3VkEgsKA251bRgBIAMoAmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Dreamview.PointCloud), global::Apollo.Dreamview.PointCloud.Parser, new[]{ "Num" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PointCloud : pb::IMessage<PointCloud> {
    private static readonly pb::MessageParser<PointCloud> _parser = new pb::MessageParser<PointCloud>(() => new PointCloud());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PointCloud> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Dreamview.PointCloudReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PointCloud() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PointCloud(PointCloud other) : this() {
      num_ = other.num_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PointCloud Clone() {
      return new PointCloud(this);
    }

    /// <summary>Field number for the "num" field.</summary>
    public const int NumFieldNumber = 1;
    private static readonly pb::FieldCodec<float> _repeated_num_codec
        = pb::FieldCodec.ForFloat(10);
    private readonly pbc::RepeatedField<float> num_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Num {
      get { return num_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PointCloud);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PointCloud other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!num_.Equals(other.num_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= num_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      num_.WriteTo(output, _repeated_num_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += num_.CalculateSize(_repeated_num_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PointCloud other) {
      if (other == null) {
        return;
      }
      num_.Add(other.num_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 13: {
            num_.AddEntriesFrom(input, _repeated_num_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code