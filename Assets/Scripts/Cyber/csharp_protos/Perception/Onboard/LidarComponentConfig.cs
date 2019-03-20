// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/perception/onboard/proto/lidar_component_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Perception.Onboard {

  /// <summary>Holder for reflection information generated from modules/perception/onboard/proto/lidar_component_config.proto</summary>
  public static partial class LidarComponentConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/perception/onboard/proto/lidar_component_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LidarComponentConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1tb2R1bGVzL3BlcmNlcHRpb24vb25ib2FyZC9wcm90by9saWRhcl9jb21w",
            "b25lbnRfY29uZmlnLnByb3RvEhlhcG9sbG8ucGVyY2VwdGlvbi5vbmJvYXJk",
            "IrMBCiBMaWRhclNlZ21lbnRhdGlvbkNvbXBvbmVudENvbmZpZxITCgtzZW5z",
            "b3JfbmFtZRgBIAEoCRIUCgxlbmFibGVfaGRtYXAYAiABKAgSHQoVbGlkYXJf",
            "cXVlcnlfdGZfb2Zmc2V0GAMgASgBEigKIGxpZGFyMm5vdmF0ZWxfdGYyX2No",
            "aWxkX2ZyYW1lX2lkGAQgASgJEhsKE291dHB1dF9jaGFubmVsX25hbWUYBSAB",
            "KAkiWAofTGlkYXJSZWNvZ25pdGlvbkNvbXBvbmVudENvbmZpZxIYChBtYWlu",
            "X3NlbnNvcl9uYW1lGAEgASgJEhsKE291dHB1dF9jaGFubmVsX25hbWUYAiAB",
            "KAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Perception.Onboard.LidarSegmentationComponentConfig), global::Apollo.Perception.Onboard.LidarSegmentationComponentConfig.Parser, new[]{ "SensorName", "EnableHdmap", "LidarQueryTfOffset", "Lidar2NovatelTf2ChildFrameId", "OutputChannelName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Perception.Onboard.LidarRecognitionComponentConfig), global::Apollo.Perception.Onboard.LidarRecognitionComponentConfig.Parser, new[]{ "MainSensorName", "OutputChannelName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LidarSegmentationComponentConfig : pb::IMessage<LidarSegmentationComponentConfig> {
    private static readonly pb::MessageParser<LidarSegmentationComponentConfig> _parser = new pb::MessageParser<LidarSegmentationComponentConfig>(() => new LidarSegmentationComponentConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LidarSegmentationComponentConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Perception.Onboard.LidarComponentConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LidarSegmentationComponentConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LidarSegmentationComponentConfig(LidarSegmentationComponentConfig other) : this() {
      sensorName_ = other.sensorName_;
      enableHdmap_ = other.enableHdmap_;
      lidarQueryTfOffset_ = other.lidarQueryTfOffset_;
      lidar2NovatelTf2ChildFrameId_ = other.lidar2NovatelTf2ChildFrameId_;
      outputChannelName_ = other.outputChannelName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LidarSegmentationComponentConfig Clone() {
      return new LidarSegmentationComponentConfig(this);
    }

    /// <summary>Field number for the "sensor_name" field.</summary>
    public const int SensorNameFieldNumber = 1;
    private string sensorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SensorName {
      get { return sensorName_; }
      set {
        sensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enable_hdmap" field.</summary>
    public const int EnableHdmapFieldNumber = 2;
    private bool enableHdmap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableHdmap {
      get { return enableHdmap_; }
      set {
        enableHdmap_ = value;
      }
    }

    /// <summary>Field number for the "lidar_query_tf_offset" field.</summary>
    public const int LidarQueryTfOffsetFieldNumber = 3;
    private double lidarQueryTfOffset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LidarQueryTfOffset {
      get { return lidarQueryTfOffset_; }
      set {
        lidarQueryTfOffset_ = value;
      }
    }

    /// <summary>Field number for the "lidar2novatel_tf2_child_frame_id" field.</summary>
    public const int Lidar2NovatelTf2ChildFrameIdFieldNumber = 4;
    private string lidar2NovatelTf2ChildFrameId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Lidar2NovatelTf2ChildFrameId {
      get { return lidar2NovatelTf2ChildFrameId_; }
      set {
        lidar2NovatelTf2ChildFrameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "output_channel_name" field.</summary>
    public const int OutputChannelNameFieldNumber = 5;
    private string outputChannelName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OutputChannelName {
      get { return outputChannelName_; }
      set {
        outputChannelName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LidarSegmentationComponentConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LidarSegmentationComponentConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SensorName != other.SensorName) return false;
      if (EnableHdmap != other.EnableHdmap) return false;
      if (LidarQueryTfOffset != other.LidarQueryTfOffset) return false;
      if (Lidar2NovatelTf2ChildFrameId != other.Lidar2NovatelTf2ChildFrameId) return false;
      if (OutputChannelName != other.OutputChannelName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SensorName.Length != 0) hash ^= SensorName.GetHashCode();
      if (EnableHdmap != false) hash ^= EnableHdmap.GetHashCode();
      if (LidarQueryTfOffset != 0D) hash ^= LidarQueryTfOffset.GetHashCode();
      if (Lidar2NovatelTf2ChildFrameId.Length != 0) hash ^= Lidar2NovatelTf2ChildFrameId.GetHashCode();
      if (OutputChannelName.Length != 0) hash ^= OutputChannelName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SensorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SensorName);
      }
      if (EnableHdmap != false) {
        output.WriteRawTag(16);
        output.WriteBool(EnableHdmap);
      }
      if (LidarQueryTfOffset != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(LidarQueryTfOffset);
      }
      if (Lidar2NovatelTf2ChildFrameId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Lidar2NovatelTf2ChildFrameId);
      }
      if (OutputChannelName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OutputChannelName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SensorName);
      }
      if (EnableHdmap != false) {
        size += 1 + 1;
      }
      if (LidarQueryTfOffset != 0D) {
        size += 1 + 8;
      }
      if (Lidar2NovatelTf2ChildFrameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Lidar2NovatelTf2ChildFrameId);
      }
      if (OutputChannelName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OutputChannelName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LidarSegmentationComponentConfig other) {
      if (other == null) {
        return;
      }
      if (other.SensorName.Length != 0) {
        SensorName = other.SensorName;
      }
      if (other.EnableHdmap != false) {
        EnableHdmap = other.EnableHdmap;
      }
      if (other.LidarQueryTfOffset != 0D) {
        LidarQueryTfOffset = other.LidarQueryTfOffset;
      }
      if (other.Lidar2NovatelTf2ChildFrameId.Length != 0) {
        Lidar2NovatelTf2ChildFrameId = other.Lidar2NovatelTf2ChildFrameId;
      }
      if (other.OutputChannelName.Length != 0) {
        OutputChannelName = other.OutputChannelName;
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
          case 10: {
            SensorName = input.ReadString();
            break;
          }
          case 16: {
            EnableHdmap = input.ReadBool();
            break;
          }
          case 25: {
            LidarQueryTfOffset = input.ReadDouble();
            break;
          }
          case 34: {
            Lidar2NovatelTf2ChildFrameId = input.ReadString();
            break;
          }
          case 42: {
            OutputChannelName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LidarRecognitionComponentConfig : pb::IMessage<LidarRecognitionComponentConfig> {
    private static readonly pb::MessageParser<LidarRecognitionComponentConfig> _parser = new pb::MessageParser<LidarRecognitionComponentConfig>(() => new LidarRecognitionComponentConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LidarRecognitionComponentConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Perception.Onboard.LidarComponentConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LidarRecognitionComponentConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LidarRecognitionComponentConfig(LidarRecognitionComponentConfig other) : this() {
      mainSensorName_ = other.mainSensorName_;
      outputChannelName_ = other.outputChannelName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LidarRecognitionComponentConfig Clone() {
      return new LidarRecognitionComponentConfig(this);
    }

    /// <summary>Field number for the "main_sensor_name" field.</summary>
    public const int MainSensorNameFieldNumber = 1;
    private string mainSensorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MainSensorName {
      get { return mainSensorName_; }
      set {
        mainSensorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "output_channel_name" field.</summary>
    public const int OutputChannelNameFieldNumber = 2;
    private string outputChannelName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OutputChannelName {
      get { return outputChannelName_; }
      set {
        outputChannelName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LidarRecognitionComponentConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LidarRecognitionComponentConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MainSensorName != other.MainSensorName) return false;
      if (OutputChannelName != other.OutputChannelName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MainSensorName.Length != 0) hash ^= MainSensorName.GetHashCode();
      if (OutputChannelName.Length != 0) hash ^= OutputChannelName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MainSensorName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MainSensorName);
      }
      if (OutputChannelName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(OutputChannelName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MainSensorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MainSensorName);
      }
      if (OutputChannelName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OutputChannelName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LidarRecognitionComponentConfig other) {
      if (other == null) {
        return;
      }
      if (other.MainSensorName.Length != 0) {
        MainSensorName = other.MainSensorName;
      }
      if (other.OutputChannelName.Length != 0) {
        OutputChannelName = other.OutputChannelName;
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
          case 10: {
            MainSensorName = input.ReadString();
            break;
          }
          case 18: {
            OutputChannelName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code