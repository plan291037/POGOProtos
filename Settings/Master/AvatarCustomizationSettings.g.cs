// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Settings/Master/AvatarCustomizationSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/AvatarCustomizationSettings.proto</summary>
  public static partial class AvatarCustomizationSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/AvatarCustomizationSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarCustomizationSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9BdmF0YXJDdXN0b21pemF0",
            "aW9uU2V0dGluZ3MucHJvdG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVy",
            "Gi1QT0dPUHJvdG9zL0RhdGEvUGxheWVyL1BsYXllckF2YXRhclR5cGUucHJv",
            "dG8aIFBPR09Qcm90b3MvRW51bXMvQmFkZ2VUeXBlLnByb3RvGhtQT0dPUHJv",
            "dG9zL0VudW1zL1Nsb3QucHJvdG8i1gUKG0F2YXRhckN1c3RvbWl6YXRpb25T",
            "ZXR0aW5ncxIPCgdlbmFibGVkGAEgASgIEj0KC2F2YXRhcl90eXBlGAIgASgO",
            "MiguUE9HT1Byb3Rvcy5EYXRhLlBsYXllci5QbGF5ZXJBdmF0YXJUeXBlEiQK",
            "BHNsb3QYAyADKA4yFi5QT0dPUHJvdG9zLkVudW1zLlNsb3QSEwoLYnVuZGxl",
            "X25hbWUYBCABKAkSEgoKYXNzZXRfbmFtZRgFIAEoCRISCgpncm91cF9uYW1l",
            "GAYgASgJEhIKCnNvcnRfb3JkZXIYByABKAUSagoLdW5sb2NrX3R5cGUYCCAB",
            "KA4yVS5QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5BdmF0YXJDdXN0b21p",
            "emF0aW9uU2V0dGluZ3MuQXZhdGFyQ3VzdG9taXphdGlvblVubG9ja1R5cGUS",
            "aAoKcHJvbW9fdHlwZRgJIAMoDjJULlBPR09Qcm90b3MuU2V0dGluZ3MuTWFz",
            "dGVyLkF2YXRhckN1c3RvbWl6YXRpb25TZXR0aW5ncy5BdmF0YXJDdXN0b21p",
            "emF0aW9uUHJvbW9UeXBlEjYKEXVubG9ja19iYWRnZV90eXBlGAogASgOMhsu",
            "UE9HT1Byb3Rvcy5FbnVtcy5CYWRnZVR5cGUSGgoSdW5sb2NrX2JhZGdlX2xl",
            "dmVsGAwgASgFEg8KB2lhcF9za3UYCyABKAkiTAocQXZhdGFyQ3VzdG9taXph",
            "dGlvblByb21vVHlwZRIUChBVTlNFVF9QUk9NT19UWVBFEAASCAoEU0FMRRAB",
            "EgwKCEZFQVRVUkVEEAIiZwodQXZhdGFyQ3VzdG9taXphdGlvblVubG9ja1R5",
            "cGUSFQoRVU5TRVRfVU5MT0NLX1RZUEUQABILCgdERUZBVUxUEAESEAoMTUVE",
            "QUxfUkVXQVJEEAISEAoMSUFQX0NMT1RISU5HEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Player.PlayerAvatarTypeReflection.Descriptor, global::POGOProtos.Enums.BadgeTypeReflection.Descriptor, global::POGOProtos.Enums.SlotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.AvatarCustomizationSettings), global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Parser, new[]{ "Enabled", "AvatarType", "Slot", "BundleName", "AssetName", "GroupName", "SortOrder", "UnlockType", "PromoType", "UnlockBadgeType", "UnlockBadgeLevel", "IapSku" }, null, new[]{ typeof(global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationPromoType), typeof(global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationUnlockType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AvatarCustomizationSettings : pb::IMessage<AvatarCustomizationSettings> {
    private static readonly pb::MessageParser<AvatarCustomizationSettings> _parser = new pb::MessageParser<AvatarCustomizationSettings>(() => new AvatarCustomizationSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AvatarCustomizationSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.AvatarCustomizationSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AvatarCustomizationSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AvatarCustomizationSettings(AvatarCustomizationSettings other) : this() {
      enabled_ = other.enabled_;
      avatarType_ = other.avatarType_;
      slot_ = other.slot_.Clone();
      bundleName_ = other.bundleName_;
      assetName_ = other.assetName_;
      groupName_ = other.groupName_;
      sortOrder_ = other.sortOrder_;
      unlockType_ = other.unlockType_;
      promoType_ = other.promoType_.Clone();
      unlockBadgeType_ = other.unlockBadgeType_;
      unlockBadgeLevel_ = other.unlockBadgeLevel_;
      iapSku_ = other.iapSku_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AvatarCustomizationSettings Clone() {
      return new AvatarCustomizationSettings(this);
    }

    /// <summary>Field number for the "enabled" field.</summary>
    public const int EnabledFieldNumber = 1;
    private bool enabled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Enabled {
      get { return enabled_; }
      set {
        enabled_ = value;
      }
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 2;
    private global::POGOProtos.Data.Player.PlayerAvatarType avatarType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.PlayerAvatarType AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "slot" field.</summary>
    public const int SlotFieldNumber = 3;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.Slot> _repeated_slot_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::POGOProtos.Enums.Slot) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.Slot> slot_ = new pbc::RepeatedField<global::POGOProtos.Enums.Slot>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.Slot> Slot {
      get { return slot_; }
    }

    /// <summary>Field number for the "bundle_name" field.</summary>
    public const int BundleNameFieldNumber = 4;
    private string bundleName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BundleName {
      get { return bundleName_; }
      set {
        bundleName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_name" field.</summary>
    public const int AssetNameFieldNumber = 5;
    private string assetName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AssetName {
      get { return assetName_; }
      set {
        assetName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "group_name" field.</summary>
    public const int GroupNameFieldNumber = 6;
    private string groupName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GroupName {
      get { return groupName_; }
      set {
        groupName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sort_order" field.</summary>
    public const int SortOrderFieldNumber = 7;
    private int sortOrder_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SortOrder {
      get { return sortOrder_; }
      set {
        sortOrder_ = value;
      }
    }

    /// <summary>Field number for the "unlock_type" field.</summary>
    public const int UnlockTypeFieldNumber = 8;
    private global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationUnlockType unlockType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationUnlockType UnlockType {
      get { return unlockType_; }
      set {
        unlockType_ = value;
      }
    }

    /// <summary>Field number for the "promo_type" field.</summary>
    public const int PromoTypeFieldNumber = 9;
    private static readonly pb::FieldCodec<global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationPromoType> _repeated_promoType_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationPromoType) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationPromoType> promoType_ = new pbc::RepeatedField<global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationPromoType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationPromoType> PromoType {
      get { return promoType_; }
    }

    /// <summary>Field number for the "unlock_badge_type" field.</summary>
    public const int UnlockBadgeTypeFieldNumber = 10;
    private global::POGOProtos.Enums.BadgeType unlockBadgeType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.BadgeType UnlockBadgeType {
      get { return unlockBadgeType_; }
      set {
        unlockBadgeType_ = value;
      }
    }

    /// <summary>Field number for the "unlock_badge_level" field.</summary>
    public const int UnlockBadgeLevelFieldNumber = 12;
    private int unlockBadgeLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnlockBadgeLevel {
      get { return unlockBadgeLevel_; }
      set {
        unlockBadgeLevel_ = value;
      }
    }

    /// <summary>Field number for the "iap_sku" field.</summary>
    public const int IapSkuFieldNumber = 11;
    private string iapSku_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IapSku {
      get { return iapSku_; }
      set {
        iapSku_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AvatarCustomizationSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AvatarCustomizationSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Enabled != other.Enabled) return false;
      if (AvatarType != other.AvatarType) return false;
      if(!slot_.Equals(other.slot_)) return false;
      if (BundleName != other.BundleName) return false;
      if (AssetName != other.AssetName) return false;
      if (GroupName != other.GroupName) return false;
      if (SortOrder != other.SortOrder) return false;
      if (UnlockType != other.UnlockType) return false;
      if(!promoType_.Equals(other.promoType_)) return false;
      if (UnlockBadgeType != other.UnlockBadgeType) return false;
      if (UnlockBadgeLevel != other.UnlockBadgeLevel) return false;
      if (IapSku != other.IapSku) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Enabled != false) hash ^= Enabled.GetHashCode();
      if (AvatarType != 0) hash ^= AvatarType.GetHashCode();
      hash ^= slot_.GetHashCode();
      if (BundleName.Length != 0) hash ^= BundleName.GetHashCode();
      if (AssetName.Length != 0) hash ^= AssetName.GetHashCode();
      if (GroupName.Length != 0) hash ^= GroupName.GetHashCode();
      if (SortOrder != 0) hash ^= SortOrder.GetHashCode();
      if (UnlockType != 0) hash ^= UnlockType.GetHashCode();
      hash ^= promoType_.GetHashCode();
      if (UnlockBadgeType != 0) hash ^= UnlockBadgeType.GetHashCode();
      if (UnlockBadgeLevel != 0) hash ^= UnlockBadgeLevel.GetHashCode();
      if (IapSku.Length != 0) hash ^= IapSku.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Enabled != false) {
        output.WriteRawTag(8);
        output.WriteBool(Enabled);
      }
      if (AvatarType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) AvatarType);
      }
      slot_.WriteTo(output, _repeated_slot_codec);
      if (BundleName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(BundleName);
      }
      if (AssetName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AssetName);
      }
      if (GroupName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(GroupName);
      }
      if (SortOrder != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(SortOrder);
      }
      if (UnlockType != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) UnlockType);
      }
      promoType_.WriteTo(output, _repeated_promoType_codec);
      if (UnlockBadgeType != 0) {
        output.WriteRawTag(80);
        output.WriteEnum((int) UnlockBadgeType);
      }
      if (IapSku.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(IapSku);
      }
      if (UnlockBadgeLevel != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(UnlockBadgeLevel);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Enabled != false) {
        size += 1 + 1;
      }
      if (AvatarType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
      }
      size += slot_.CalculateSize(_repeated_slot_codec);
      if (BundleName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BundleName);
      }
      if (AssetName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetName);
      }
      if (GroupName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GroupName);
      }
      if (SortOrder != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SortOrder);
      }
      if (UnlockType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnlockType);
      }
      size += promoType_.CalculateSize(_repeated_promoType_codec);
      if (UnlockBadgeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnlockBadgeType);
      }
      if (UnlockBadgeLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnlockBadgeLevel);
      }
      if (IapSku.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IapSku);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AvatarCustomizationSettings other) {
      if (other == null) {
        return;
      }
      if (other.Enabled != false) {
        Enabled = other.Enabled;
      }
      if (other.AvatarType != 0) {
        AvatarType = other.AvatarType;
      }
      slot_.Add(other.slot_);
      if (other.BundleName.Length != 0) {
        BundleName = other.BundleName;
      }
      if (other.AssetName.Length != 0) {
        AssetName = other.AssetName;
      }
      if (other.GroupName.Length != 0) {
        GroupName = other.GroupName;
      }
      if (other.SortOrder != 0) {
        SortOrder = other.SortOrder;
      }
      if (other.UnlockType != 0) {
        UnlockType = other.UnlockType;
      }
      promoType_.Add(other.promoType_);
      if (other.UnlockBadgeType != 0) {
        UnlockBadgeType = other.UnlockBadgeType;
      }
      if (other.UnlockBadgeLevel != 0) {
        UnlockBadgeLevel = other.UnlockBadgeLevel;
      }
      if (other.IapSku.Length != 0) {
        IapSku = other.IapSku;
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
          case 8: {
            Enabled = input.ReadBool();
            break;
          }
          case 16: {
            avatarType_ = (global::POGOProtos.Data.Player.PlayerAvatarType) input.ReadEnum();
            break;
          }
          case 26:
          case 24: {
            slot_.AddEntriesFrom(input, _repeated_slot_codec);
            break;
          }
          case 34: {
            BundleName = input.ReadString();
            break;
          }
          case 42: {
            AssetName = input.ReadString();
            break;
          }
          case 50: {
            GroupName = input.ReadString();
            break;
          }
          case 56: {
            SortOrder = input.ReadInt32();
            break;
          }
          case 64: {
            unlockType_ = (global::POGOProtos.Settings.Master.AvatarCustomizationSettings.Types.AvatarCustomizationUnlockType) input.ReadEnum();
            break;
          }
          case 74:
          case 72: {
            promoType_.AddEntriesFrom(input, _repeated_promoType_codec);
            break;
          }
          case 80: {
            unlockBadgeType_ = (global::POGOProtos.Enums.BadgeType) input.ReadEnum();
            break;
          }
          case 90: {
            IapSku = input.ReadString();
            break;
          }
          case 96: {
            UnlockBadgeLevel = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AvatarCustomizationSettings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum AvatarCustomizationPromoType {
        [pbr::OriginalName("UNSET_PROMO_TYPE")] UnsetPromoType = 0,
        [pbr::OriginalName("SALE")] Sale = 1,
        [pbr::OriginalName("FEATURED")] Featured = 2,
      }

      public enum AvatarCustomizationUnlockType {
        [pbr::OriginalName("UNSET_UNLOCK_TYPE")] UnsetUnlockType = 0,
        [pbr::OriginalName("DEFAULT")] Default = 1,
        [pbr::OriginalName("MEDAL_REWARD")] MedalReward = 2,
        [pbr::OriginalName("IAP_CLOTHING")] IapClothing = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
