using System;
using System.Collections.Generic;
using message;
using proto;
using tcp;

namespace COW;

public class SceneEditSlotInfo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__117_0;

		public static Func<DDOMMLBFCJM, WorkshopCommentTag> _003C_003E9__136_0;

		public static Func<WorkshopCommentTag, DDOMMLBFCJM> _003C_003E9__142_0;

		public static Func<uint, bool> _003C_003E9__149_0;

		internal bool _003Cget_IsUGCVipMap_003Eb__117_0(uint x)
		{
			return false;
		}

		internal WorkshopCommentTag _003CMergeFromMetaData_003Eb__136_0(DDOMMLBFCJM x)
		{
			return null;
		}

		internal DDOMMLBFCJM _003Cop_Implicit_003Eb__142_0(WorkshopCommentTag x)
		{
			return null;
		}

		internal bool _003CIsOfflineMode_003Eb__149_0(uint tag)
		{
			return false;
		}
	}

	public proto.EWorkshop.SlotType SlotType;

	public uint SlotId;

	public proto.EWorkshop.SlotState SlotState;

	public string Name;

	public ulong AuthorId;

	public ulong PrefCost;

	public long UpdateTime;

	public ulong ResCnt;

	public string ShareCode;

	public string AuthorName;

	public ulong LikeCount;

	public ulong SubCount;

	public uint[] Tags;

	public uint GameMode;

	public uint GroupMode;

	public string WorkShopDesc;

	public CLMPMGMIDGD ModeSettings;

	public byte[] BitMiniMap;

	public byte[] IconMiniMap;

	public uint TeamCount;

	public uint MapId;

	public List<JODIOFLFODG.ECDAECLKNKF> UserDefinedStrings;

	public ulong RuntimeDataLength;

	public ulong ProjectDataLength;

	public byte[] RuntimeDataMD5;

	public byte[] ProjectDataMD5;

	public bool LocalSave;

	public uint ModeTemplateId;

	public CNDCGBPDHEB.HLKDGIHIJPI ErrorSeverity;

	public List<WorkshopCommentTag> CommentTags;

	public proto.EWorkshop.EditorType EditorType;

	public bool SecEdit;

	public bool AllowRecreation;

	public string OriginalWorkshopCode;

	public ulong HeatCount;

	public uint PublicVersion;

	public string ExportDataUrl;

	public byte[] CustomCover;

	public string CustomCoverUrl;

	public long NotifySubscriberTime;

	public float LikeRate;

	public uint MinPlayTime;

	public uint MaxPlayTime;

	public ulong DislikeCount;

	public string SubDesc;

	public EBIAKBJBBGM HalfWayJoinRule;

	public uint[] TimeLimitTags;

	public WorkshopMatchmakingRule MatchMakingRule;

	public uint TotalBlocksCount;

	public uint TotalWidgetsCount;

	public uint TotalHudCount;

	public uint[] FeatureIDs;

	private ulong m_StartEditTime;

	private BGKJLDMJGIB m_EditRecordData;

	public uint AreaID;

	public ulong SubscribedTime;

	public uint HideMinimap;

	public ulong MapLockStartTime;

	public ulong MapLockEndTime;

	public MFDKDILMLFP CompatibleVersion;

	public uint[] KolAuthorLabelID;

	public uint[] KolMapLabelID;

	public uint SoftBanReason;

	private uint[] OrderlyTags;

	public bool Enable_Preview;

	public uint PlotCount;

	public uint PlotDialogueCount;

	public uint GameModeSlotID;

	public EUGCGameModeSlotType GameModeSlotMode;

	public string LastPlayAt;

	public bool MapScoreCalculated;

	public int MapScore;

	public WorkshopMapContentInfo WorkshopNameContent;

	public WorkshopMapContentInfo WorkshopDescContent;

	public uint ClientBlockScriptCount;

	public uint GSBlockScriptCount;

	public uint ClientBlockCount;

	private int m_EditRecordDataVersion;

	public List<string> PlatformLeaderboardNames;

	public List<byte[]> DataStorage;

	public List<byte[]> LeaderBoard;

	public List<EIJCHJHFFGI> ItemLevelObjectInfo;

	public List<EBEIAALOCBN> ResourceLevelObjectInfo;

	public uint TimelineAssetCount;

	public uint UserCustomEventCount;

	public uint UserCustomEventBlockCount;

	public long UpdateTimeServer;

	public bool HasDataStorage;

	public bool OfflineResReady;

	public long PlayTime;

	public string RecommendCoverUrl;

	public uint[] EditGenreID;

	public uint[] ServerGenreID;

	public uint SlotIdServer;

	public string LongShareCode;

	public bool Abstract;

	public bool IsTutorial;

	public string OfflineCustomCoverUrl;

	public byte[] CustomCoverMD5;

	public int AutoDownloadIndex;

	public uint UGCSocialFlag;

	public bool EnableAutoStorage;

	public proto.EWorkshop.MapCoverAuditStatus MapCoverAuditState;

	public ulong PlayCount;

	public bool UseHeatValue;

	public string MapCenterRegion;

	public bool AllowCrossCenterRegion;

	public uint CreatorLv;

	public proto.CreatorPrivilegeSwitches CreatorPrivilegeSwitches;

	public FHBBCOJKLHD LogCache;

	public ulong DisplayHeatOrPlayCount => 0uL;

	public byte[] ServerCustomCover => null;

	public BGKJLDMJGIB EditRecordData => null;

	public bool IsUGCVipMap => false;

	public override string ToString()
	{
		return null;
	}

	public bool IsLocked()
	{
		return false;
	}

	public bool IsEmpty()
	{
		return false;
	}

	public bool IsFE()
	{
		return false;
	}

	public void LocalSlotInfoMergeFromServer(SceneEditSlotInfo serverSlotInfo)
	{
	}

	public void ApplyDisplayInfo(SceneEditSlotInfo displayInfo)
	{
	}

	public static implicit operator SceneEditSlotInfo(ResourceDownloadInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopAuthorSlotInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopSubscribeSlotInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopBasicInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopPersonalRecommendationInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopCraftlandRecommendationInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopLatestInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopRecommendSeriesInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopHotInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(WorkshopEditorChoiceInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(tcp.RoomInfo data)
	{
		return null;
	}

	public static implicit operator SceneEditSlotInfo(KKMFBJGIEBD data)
	{
		return null;
	}

	public void MergeFromMetaData(KKMFBJGIEBD data)
	{
	}

	public void SetEmpty()
	{
	}

	public void CopyBasicInfoFrom(SceneEditSlotInfo info)
	{
	}

	public void CopyBasicInfoForSecEdit(SceneEditSlotInfo info)
	{
	}

	public void CopySlotDataNotInGameCache(SceneEditSlotInfo src)
	{
	}

	public void CopyBasicInfoFrom(WorkshopBasicInfo info)
	{
	}

	public static implicit operator KKMFBJGIEBD(SceneEditSlotInfo info)
	{
		return null;
	}

	public void StartEdit()
	{
	}

	public void ExitEdit(bool save)
	{
	}

	public bool SaveAsUGCMetaData()
	{
		return false;
	}

	public void ReloadProjectEditRecordData()
	{
	}

	public void ReleaseProjectEditRecordData()
	{
	}

	public uint[] GetSortTags()
	{
		return null;
	}

	public bool IsOfflineMode()
	{
		return false;
	}

	private uint[] StableSortTags(uint[] tags)
	{
		return null;
	}

	public static void SortTags(List<WorkshopModeTagData> list)
	{
	}

	private static void MergeTags(List<WorkshopModeTagData> list, List<WorkshopModeTagData> left, List<WorkshopModeTagData> right)
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
