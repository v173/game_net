// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: enum.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace KKSG {

  /// <summary>Holder for reflection information generated from enum.proto</summary>
  public static partial class EnumReflection {

    #region Descriptor
    /// <summary>File descriptor for enum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgplbnVtLnByb3RvEgRLS1NHKpYBCghLaWNrVHlwZRIPCgtLSUNLX05PUk1B",
            "TBAAEhAKDEtJQ0tfUkVMT0dJThABEhEKDUtJQ0tfR01GT1JCSUQQAhIYChRL",
            "SUNLX1NFUlZFUl9TSFVURE9XThADEhEKDUtJQ0tfREVMX1JPTEUQBBIaChZL",
            "SUNLX0NIQU5HRV9QUk9GRVNTSU9OEAUSCwoHS0lDS19IRxAGKqcFCg5HdWls",
            "ZEJvbnVzVHlwZRISCg5HQk9OVVNfTEVWRUxVUBAAEhUKEUdCT05VU19DQVJE",
            "UkVXQVJEEAISFQoRR0JPTlVTX0tJTExEUkFHT04QAxIWChJHQk9OVVNfR1VJ",
            "TERHT0JMSU4QBBIeChpHQk9OVVNfR1VJTERHT0JMSU5fTEVWRUxVUBAFEhIK",
            "DkdCT05VU19DSEVDS0lOEAYSFQoRR0JPTlVTX1RJQU5USVJBTksQBxIaChZH",
            "Qk9OVVNfS0lMTFNUQUdFRFJBR09OEAgSFgoSR0JPTlVTX0NIQVJHRVRJTUVT",
            "EAkSEwoPR0JPTlVTX1ZJUExFVkVMEAoSGgoWR0JPTlVTX0RSQVdMT1RURVJZ",
            "X1RFThALEhAKDEdCT05VU19USVRMRRAMEhUKEUdCT05VU19TVFJFTkdUSEVO",
            "EA0SEAoMR0JPTlVTX1RPV0VSEA4SFAoQR0JPTlVTX1RJTUVCT05VUxAPEhoK",
            "FkdCT05VU19DSEFSR0VQUklWSUxFR0UQEBIXChNHQk9OVVNfUFVSQ0hBU0VG",
            "VU5EEBESHwobR0JPTlVTX0RSQUdPTkpBREVMX0FMTExFVkVMEBISGQoVR0JP",
            "TlVTX1NLWUFSRU5BX0ZMT09SEBMSGAoUR0JPTlVTX0hPUlNFX1FVQUxJVFkQ",
            "FBIbChdHQk9OVVNfRFJBR09OTkVTVF9TQ0VORRAVEhMKD0dCT05VU19HTUZf",
            "UkFOSxAWEhMKD0dCT05VU19CT1NTUlVTSBAXEhQKEEdCT05VU19CVVlJQlNI",
            "T1AQGBIVChFHQk9OVVNfTUFZSEVNUkFOSxAZEhcKE0dCT05VU19VU0VUSFJF",
            "RVNVSVQQGhISCg5HQk9OVVNfVVNFSVRFTRAbEg4KCkdCT05VU19NQVgQHEIC",
            "SANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::KKSG.KickType), typeof(global::KKSG.GuildBonusType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum KickType {
    [pbr::OriginalName("KICK_NORMAL")] KickNormal = 0,
    [pbr::OriginalName("KICK_RELOGIN")] KickRelogin = 1,
    [pbr::OriginalName("KICK_GMFORBID")] KickGmforbid = 2,
    [pbr::OriginalName("KICK_SERVER_SHUTDOWN")] KickServerShutdown = 3,
    [pbr::OriginalName("KICK_DEL_ROLE")] KickDelRole = 4,
    [pbr::OriginalName("KICK_CHANGE_PROFESSION")] KickChangeProfession = 5,
    [pbr::OriginalName("KICK_HG")] KickHg = 6,
  }

  public enum GuildBonusType {
    [pbr::OriginalName("GBONUS_LEVELUP")] GbonusLevelup = 0,
    [pbr::OriginalName("GBONUS_CARDREWARD")] GbonusCardreward = 2,
    [pbr::OriginalName("GBONUS_KILLDRAGON")] GbonusKilldragon = 3,
    [pbr::OriginalName("GBONUS_GUILDGOBLIN")] GbonusGuildgoblin = 4,
    [pbr::OriginalName("GBONUS_GUILDGOBLIN_LEVELUP")] GbonusGuildgoblinLevelup = 5,
    [pbr::OriginalName("GBONUS_CHECKIN")] GbonusCheckin = 6,
    [pbr::OriginalName("GBONUS_TIANTIRANK")] GbonusTiantirank = 7,
    [pbr::OriginalName("GBONUS_KILLSTAGEDRAGON")] GbonusKillstagedragon = 8,
    [pbr::OriginalName("GBONUS_CHARGETIMES")] GbonusChargetimes = 9,
    [pbr::OriginalName("GBONUS_VIPLEVEL")] GbonusViplevel = 10,
    [pbr::OriginalName("GBONUS_DRAWLOTTERY_TEN")] GbonusDrawlotteryTen = 11,
    [pbr::OriginalName("GBONUS_TITLE")] GbonusTitle = 12,
    [pbr::OriginalName("GBONUS_STRENGTHEN")] GbonusStrengthen = 13,
    [pbr::OriginalName("GBONUS_TOWER")] GbonusTower = 14,
    [pbr::OriginalName("GBONUS_TIMEBONUS")] GbonusTimebonus = 15,
    [pbr::OriginalName("GBONUS_CHARGEPRIVILEGE")] GbonusChargeprivilege = 16,
    [pbr::OriginalName("GBONUS_PURCHASEFUND")] GbonusPurchasefund = 17,
    [pbr::OriginalName("GBONUS_DRAGONJADEL_ALLLEVEL")] GbonusDragonjadelAlllevel = 18,
    [pbr::OriginalName("GBONUS_SKYARENA_FLOOR")] GbonusSkyarenaFloor = 19,
    [pbr::OriginalName("GBONUS_HORSE_QUALITY")] GbonusHorseQuality = 20,
    [pbr::OriginalName("GBONUS_DRAGONNEST_SCENE")] GbonusDragonnestScene = 21,
    [pbr::OriginalName("GBONUS_GMF_RANK")] GbonusGmfRank = 22,
    [pbr::OriginalName("GBONUS_BOSSRUSH")] GbonusBossrush = 23,
    [pbr::OriginalName("GBONUS_BUYIBSHOP")] GbonusBuyibshop = 24,
    [pbr::OriginalName("GBONUS_MAYHEMRANK")] GbonusMayhemrank = 25,
    [pbr::OriginalName("GBONUS_USETHREESUIT")] GbonusUsethreesuit = 26,
    [pbr::OriginalName("GBONUS_USEITEM")] GbonusUseitem = 27,
    [pbr::OriginalName("GBONUS_MAX")] GbonusMax = 28,
  }

  #endregion

}

#endregion Designer generated code
