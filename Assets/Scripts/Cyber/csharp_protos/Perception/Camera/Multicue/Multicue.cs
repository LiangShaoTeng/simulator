// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/perception/camera/lib/obstacle/transformer/multicue/multicue.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Perception.Camera.Multicue {

  /// <summary>Holder for reflection information generated from modules/perception/camera/lib/obstacle/transformer/multicue/multicue.proto</summary>
  public static partial class MulticueReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/perception/camera/lib/obstacle/transformer/multicue/multicue.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MulticueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckptb2R1bGVzL3BlcmNlcHRpb24vY2FtZXJhL2xpYi9vYnN0YWNsZS90cmFu",
            "c2Zvcm1lci9tdWx0aWN1ZS9tdWx0aWN1ZS5wcm90bxIhYXBvbGxvLnBlcmNl",
            "cHRpb24uY2FtZXJhLm11bHRpY3VlIkMKDU11bHRpY3VlUGFyYW0SGQoRbWlu",
            "X2RpbWVuc2lvbl92YWwYASABKAISFwoPY2hlY2tfZGltZW5zaW9uGAIgASgI",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Perception.Camera.Multicue.MulticueParam), global::Apollo.Perception.Camera.Multicue.MulticueParam.Parser, new[]{ "MinDimensionVal", "CheckDimension" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MulticueParam : pb::IMessage<MulticueParam> {
    private static readonly pb::MessageParser<MulticueParam> _parser = new pb::MessageParser<MulticueParam>(() => new MulticueParam());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MulticueParam> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Perception.Camera.Multicue.MulticueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MulticueParam() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MulticueParam(MulticueParam other) : this() {
      minDimensionVal_ = other.minDimensionVal_;
      checkDimension_ = other.checkDimension_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MulticueParam Clone() {
      return new MulticueParam(this);
    }

    /// <summary>Field number for the "min_dimension_val" field.</summary>
    public const int MinDimensionValFieldNumber = 1;
    private float minDimensionVal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float MinDimensionVal {
      get { return minDimensionVal_; }
      set {
        minDimensionVal_ = value;
      }
    }

    /// <summary>Field number for the "check_dimension" field.</summary>
    public const int CheckDimensionFieldNumber = 2;
    private bool checkDimension_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CheckDimension {
      get { return checkDimension_; }
      set {
        checkDimension_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MulticueParam);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MulticueParam other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinDimensionVal != other.MinDimensionVal) return false;
      if (CheckDimension != other.CheckDimension) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MinDimensionVal != 0F) hash ^= MinDimensionVal.GetHashCode();
      if (CheckDimension != false) hash ^= CheckDimension.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MinDimensionVal != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(MinDimensionVal);
      }
      if (CheckDimension != false) {
        output.WriteRawTag(16);
        output.WriteBool(CheckDimension);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MinDimensionVal != 0F) {
        size += 1 + 4;
      }
      if (CheckDimension != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MulticueParam other) {
      if (other == null) {
        return;
      }
      if (other.MinDimensionVal != 0F) {
        MinDimensionVal = other.MinDimensionVal;
      }
      if (other.CheckDimension != false) {
        CheckDimension = other.CheckDimension;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            MinDimensionVal = input.ReadFloat();
            break;
          }
          case 16: {
            CheckDimension = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
