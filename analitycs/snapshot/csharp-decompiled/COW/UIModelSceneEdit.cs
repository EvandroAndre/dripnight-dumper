using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelSceneEdit : UIBaseModel, IUIModelDataChangeObserver
{
	private class TrainingCenterPendingEnterInfo
	{
		public bool IsValid;

		public int Id;

		public int SortId;

		public int Tag;

		public int Tabs;

		public int PreProcess;

		public string ShareCode;

		public uint MapId;

		public void Clear()
		{
		}
	}

	public enum ESpecialPramID
	{
		SkyEnv = 10001,
		Grid,
		MeshGranularity,
		MapDepthDisplay,
		ObjectClean,
		CameraSpeed,
		CasualShop,
		SingleItemShop,
		GridSnap
	}

	public enum UGCAdvancedDataType
	{
		MaxCost,
		HudInterfaceLimit,
		HudControlLimit,
		ObjectLimit,
		ProjectGraphLimit,
		ScriptGraphLimit
	}

	public enum EWorkShopCreateRoomSrc
	{
		Subscription = 3,
		Latest = 5,
		Recommendation = 6,
		MyWorkshop = 7,
		Determined = 8,
		RecentQuickJoin = 9,
		NoMatchMakingAutoCreate = 10,
		MemberCountExceedAutoCreate = 11,
		RoomCurrent = 0
	}

	public class CreatorFeedBackData
	{
		public ulong m_SubscriptionTimes;

		public ulong m_LikedTimes;

		public ulong m_AssetLike;

		public ulong m_AssetBuy;
	}

	[Serializable]
	private class SearchHistoryWrapper
	{
		public List<string> historyList;
	}

	public enum EEnterSceneEditMode
	{
		EMode_Default,
		EMode_MySlot,
		EMode_Preview,
		EMode_CreateNew,
		EMode_TutorialLevel,
		EMode_SecEdit,
		EMode_Photo,
		EMode_InGameSecEdit
	}

	public enum EUGCTutorialEntrySource
	{
		None,
		CreateMapBtnAuto,
		BtnInCreateNewPage
	}

	public enum EWorkshopDownloadType
	{
		EWorkshopDownoadType_None,
		EWorkshopDownloadType_EnterGameMySlot,
		EWorkshopDownloadType_EnterGamePreview,
		EWorkshopDownloadType_LobbySaveAs,
		EWorkshopDownloadType_InGameSecEdit,
		EWorkshopDownloadType_DownloadAndSave
	}

	public enum EWorkshopDelType
	{
		EWorkshopDelType_None,
		EWorkshopDelType_Local,
		EWorkshopDelType_Online,
		EWorkshopDelType_Both
	}

	public enum EQuickSubResult
	{
		EDel,
		ESub,
		EFull,
		EAutoCover
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<proto.WorkshopDirtyPicture, bool> _003C_003E9__438_0;

		public static Func<proto.WorkshopDirtyPicture, bool> _003C_003E9__438_1;

		public static Action<HttpErrorCode, object> _003C_003E9__457_0;

		public static Converter<tcp.WorkshopDirtyWord, proto.WorkshopDirtyWord> _003C_003E9__467_0;

		public static Converter<tcp.WorkshopDirtyPicture, proto.WorkshopDirtyPicture> _003C_003E9__467_1;

		public static Converter<tcp.WorkshopDirtyPicture, proto.WorkshopDirtyPicture> _003C_003E9__467_2;

		public static Comparison<WorkshopCategoryPageDesc> _003C_003E9__493_1;

		public static Comparison<WorkshopEditorChoiceDesc> _003C_003E9__493_2;

		public static Comparison<WorkshopTimeLimitedModeRuleTagDesc> _003C_003E9__493_3;

		public static Comparison<WorkshopHotSearchConfigDesc> _003C_003E9__493_4;

		public static Comparison<WorkshopTagMatchDesc> _003C_003E9__493_5;

		public static Comparison<WorkshopHotInfo> _003C_003E9__534_1;

		public static Comparison<WorkshopEditorChoiceInfo> _003C_003E9__536_1;

		public static Comparison<WorkshopAuthorSlotInfo> _003C_003E9__549_1;

		public static Converter<string, string> _003C_003E9__572_0;

		public static Action<HttpErrorCode, object> _003C_003E9__583_0;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__618_0;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__618_1;

		public static Comparison<UGCRemarkRuleData> _003C_003E9__624_0;

		public static Func<KeyValuePair<string, WorkShopVideoInfo>, ulong> _003C_003E9__665_1;

		public static Comparison<WorkshopReportConfig> _003C_003E9__669_0;

		public static Comparison<AssetStoreReportConfig> _003C_003E9__673_0;

		public static Func<SceneEditSlotInfo, bool> _003C_003E9__817_0;

		public static Func<SceneEditSlotInfo, bool> _003C_003E9__818_0;

		public static Comparison<SceneEditSlotInfo> _003C_003E9__913_1;

		public static Comparison<UISceneEditRecommendationItemInfo> _003C_003E9__926_0;

		public static Comparison<SceneEditPublishedSlotInfo> _003C_003E9__953_0;

		public static Comparison<SceneEditSlotInfo> _003C_003E9__970_1;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__973_0;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__975_1;

		internal bool _003CIsMapCoverAuditFailed_003Eb__438_0(proto.WorkshopDirtyPicture dirtyPicture)
		{
			return false;
		}

		internal bool _003CIsMapCoverAuditFailed_003Eb__438_1(proto.WorkshopDirtyPicture dirtyPicture)
		{
			return false;
		}

		internal void _003CRequestTrainingCenterInfo_003Eb__457_0(HttpErrorCode err, object res)
		{
		}

		internal proto.WorkshopDirtyWord _003CUpdateReviewState_003Eb__467_0(tcp.WorkshopDirtyWord input)
		{
			return null;
		}

		internal proto.WorkshopDirtyPicture _003CUpdateReviewState_003Eb__467_1(tcp.WorkshopDirtyPicture input)
		{
			return null;
		}

		internal proto.WorkshopDirtyPicture _003CUpdateReviewState_003Eb__467_2(tcp.WorkshopDirtyPicture input)
		{
			return null;
		}

		internal int _003CRequestWorkshopCustomModeTemplateRule_003Eb__493_1(WorkshopCategoryPageDesc a, WorkshopCategoryPageDesc b)
		{
			return 0;
		}

		internal int _003CRequestWorkshopCustomModeTemplateRule_003Eb__493_2(WorkshopEditorChoiceDesc a, WorkshopEditorChoiceDesc b)
		{
			return 0;
		}

		internal int _003CRequestWorkshopCustomModeTemplateRule_003Eb__493_3(WorkshopTimeLimitedModeRuleTagDesc a, WorkshopTimeLimitedModeRuleTagDesc b)
		{
			return 0;
		}

		internal int _003CRequestWorkshopCustomModeTemplateRule_003Eb__493_4(WorkshopHotSearchConfigDesc a, WorkshopHotSearchConfigDesc b)
		{
			return 0;
		}

		internal int _003CRequestWorkshopCustomModeTemplateRule_003Eb__493_5(WorkshopTagMatchDesc a, WorkshopTagMatchDesc b)
		{
			return 0;
		}

		internal int _003CRequestRecommendationInfo_003Eb__534_1(WorkshopHotInfo a, WorkshopHotInfo b)
		{
			return 0;
		}

		internal int _003CRequestEditorChoiceById_003Eb__536_1(WorkshopEditorChoiceInfo a, WorkshopEditorChoiceInfo b)
		{
			return 0;
		}

		internal int _003CRequestOfficialMapInfo_003Eb__549_1(WorkshopAuthorSlotInfo a, WorkshopAuthorSlotInfo b)
		{
			return 0;
		}

		internal string _003CRequestWaterfallPoolData_003Eb__572_0(string x)
		{
			return null;
		}

		internal void _003CRequestLikeCode_003Eb__583_0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CGetCreateRoomSlotInfos_003Eb__618_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CGetCreateRoomSlotInfos_003Eb__618_1(SceneEditSlotInfo e)
		{
			return false;
		}

		internal int _003Cget_RemarkRuleDataList_003Eb__624_0(UGCRemarkRuleData a, UGCRemarkRuleData b)
		{
			return 0;
		}

		internal ulong _003CRequestGoPosInfo_003Eb__665_1(KeyValuePair<string, WorkShopVideoInfo> x)
		{
			return 0uL;
		}

		internal int _003CInitReportCSV_003Eb__669_0(WorkshopReportConfig a, WorkshopReportConfig b)
		{
			return 0;
		}

		internal int _003CInitAssetStoreReportCSV_003Eb__673_0(AssetStoreReportConfig a, AssetStoreReportConfig b)
		{
			return 0;
		}

		internal bool _003CGetNextUnlockSlotID_003Eb__817_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CGetNextEmptySlotID_003Eb__818_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal int _003CRequestSlotInfo_003Eb__913_1(SceneEditSlotInfo a, SceneEditSlotInfo b)
		{
			return 0;
		}

		internal int _003CGetWorkshopAuthorInfo_003Eb__926_0(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b)
		{
			return 0;
		}

		internal int _003CGetPublishedSlotInfoList_003Eb__953_0(SceneEditPublishedSlotInfo a, SceneEditPublishedSlotInfo b)
		{
			return 0;
		}

		internal int _003CRequestSubscriptionSlotInfo_003Eb__970_1(SceneEditSlotInfo a, SceneEditSlotInfo b)
		{
			return 0;
		}

		internal bool _003CCheckSubscribeCapacity_003Eb__973_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CTryRequestQuickSubscribeOrDel_003Eb__975_1(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass453_0
	{
		public string code;

		internal bool _003COnRecordMatch_003Eb__0(KeyValuePair<string, int> e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass458_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public Action callback;

		internal void _003CRequestResourceStoreAuthorName_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass460_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public object reqObj;

		public object[] extra;

		internal void _003CRequestResourceStore_003Eb__0(HttpErrorCode errorCode, object resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass467_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public SceneEditSlotInfo local_slot;

		public SceneEditPublishedSlotInfo publishedInfo;

		public ReviewFinishedNtf nft;

		internal void _003CUpdateReviewState_003Eb__3(WorkshopBasicInfo data)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass492_0
	{
		public uint tagId;

		internal bool _003CGetTimeLimitedModeRuleTagDesc_003Eb__0(WorkshopTimeLimitedModeRuleTagDesc desc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass494_0
	{
		public KeyValuePair<string, string> item;

		internal bool _003CSetWorkshopMapSurveyData_003Eb__0(KeyValuePair<string, int> e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass496_0
	{
		public string code;

		internal bool _003CGetWorkshopMapPlayNum_003Eb__0(KeyValuePair<string, int> e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass502_0
	{
		public bool isLogin;

		public CSSearchWorkshopCodeReq req;

		internal void _003CRequestCheckShareCodeStatic_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass503_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public string workshopCode;

		public Action<SceneEditSlotInfo> onFinished;

		internal void _003CRequestShareCodeInGame_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass508_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public string workshopCode;

		public Action<WorkshopBasicInfo> onFinished;

		internal void _003CRequestEditorChoiceWorkshopDetail_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass509_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public Action<bool> onFinished;

		internal void _003CRequestWorkshopDetailByCode_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass510_0
	{
		public SceneEditSlotInfo RoomDetailInfo;

		public UIModelSceneEdit _003C_003E4__this;

		public string code;

		internal void _003CRequestRoomDetailInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass514_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public string workshopCode;

		public bool isGMPreview;

		internal void _003CRequestSearch_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass515_0
	{
		public string code;

		public Action<bool, SceneEditSlotInfo> onFinished;

		public UIModelSceneEdit _003C_003E4__this;

		internal void _003CRequestSearchMap_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass516_0
	{
		public bool offlineSerach;

		public UIModelSceneEdit _003C_003E4__this;

		public bool isCode;

		internal void _003CRequestSearchMaps_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass518_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public string code;

		internal void _003CRequestReport_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass527_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public int birthYear;

		internal void _003CReqSetWorkshopBirthYear_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass529_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public uint level;

		internal void _003CCheckLevelCanRewarded_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass536_0
	{
		public List<WorkshopEditorChoiceInfo> resList;

		public UIModelSceneEdit _003C_003E4__this;

		public uint id;

		internal void _003CRequestEditorChoiceById_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass547_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public uint id;

		public int index;

		internal void _003CRequestCategoryInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass549_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public int index;

		internal void _003CRequestOfficialMapInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass564_0
	{
		public uint poolType;

		public uint genreID;

		internal bool _003CGetWaterfallPoolData_003Eb__0(WaterfallPoolData data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass572_0
	{
		public WaterfallPoolData data;

		public UIModelSceneEdit _003C_003E4__this;

		internal void _003CRequestWaterfallPoolData_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass573_0
	{
		public WaterfallPoolData data;

		public UIModelSceneEdit _003C_003E4__this;

		internal void _003CRequestWaterfallLeaderboardData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass574_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public List<WaterfallPoolData> dataList;

		internal void _003CRequestBatchWaterfallLeaderboardData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass575_0
	{
		public WaterfallPoolData data;

		public bool needAddToValidCodeList;

		public UIModelSceneEdit _003C_003E4__this;

		public int lastIndex;

		internal void _003CRequestWaterfallSlotInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass576_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public List<WaterfallPoolData> dataList;

		public int[] newLastIndexes;

		public int dataCount;

		internal void _003CRequestWaterfallSlotInfoByLeaderboard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass581_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public bool isFirst;

		internal void _003CRequestSelfdomInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass609_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public GalleryShow.SocialMediaType targetType;

		public Action<bool> callback;

		internal void _003CRequestSetDisplaySocialMedia_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass665_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public Action<WorkShopVideoInfo> callback;

		internal void _003CRequestGoPosInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass709_0
	{
		public Action onSuccess;

		public Action onFailure;

		internal void _003CDownloadResourceBytes_003Eb__0(bool succeed)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass788_0
	{
		public UIModelGroup groupModel;

		public UIModelSceneEdit _003C_003E4__this;

		public SceneEditSlotInfo slotInfo;

		internal void _003CEnterSceneEditInPreview_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass790_0
	{
		public UIModelGroup groupModel;

		public bool reEnterEdit;

		public UIModelSceneEdit _003C_003E4__this;

		public EEnterSceneEditMode editMode;

		public uint slotID;

		public proto.EWorkshop.SlotType slotType;

		public uint templateID;

		public uint mapID;

		public bool download;

		public uint areaID;

		public SceneEditSlotInfo info;

		internal void _003CEnterSceneEditWithMySlot_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass792_0
	{
		public UIModelGroup groupModel;

		public UIModelSceneEdit _003C_003E4__this;

		public uint id;

		public uint map;

		public uint mode;

		public uint template;

		public uint areaID;

		public string name;

		public bool nameEdited;

		internal void _003CEnterSceneEditWithCreateNew_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass798_0
	{
		public UIModelGroup groupModel;

		public UIModelSceneEdit _003C_003E4__this;

		public uint localSlotId;

		public bool slotIdAllocated;

		public SceneEditSlotInfo slotInfo;

		public uint targetMapId;

		public uint decodedModeId;

		public uint decodedTemplateId;

		public uint areaId;

		internal void _003CEnterSceneEditWithTutorialLevel_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass799_0
	{
		public UIModelGroup groupModel;

		public UIModelSceneEdit _003C_003E4__this;

		public uint slotId;

		public SceneEditSlotInfo info;

		public string name;

		internal void _003CEnterSceneEditWithSecEdit_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass815_0
	{
		public HNDHJGJILHC game;

		public uint srcSlotId;

		public Action<bool, uint> callback;

		public uint destSlotId;

		internal void _003CInGameSaveAsToEmptySlot_003Eb__0(bool exportResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass816_0
	{
		public HNDHJGJILHC game;

		public uint destSlotId;

		public SceneEditSlotInfo destSlotInfo;

		internal void _003CSwitchEditingToNewSlot_003Eb__0(bool exportResult)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass819_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public string workshopCode;

		public string url;

		public Action action;

		internal void _003CRequestGameMapSlotInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass834_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public uint slot_id;

		public proto.EWorkshop.SlotType type;

		internal void _003CRequestUploadWorkShopDirtyWord_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass836_0
	{
		public SceneEditSlotInfo localSave;

		public UIModelSceneEdit _003C_003E4__this;

		public bool update;

		public uint[] finalGenreID;

		internal void _003CRequestUploadWorkshopCDN_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass841_0
	{
		public EWorkshopDownloadType downloadType;

		public proto.EWorkshop.SlotType slotType;

		public uint slotID;

		public uint destId;

		public UIModelSceneEdit _003C_003E4__this;

		public proto.EWorkshop.SlotType destType;

		public Action callback;

		public bool needTips;

		internal void _003CRequestDownloadWorkshopCDN_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass848_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public string previewCode;

		internal void _003CRequestPreview_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass849_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public SceneEditSlotInfo info;

		public uint destId;

		internal void _003CRequestSecEdit_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass857_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public SceneEditSlotInfo slotInfo;

		public bool showDownloadPop;

		public bool needLoading;

		public EUGCScene from;

		internal void _003CRequestResInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass857_1
	{
		public CSGetWorkshopExportSettingRes data;

		public _003C_003Ec__DisplayClass857_0 CS_0024_003C_003E8__locals1;

		internal void _003CRequestResInfo_003Eb__1(byte[] gameDataBytes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass857_2
	{
		public Action<byte[]> downloadGameDataCallback;

		public _003C_003Ec__DisplayClass857_1 CS_0024_003C_003E8__locals2;

		internal void _003CRequestResInfo_003Eb__2(ResultTextureInfo texture)
		{
		}

		internal void _003CRequestResInfo_003Eb__3(CDNDownloadFailedInfo info)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass858_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public SceneEditSlotInfo slotInfo;

		internal void _003CRequestResInfoWithExportUrl_003Eb__0(byte[] gameDataBytes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass860_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public SceneEditSlotInfo slotInfo;

		public bool showDownloadPop;

		internal void _003CRequestGameData_003Eb__0(byte[] gameDataBytes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass862_0
	{
		public List<UGCResourceForGameData.PackageOrABFileInfo> fileInfos;

		public UIModelSceneEdit _003C_003E4__this;

		internal void _003CDownloadResourceBytesInternal_003Eb__0(bool succeed)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass878_0
	{
		public EventLogger.UGCSurveySceneType surveySceneType;

		public UIPopupMessageBoxController msgBox;

		public string reportLog;

		internal void _003CShowCreatorFeedbackFailureBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass879_0
	{
		public Action<bool, string, string> callback;

		public UIModelSceneEdit _003C_003E4__this;

		public byte[] bytes;

		internal void _003CUploadCreatorFeedbackBytes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass879_1
	{
		public string downloadUrl;

		public _003C_003Ec__DisplayClass879_0 CS_0024_003C_003E8__locals1;

		internal void _003CUploadCreatorFeedbackBytes_003Eb__1(bool ok, string err)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass880_0
	{
		public Action<bool, bool, string> callback;

		internal void _003CFilterCreatorFeedbackDirtyWord_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass881_0
	{
		public Action<bool, string> callback;

		internal void _003CSubmitCreatorFeedback_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass913_0
	{
		public WorkshopSubscribeSlotInfo slot;

		internal bool _003CRequestSlotInfo_003Eb__2(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass913_1
	{
		public SceneEditSlotInfo slotInfo;

		internal bool _003CRequestSlotInfo_003Eb__3(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass917_0
	{
		public proto.EWorkshop.SlotType type;

		public uint id;

		public UIModelSceneEdit _003C_003E4__this;

		public EWorkshopDelType delType;

		internal void _003CRequestDel_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass917_1
	{
		public uint slot_id;

		internal bool _003CRequestDel_003Eb__1(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CRequestDel_003Eb__2(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass919_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public CSSetWorkshopAuthorTagReq req;

		internal void _003CRequestSetWorkshopAuthorTag_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass927_0
	{
		public bool myself;

		public UIModelSceneEdit _003C_003E4__this;

		public ulong author_id;

		public bool cache;

		internal void _003CRequestWorkshopAuthorInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass930_0
	{
		public uint id;

		internal bool _003CCanBeUpdated_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass933_0
	{
		public uint slotID;

		internal bool _003CGetSceneEditSlotInfoBySlotTypeAndID_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CGetSceneEditSlotInfoBySlotTypeAndID_003Eb__1(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass934_0
	{
		public uint slotID;

		internal bool _003CGetAuthorSceneEditSlotInfo_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass935_0
	{
		public uint slotIdLocal;

		internal bool _003CGetAuthorSceneEditSlotInfoByServerId_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass968_0
	{
		public string code;

		internal bool _003CHasThisCodeSubscribed_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass969_0
	{
		public string code;

		internal bool _003CIsThisCodeCanBeSubscribed_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass970_0
	{
		public WorkshopSubscribeSlotInfo slot;

		internal bool _003CRequestSubscriptionSlotInfo_003Eb__2(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass972_0
	{
		public uint slot_id;

		internal bool _003CRequestBatchDelSubscription_003Eb__1(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CRequestBatchDelSubscription_003Eb__2(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass975_0
	{
		public string code;

		internal bool _003CTryRequestQuickSubscribeOrDel_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass978_0
	{
		public UIModelSceneEdit _003C_003E4__this;

		public uint id;

		public Predicate<SceneEditSlotInfo> _003C_003E9__1;

		internal void _003CRequestSubscribe_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CRequestSubscribe_003Eb__1(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003CUploadOneCreatorFeedbackFile_003Ed__882 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<bool, string> done;

		public byte[] data;

		private bool _003CisSucc_003E5__2;

		private string _003ClastError_003E5__3;

		private float _003CretryDuration_003E5__4;

		private int _003CretryCount_003E5__5;

		private UnityWebRequest _003Cwww_003E5__6;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUploadOneCreatorFeedbackFile_003Ed__882(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const int SCENE_EDIT_SUBSCRIPTION_SLOT_CNT = 50;

	private const int SCENE_EDIT_SHARECODE_LEN = 45;

	private const int SCENE_EDIT_SHARECODESHORT_LEN = 7;

	private const int FIRST_REQ_SELFDOMINFO_CD = 400;

	private const string KEY_REFUSE_SUBSCRIBE_TIME = "refuse_subscribe_time";

	public ulong m_FunnelLogID;

	public List<string> FunnelClickBtnNamesLog;

	public List<double> FunnelClickTimesLog;

	public ulong m_Funnel2LogID;

	public List<string> Funnel2ClickBtnNamesLog;

	public List<double> Funnel2ClickTimesLog;

	private UIWaitingForRequestCircleController m_LoadingUI;

	public List<int> m_UGCMapDatas;

	public Dictionary<int, ContentPublishChecklistDesc> MapScoreChecklistDesc;

	public List<PublishChecklistStatusDesc> MapScoreStatus;

	public static readonly string UGCGameModeMapPrefer;

	public static readonly string UGCModePre;

	public static readonly string UGCMapPre;

	public bool TrainingCenterBackToAfterMatch;

	public int TrainingCenterLastPlayedCourseId;

	private readonly TrainingCenterPendingEnterInfo m_TrainingCenterPendingEnter;

	public const int DataChangeParam_TrainingCenterDesc = 1;

	private List<NewbieTrainingCenterDesc> m_TrainingCenterDescs;

	private bool _003CEverHasSomethingToSave_003Ek__BackingField;

	private bool _003CSceneEditGameInitCompleted_003Ek__BackingField;

	public const uint PropID_UploadFinish = 1u;

	public const uint PropID_DownloadFinish = 2u;

	public const uint PropID_RefreshSlotInfo = 4u;

	public const uint PropID_RefreshLatestReleaseMapList = 8u;

	public const uint PropID_SearchFinished = 16u;

	public const uint PropID_SubscribeFinieshed = 32u;

	public const uint PropID_UnlockFinished = 64u;

	public const uint PropID_RefreshRecommendationInfo = 128u;

	public const uint PropID_RefreshLatestInfo = 256u;

	public const uint PropID_RefreshHistoryInfo = 512u;

	public const uint PropID_GetCreateRoomRuleFinish = 1024u;

	public const uint PropID_RefreshDescInfo = 2048u;

	public const uint PropID_RefreshSlotNameInfo = 4096u;

	public const uint PropID_RefreshSelfdomInfo = 8192u;

	public const uint PropID_DelFinished = 16384u;

	public const uint PropID_DirtyWordFailed = 32768u;

	public const uint PropID_SaveAsFinished = 65536u;

	public const uint PropID_UpdateWorkShopRoomCard = 131072u;

	public const uint PropID_CommentFinished = 262144u;

	public const uint PropID_EditorChoiceInfoRefresh = 524288u;

	public const uint PropID_RefreshRoomDetailInfo = 1048576u;

	public const uint PropID_RefreshCategoryInfo = 2097152u;

	public const uint PropID_RefreshRecommendSeriesInfo = 4194304u;

	public const uint PropID_GetWorkshopCustomModeTemplateRuleFinish = 8388608u;

	public const uint PropID_SaveAsFinishedForSecEdit = 16777216u;

	public const uint PropID_RefreshCDN = 33554432u;

	public const uint PropID_RefreshMapResInfo = 67108864u;

	public const uint PropID_ReviewFinish = 134217728u;

	public const uint PropID_SearchMapsFinished = 268435456u;

	public const uint PropID_WorkshopAuthor = 536870912u;

	public const uint PropID_RefreshOfficialMapInfo = 1073741824u;

	public const uint PropID_RefreshWaterfallInfo = 2147483648u;

	private CSVAsyncDataMap<int, CNDCGBPDHEB.AAJDBLADNEM> m_EditorErrorConfig;

	private Dictionary<uint, WorkshopShowMapIconData> m_WorkShopMapIconMap;

	private Action m_OnReturnToLobbyCallback;

	private bool m_PendingTutorialCongratulationsOnReturnToLobby;

	private UGCTutorialLevelConfig m_CachedTutorialLoadingLevelConfig;

	private ulong m_LastUploadTime;

	private ulong m_LastApplyTime;

	private ulong m_LastUploadDescTime;

	private ulong m_LastUploadSlotNameTime;

	private ulong m_LastSetAuthorTagTime;

	private ulong m_LastSetMapPreviewTime;

	private readonly Dictionary<uint, ulong> m_LastUploadAllowRecreateTimeDic;

	private ulong m_LastShareTime;

	private ulong m_LastSearchTime;

	private bool m_HasEnterSceneEdit;

	private bool m_HasEnterUGCCenter;

	private bool m_NeedPushTaskInUGCCenter;

	private bool m_UseServerData;

	private ulong m_PlayerEnterSceneEditTime;

	private uint m_PlayerHideItemListCnt;

	private ulong m_PlayerHideItemListStart;

	private uint m_PlayerHideItemListTime;

	private uint m_PlayerChangeEditTypeCnt;

	private ulong m_PlayerFreeEditTotalTime;

	private ulong m_PlayerFreeEditStartTime;

	private uint mAdjustFloorUpTimes;

	private uint mAdjustFloorDownTimes;

	private float mAdjustFloorMaxHeight;

	private uint m_PlayerTopViewTime;

	private ulong m_PlayerTopViewStartTime;

	private uint m_PlayerTopViewCnt;

	private uint m_ClickConsoleCnt;

	private uint m_ClickConsoleLinkCnt;

	public int BlockEditViewTime;

	public int HudEditViewTime;

	public bool Is_New_Create;

	public bool Is_Change_Items;

	public bool Is_Click_Setting;

	public bool Is_Click_Mode_Setting;

	public bool Is_Enter_BlockEdit;

	public bool Is_Enter_HudEit;

	public bool Is_Enter_GMVerify;

	public int Edit_mode_when_enter;

	public int Edit_mode_when_exit;

	public int Edit_mode_switch_cnt;

	public int Move_edit_cnt;

	public int Zoom_edit_cnt;

	public int Rotate_edit_cnt;

	public int Copy_btn_cnt;

	public int Multi_choose_btn_cnt;

	public int Combine_btn_cnt;

	public int Uncombine_btn_cnt;

	public float Crosshair_edit_time;

	public float Pointdrag_edit_time;

	public float Text_display_edit_time;

	public float Grid_mode_edit_time;

	public int Shelf_item_detail_btn_cnt;

	public int Select_mode_btn_cnt;

	public int Axis_mode_btn_cnt;

	public int Text_display_btn_cnt;

	public int Grid_mode_btn_cnt;

	public int Mesh_granularity_btn_cnt;

	public int Team_invite_btn_cnt;

	public int Free_layout_btn_cnt;

	public int Clear_objects_btn_cnt;

	public int Team_num_btn_cnt;

	public int Team_member_btn_cnt;

	public int Round_num_btn_cnt;

	public int Preparation_time_btn_cnt;

	public int Match_time_btn_cnt;

	public int Max_hp_btn_cnt;

	public int Move_speed_btn_cnt;

	public int Unlimited_icewalls_btn_cnt;

	public int Unlimited_ammo_btn_cnt;

	public int Unlimited_throwables_btn_cnt;

	public int Passive_skills_btn_cnt;

	public int Active_skills_btn_cnt;

	public int Pet_skills_btn_cnt;

	public int More_setting_btn_cnt;

	public uint Resource_manager_usage_time;

	public uint PreAutoSaveSetting;

	public uint CurAutoSaveSetting;

	public uint AutoSaveSuccessCnt;

	public uint AutoSaveFailCnt;

	public long m_SlotExpiredSeconds;

	public bool CurrentSlotIsAboutToExpireOrExpired;

	private uint m_SaveCount;

	private readonly Dictionary<uint, uint> m_SaveErrorInfos;

	private WorkshopEditLevelDesc m_CachedAdvancedData;

	private ulong m_LastResourceShopUpdateTime;

	private ulong m_LastWorkShopUpdateTime;

	private ulong m_LastKolUpdateTime;

	private const int m_CDSecond = 60;

	private ulong m_FirstReqSelfdomInfoTime;

	private ulong m_RefreshSelfdomInfoTime;

	private ulong m_LastConsoleCheckBtnTime;

	private CSGetWorkshopPersonalRecommendationInfoRes m_SelfdomInfoRes;

	private CreateWorkshopRoomInfo m_CreateWorkshopRoomInfo;

	private HashSet<string> m_ReportedCode;

	private HashSet<ulong> m_ReportResourceId;

	private List<WorkshopHotInfo> m_HotWorkshopInfoList;

	private List<WorkshopBasicInfo> m_LatestReleaseMapList;

	private List<WorkshopEditorChoiceDesc> m_EditorChoiceRecDescList;

	private Dictionary<uint, List<WorkshopEditorChoiceInfo>> m_EditorChoiceRecInfoDic;

	private List<SceneEditSlotInfo> m_RecommendWorkshopInfoList;

	private HashSet<string> m_HotWorkShopMapSet;

	private Dictionary<string, string> m_ShareCodeToCDNUrlDic;

	private Dictionary<string, ulong> m_ShareCodeToCommentDic;

	public Dictionary<string, SceneEditSlotInfo> m_RoomDetailInfoDic;

	private ulong m_LastQuickJoin;

	private UGCRSP_PersonalInfoResInner m_ResourceShopPersonalInfo;

	private List<WorkshopMapSurveyUrlDesc> m_WorkshopMapSurveyUrlList;

	private Dictionary<string, string> m_WorkshopMapSurveyUrlDic;

	private List<KeyValuePair<string, int>> m_WorkshopMapPlayNumDic;

	private List<WorkshopHotSearchConfigDesc> m_HotSearchConfigDescs;

	private uint m_WorkshopHotSearchLimit;

	private string m_WorkshopSearchHistoryKey;

	private int m_WorkshopSearchHistoryLimit;

	private string[] m_WorkshopSearchHistorySeparator;

	private EWorkShopCreateRoomSrc m_CreateRoomSrc;

	private WorkshopMatchResultData m_WorkshopMatchResultData;

	private bool m_IsMidwayQuit;

	private string m_PreviewCode;

	private SceneEditSlotInfo m_PreviewSlotInfo;

	private string m_OriginCode;

	private EOpenWorkshopDetailFrom m_WorkshopDetailWndFrom;

	private int m_WorkshopDetailWndTab;

	private EEnterEditFrom m_enterEditFrom;

	private EUGCScene m_enterEditScene;

	private static bool s_IsClipboardCodeValid;

	private WorkshopSceneData m_CurrentCameraData;

	private static SceneEditSlotInfo s_WorkshopCodeInfoForClipboard;

	private static HashSet<string> s_ClipboardCodeSet;

	private static Dictionary<Type, int> m_NavigationPageTypeDict;

	private SceneEditSlotInfo m_WorkshopCodeInfoRequested;

	private OLHOBAPCNMI _003CTypeMapping_003Ek__BackingField;

	public bool AutoEnterEditModeNext;

	public Vector3 AutoMovePlayerToPos;

	public Vector3 AutoMoveCamToPos;

	public Quaternion AutoMovePlayerToRot;

	public Quaternion AutoMoveCamToRot;

	public BJJBCNEJPEF AutoMoveCameraMode;

	public bool SetWorkshopBirthYearSwitch;

	private Dictionary<KeyValuePair<uint, int>, List<proto.WorkshopDirtyPicture>> m_DictDirtyPictures;

	private Dictionary<KeyValuePair<uint, int>, List<proto.WorkshopDirtyWord>> m_DictDirtyWords;

	private Dictionary<KeyValuePair<uint, int>, List<proto.WorkshopDirtyPicture>> m_DictDirtyScreenShots;

	private Dictionary<KeyValuePair<uint, int>, List<WorkshopWebAuditInfo>> m_DictDirtyWebAudit;

	private Dictionary<KeyValuePair<uint, int>, bool> m_DictNeedShowDitryWordsTips;

	private Dictionary<KeyValuePair<uint, int>, proto.EWorkshop.ReviewResult> m_ReviewResult;

	private Dictionary<uint, WorkshopModerationViolationTypeData> m_ReviewResultConfigDic;

	private int DIRTY_WORD_LIMIT_LENGTH;

	private int CONSOLE_DIRTY_WORD_LIMIT_LENGTH;

	private bool m_HasPredownloadRequested;

	private List<WorkshopCustomModeTemplateRuleDesc> m_UGCCustomModeTemplateRuleDataList;

	private proto.EWorkshop.QuickJoinSwitchType m_WorkshopQuickJoinSwitch;

	public WorkshopTagMatchDefaultOptionDesc TagMatchDefaultOption;

	private List<WorkshopTagMatchDesc> m_TagMatch;

	public List<WorkshopEditLevelDesc> WorkshopEditLevelDescList;

	private List<WorkshopRecommendSeriesDesc> m_RecommendSeriesDesc;

	private List<WorkshopCategoryPageDesc> m_CategoryPageDesc;

	private WorkshopForbiddenResAndAPI m_ForbiddenResAndAPI;

	private List<WorkshopTemplateConfigDesc> m_WorkshopTemplateConfigList;

	private List<WorkshopUGCOpeningInfoDesc> m_UGCOpeningInfoDesc;

	private List<SceneEditSlotInfo> m_TagMatchResourceDownloadInfos;

	private List<WorkshopTimeLimitedModeRuleTagDesc> m_WorkshopTimeLimitRuleTagDescs;

	private Dictionary<string, WorkshopBasicInfo> m_EditorChoiceCacheDict;

	private int m_MyMaxCost;

	private HashSet<string> m_ShareCodeWithoutCDNSet;

	private Dictionary<string, bool> m_ShareCodeToIsShowCrown;

	private List<SceneEditSlotInfo> m_LatestInfoList;

	private List<WorkshopLatestInfo> m_WorkshopLatestInfos;

	public bool NeedRefreshLatest;

	private Dictionary<uint, List<WorkshopRecommendSeriesInfo>> m_RecommendSeriesInfos;

	private Dictionary<uint, List<WorkshopHotInfo>> m_CategoryInfos;

	private List<WorkshopAuthorSlotInfo> m_OfficialMapInfos;

	private uint m_ClearWaterfallDataDC;

	private List<WorkshopMapPoolSortOptionDesc> m_WaterfallFliterData;

	private List<WorkshopLeaderboardConfigDesc> m_WaterfallLeaderboardConfig;

	private List<WorkshopCreatorPrivilegeDesc> m_WorkshopCreatorPrivilegeInfos;

	private List<WorkshopCreatorRewardDesc> m_WorkshopCreatorRewardInfos;

	private List<WaterfallPoolData> m_WaterfallPoolDataList;

	private Dictionary<uint, List<WorkshopCodeWithRankInfo>> m_WaterfallLeaderboardCache;

	private UGCLRUDataCachePool<string, SceneEditSlotInfo> m_WaterfallSlotInfoCache;

	private List<WorkshopHistoryInfo> m_HistoryInfoList;

	public bool NeedRefreshHistory;

	private GallerySocialMediaInfo m_SelfSocialMediaInfo;

	private GalleryShow.SocialMediaType m_SelfShowMedia;

	private ulong m_LastSetDisplaySocialMediaTime;

	public List<SceneEditSlotInfo> DeterminedSlotInfo;

	private Queue<SceneEditSlotInfo> m_RecentQuickJoinSlotInfo;

	private List<UGCRemarkRuleData> m_RemarkRuleDataList;

	private CreatorFeedBackData m_LastSaveCFData;

	private byte[] _003CCustomCover_003Ek__BackingField;

	private byte[] _003CTemplateCover_003Ek__BackingField;

	private const string LastSaveCFTimeStampKey = "LastSaveCFTimeStampKey";

	private const string LastCFDataKey = "LastCFDataKey";

	private const string HasOpenedUserAgreement = "HasOpenedUserAgreement";

	private int m_RecordHasOpendUserAgreement;

	private Dictionary<uint, Dictionary<string, List<string>>> crossRegionConfig;

	private const int WorkShopVideoMapMaxCache = 20;

	private Dictionary<string, WorkShopVideoInfo> m_WorkShopVideoMap;

	private List<WorkshopReportConfig> m_WorkshopReportConfigs;

	private List<AssetStoreReportConfig> m_AssetStoreReportConfigs;

	private Dictionary<uint, UGCMapLabelConfig> m_WorkshopMapLabelsDesc;

	private Dictionary<uint, UGCCreatorLabelConfig> m_WorkshopAuthorLabelsDesc;

	private RecordDownloadGameDataInfo m_AlgorithmDownloadGameDataRecord;

	private RecordResCheckInfo m_AlgorithmResCheckRecord;

	private Dictionary<uint, UGCAI_SetParameter_Mapping> m_UGCAISetParameterMapping;

	private string m_ItemGenSearchHistoryKey;

	private const int ItemGenSearchHistoryLimit = 4;

	private Dictionary<uint, UGCAI_3DGen_RecoList> m_ItemGenGuessConfigDic;

	private Dictionary<uint, WorkshopGenreID> m_WorkshopGenreIDConfigDic;

	private Dictionary<uint, WorkshopTagType> m_WorkshopTagTypeConfigDic;

	private Dictionary<uint, List<WorkshopModeTagData>> m_WorkshopModeTagDataByTagTypeDic;

	private Dictionary<uint, WorkShopPlayerStartTag> m_WorkShopPlayerStartTagConfigDic;

	private object[] m_RestoreParameters;

	private uint m_RestoreParametersDelayCall;

	private bool m_HasUGCUserCenterRestore;

	private uint m_UGCUserCenterRestoreTabType;

	private uint m_UGCUserCenterRestoreDelayCall;

	private const string KEY_PLAY_PREFERENCE = "UGC_WORKSHOP_PLAY_PREFERENCE";

	private const string KEY_PLAY_PREFERENCE_LAST_VISIT = "UGC_WORKSHOP_PLAY_PREFERENCE_LAST_VISIT";

	private const ulong PLAY_PREFERENCE_INTERVAL_SECONDS = 2592000uL;

	private List<SceneEditSlotInfo> m_AuthorSlotList;

	public uint InGameEditSlotId;

	public bool InGameEditSlotIdAllocated;

	public uint InGameEditServerSlotId;

	public proto.EWorkshop.SlotType InGameEditSlotType;

	public bool InGameEditNeedDownload;

	public uint InGameEditMapId;

	public uint InGameEditModeId;

	public uint InGameEditModeTemplate;

	public uint InGameEditAreaID;

	public string InGameEditName;

	public bool InGameEditNameEdited;

	public string InGameSecEditShareCode;

	public string AutoOpenGraphID;

	private SceneEditSlotInfo m_LatestSearchSlotInfo;

	private List<SceneEditSlotInfo> m_LatestSearchSlotInfos;

	private bool m_LatestSearchWithCodeSucceeded;

	private UINavigationUtil.UINavigationFrom m_LatestSource;

	private uint m_LatestSelectedSlotID;

	private SceneEditSlotInfo m_GameMapSlotInfo;

	private SceneEditSlotInfo m_SelectedSlotInfo;

	public EEnterSceneEditMode CurrentEnterSceneEditMode;

	private bool m_DelayClearOnReturnToLobby;

	public EUGCTutorialEntrySource CurrentTutorialEntrySource;

	public proto.EWorkshop.SlotType CurrentEnterSceneSlotType;

	public SceneEditSlotInfo m_LoadingSceneSlotInfo;

	public string OfflineSlotInfoShareCode;

	public long OfflineSlotInfoUpdateTime;

	private SceneEditSlotInfo InGameSecEditSlotInfo;

	private bool m_LastMySlotDownloadFailed;

	private int m_TutorialLoadingTipsIndex;

	public HashSet<string> LoadingReasons;

	public UIModelSceneEdit_CDNUpload m_curUploadingCDN;

	public UIModelSceneEdit_CDNDownLoad CurDownloadingCDN;

	public readonly HashSet<string> DownloadingFileUrls;

	private Dictionary<string, int> m_ResInfoShareCodeMapLimit;

	private HashSet<string> m_DownloadingMapSet;

	private HashSet<string> m_ErrorMapSet;

	private bool m_HasRequestInited;

	private Dictionary<uint, SceneEditPublishedSlotInfo> m_AuthorPublishedSlotMap;

	private WorkshopAccountInfo m_WorkShopAccountInfo;

	private uint[] m_LabelIds;

	private string m_WorkshopKolContent;

	private bool m_CheckLevelReward;

	private bool m_IsBanned;

	private bool m_IsManager;

	private uint m_AuthorTag;

	private uint m_AddSlotCnt;

	private uint m_EditLevel;

	private bool m_MapAllowRecreationPri;

	private bool m_MapAllowStrictMode;

	private bool m_MapAllowCoverEidt;

	private bool m_UserReview;

	private uint m_CreatorSlotsIdFrom;

	private uint m_CreatorAddSlots;

	private WorkshopAuthorInfo m_OtherWorkshopAuthorInfo;

	private Dictionary<ulong, WorkshopAuthorInfo> m_OtherWorkshopAuthorInfoCache;

	private const ulong OtherWorkshopAuthorInfoCacheMaxSeconds = 86400uL;

	private const int OtherWorkshopAuthorInfoCacheMaxNum = 100;

	private int m_CachedFirstEmptyAuthorSlotIndex;

	private List<SceneEditSlotInfo> m_SubscriptionSlotList;

	private bool m_HasReqSubscribeRecommend;

	private ulong m_LastRefuseSubscribeTimeS;

	private Queue<ulong> m_TimestampQueue;

	private Dictionary<string, int> m_LocalSubscribeMap;

	public bool EverHasSomethingToSave
	{
		get
		{
			return _003CEverHasSomethingToSave_003Ek__BackingField;
		}
		private set
		{
			_003CEverHasSomethingToSave_003Ek__BackingField = value;
		}
	}

	public bool SceneEditGameInitCompleted
	{
		get
		{
			return _003CSceneEditGameInitCompleted_003Ek__BackingField;
		}
		set
		{
			_003CSceneEditGameInitCompleted_003Ek__BackingField = value;
		}
	}

	public ulong FunnelLogID
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public ulong Funnel2LogID
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	private HNDHJGJILHC Game => null;

	private SceneEditResourceShopManager ShopManager => null;

	public CSVAsyncDataMap<int, CNDCGBPDHEB.AAJDBLADNEM> EditorErrorConfig => null;

	public Action OnReturnToLobbyCallback
	{
		set
		{
		}
	}

	public bool HasPendingTutorialCongratulationsOnReturnToLobby => false;

	public ulong LastUploadTime => 0uL;

	public ulong LastApplyTime => 0uL;

	public ulong LastUploadDescTime => 0uL;

	public ulong LastUploadSlotNameTime => 0uL;

	public ulong LastShareTime => 0uL;

	public ulong LastSearchTime => 0uL;

	public bool HasEnterSceneEdit => false;

	public bool HasEnterUGCCenter
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NeedPushTaskInUGCCenter => false;

	public uint EditorLevel => 0u;

	public long SlotExpiredSeconds => 0L;

	public ulong LastConsoleCheckBtnTime
	{
		set
		{
		}
	}

	private CreateWorkshopRoomInfo CreateWorkshopRoomInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public WorkshopMatchResultData WorkshopMatchResultData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsMidwayQuit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string PreviewCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SceneEditSlotInfo PreviewSlotInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string OriginCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EOpenWorkshopDetailFrom WorkshopDetailWndFrom
	{
		get
		{
			return EOpenWorkshopDetailFrom.None;
		}
		set
		{
		}
	}

	public int WorkshopDetailWndTab
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsClipboardCodeValid => false;

	public WorkshopSceneData CurrentCameraData => null;

	public SceneEditSlotInfo WorkshopCodeInfoForClipboard => null;

	public SceneEditSlotInfo WorkshopCodeInfoRequested => null;

	public OLHOBAPCNMI TypeMapping
	{
		get
		{
			return _003CTypeMapping_003Ek__BackingField;
		}
		private set
		{
			_003CTypeMapping_003Ek__BackingField = value;
		}
	}

	public bool IsSubscribeRecommand => false;

	public bool IsMapAutoTranslateOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsMapCoverCustomizeSwitchOpen => false;

	public bool IsMapCoverScreenShotSwitchOpen => false;

	public List<WorkshopTagMatchDesc> TagMatch
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<string, WorkshopBasicInfo> EditorChoiceCacheDict => null;

	public int MyMaxCost => 0;

	public GallerySocialMediaInfo SelfSocialMediaInfo => null;

	public GalleryShow.SocialMediaType SelfShowMedia => GalleryShow.SocialMediaType.SocialMediaType_NONE;

	public List<UGCRemarkRuleData> RemarkRuleDataList => null;

	public CreatorFeedBackData LastSaveCFData => null;

	public proto.EWorkshop.QuickJoinSwitchType WorkshopQuickJoinSwitch
	{
		get
		{
			return proto.EWorkshop.QuickJoinSwitchType.QuickJoinSwitchType_NONE;
		}
		set
		{
		}
	}

	public Queue<SceneEditSlotInfo> RecentQuickJoinSlotInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public byte[] CustomCover
	{
		get
		{
			return _003CCustomCover_003Ek__BackingField;
		}
		internal set
		{
			_003CCustomCover_003Ek__BackingField = value;
		}
	}

	public byte[] TemplateCover
	{
		get
		{
			return _003CTemplateCover_003Ek__BackingField;
		}
		internal set
		{
			_003CTemplateCover_003Ek__BackingField = value;
		}
	}

	public Dictionary<uint, Dictionary<string, List<string>>> CrossRegionConfig => null;

	public List<WorkshopReportConfig> WorkshopReportConfigs => null;

	public List<AssetStoreReportConfig> AssetStoreReportConfigs => null;

	public Dictionary<uint, UGCMapLabelConfig> WorkshopMapLabelsDesc => null;

	public Dictionary<uint, UGCCreatorLabelConfig> WorkshopAuthorLabelsDesc => null;

	public Dictionary<uint, UGCAI_SetParameter_Mapping> UGCAISetParameterMapping => null;

	public SceneEditSlotInfo GameMapSlotInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SceneEditSlotInfo SelectedSlotInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool DelayClearOnReturnToLobby
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int TutorialLoadingTipIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsLoadingCDN => false;

	public uint AddSlotCnt => 0u;

	public uint EditLevel => 0u;

	public bool MapAllowRecreationPri => false;

	public bool MapAllowStrictMode => false;

	public bool MapAllowCoverEidt => false;

	public bool UserReview => false;

	public WorkshopAuthorInfo OtherWorkshopAuthorInfo => null;

	public ulong LastRefuseSubscribeTimeS
	{
		get
		{
			return 0uL;
		}
		private set
		{
		}
	}

	public void MarkEverHasSomethingToSave()
	{
	}

	public void ResetEverHasSomethingToSave()
	{
	}

	public void MarkTrainingCenterPendingEnter(int id, int sortId, int tag, int tabs, int preProcess, string shareCode, uint mapId)
	{
	}

	public void ClearTrainingCenterPendingEnter()
	{
	}

	public void TryLogTrainingCenterEnterOnMatchSuccess(uint matchMode, uint gameMode, uint mapId, string shareCode)
	{
	}

	public void AddSaveCount()
	{
	}

	public void AddErrorSummary(Dictionary<uint, uint> summary)
	{
	}

	private void ClearLogEventData()
	{
	}

	public int GetUGCData(UGCAdvancedDataType type)
	{
		return 0;
	}

	private uint GetUGCAdvancedData(UGCAdvancedDataType type)
	{
		return 0u;
	}

	public void OnPlayerEnterFreeEdit(bool enter)
	{
	}

	public void LogEventPlayerChangeEditType()
	{
	}

	public void LogEventClickConsole()
	{
	}

	public void LogEventClickConsoleLink()
	{
	}

	public void OnPlayerHideItemList()
	{
	}

	public void OnPlayerShowItemList()
	{
	}

	public void SetEnterEditReason(EEnterEditFrom enterEditFrom, EOpenWorkshopDetailFrom detailFrom, int wndTab, SceneEditSlotInfo previewSlotInfo = null, EUGCScene enterEditScene = EUGCScene.EUGCScene_None)
	{
	}

	public static bool GetSubscribeRecommendEnabled()
	{
		return false;
	}

	private void OnEnterResetVar()
	{
	}

	public void OnAdjustFloorClicked(bool moveUp, float newHeight)
	{
	}

	private void LogEventBegin()
	{
	}

	public void ExitSceneEdit()
	{
	}

	public void CacheTutorialLoadingLevelConfig(UGCTutorialLevelConfig levelConfig)
	{
	}

	public UGCTutorialLevelConfig GetPendingTutorialCongratulationsLoadingConfig()
	{
		return null;
	}

	public void PrepareTutorialCongratulationsOnReturnToLobby()
	{
	}

	private void OnHandleTutorialCongratulationsReturnToLobby()
	{
	}

	public void TryOpenNeedUIWhenExitEdit()
	{
	}

	public void OnChangePerspective(bool enterOrthographic)
	{
	}

	public bool CheckUploadDuringCD()
	{
		return false;
	}

	public bool CheckUploadDescDuringCD()
	{
		return false;
	}

	public bool CheckUploadAllowRecreationDuringCD(SceneEditSlotInfo info)
	{
		return false;
	}

	private uint GenerateKeyBySlotIDAndSlotType(SceneEditSlotInfo info)
	{
		return 0u;
	}

	public ulong GetUploadAllowRecreationDuringCD(SceneEditSlotInfo info)
	{
		return 0uL;
	}

	public bool CheckUploadSlotNameDuringCD()
	{
		return false;
	}

	public bool CheckApplyDuringCD()
	{
		return false;
	}

	public bool CheckShareDuringCD()
	{
		return false;
	}

	public bool CheckSearchDuringCD()
	{
		return false;
	}

	public bool IsUGCRoomMatchSoloOrLeader()
	{
		return false;
	}

	public void HandleReturnToLobby()
	{
	}

	public void FillInSceneEditExtraData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, SceneEditPrefabConfigData csvConfig, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToOilDrum(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToSpawnBox(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToSingleTeleportEndPointDoorData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToSingleTeleportDoorData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToTeleportDoorData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToBuffGenData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToItemBoxData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToMiniSentryData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToVendingMachineData(FSceneEditObjectData objectData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToWardrobeData(FSceneEditObjectData objectData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToPointLightData(FSceneEditObjectData objectData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToFootballData(FSceneEditObjectData objectData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToSphereTriggerData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToCapsuleTriggerData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToBasicSphereData(FSceneEditObjectData objectData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToFootballGoalData(FSceneEditObjectData objectData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToCoinGeneratorData(FSceneEditObjectData objectData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToUGCPathData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToUGCBotGeneratorData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToMusicElementData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToMoveObjData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToScaleItemData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToTriggerData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToUGCAIData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	private void FillInSceneEditExtraDataToEntityGeneratorData(FSceneEditObjectData objData, AJLAEHOEGKN attrProto, EBKCBIBOCEB attrWrapMap = null)
	{
	}

	public void ExportSceneEditObject(SceneEditObjectBase obj, OMGAPOAPGBO subLevel, EditorMiscData miscData)
	{
	}

	private void BuildGoalProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildSpawnBoxProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildSingleOilDrumAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildSingleTeleportEndPointAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildSingleTeleportAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildTeleportAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildMusicElementAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildBuffGenAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildItemBoxAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildMoveObjectAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildScaleItemAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildCapsuleTriggerAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildSphereTriggerAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildTriggerAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildMiniSentryAttributeProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildVendingMachineProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attributeProtoData)
	{
	}

	private void BuildWardrobeProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attributeProtoData)
	{
	}

	private void BuildFootballProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attributeProtoData)
	{
	}

	private void BuildPointLightProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attributeProtoData)
	{
	}

	private void BuildBasicSphereProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attributeProtoData)
	{
	}

	private void BuildCoinGeneratorProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attributeProtodata)
	{
	}

	private void BuildCustomPathProtoBuff(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	public string GetType(IPIFNFDIIKK data)
	{
		return null;
	}

	private void BuildMapIconProtoDataFromObject(SceneEditItemIconInfo info, SceneEditObjectBase obj)
	{
	}

	private void BuildBigToyBallProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildBotGeneratorProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildInstacneGeneratorProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildUGCAIProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	private void BuildResetableProtoDataFromObject(SceneEditObjectBase obj, AJLAEHOEGKN attriProto)
	{
	}

	public EditorMiscData BuildMiscDataFromSceneEditObjects()
	{
		return null;
	}

	public SceneEditItemIconInfo GetIconItemDataFromBytes(byte[] settings)
	{
		return null;
	}

	public string DitryWord2String(proto.WorkshopDirtyWord word, string dirtyWord, bool bLink = true)
	{
		return null;
	}

	public bool IsDirtySlot(uint slotID, proto.EWorkshop.SlotType type)
	{
		return false;
	}

	public string GetReviewSummary(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private bool IsToxicWordsResult(List<proto.WorkshopDirtyWord> dirtyWords)
	{
		return false;
	}

	private bool IsToxicPictureResult(List<proto.WorkshopDirtyPicture> dirtyPic)
	{
		return false;
	}

	private string GetReviewResultByDirtyWords(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private string GetReviewResultByDirtyWords(List<proto.WorkshopDirtyWord> dirtyWords, bool bLink = true)
	{
		return null;
	}

	private string GetReviewResultByPicture(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private string GetReviewResultByPicture(List<proto.WorkshopDirtyPicture> dirtyPic, bool bLink = true)
	{
		return null;
	}

	private string GetReviewResultByScreenShot(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private string GetReviewResultByScreenShot(List<proto.WorkshopDirtyPicture> dirtyPic, bool bLink = true)
	{
		return null;
	}

	private string GetReviewResultByWebAduit(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private string GetReviewResultByWebAduit(List<WorkshopWebAuditInfo> auditInfo, bool bLink = true)
	{
		return null;
	}

	private string GetReviewResultRealText(HashSet<uint> toxic_ids, bool bLink = true)
	{
		return null;
	}

	public int GetReviewResultCount(uint slotID, proto.EWorkshop.SlotType type)
	{
		return 0;
	}

	public string GetReviewDetails(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private string GetReviewResultPosition(proto.WorkshopDirtyWord dirtyWord)
	{
		return null;
	}

	private string GetReviewResultDetailsByDirtyWords(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	public string GetConsoleLogValue(proto.WorkshopDirtyWord word)
	{
		return null;
	}

	private string GetWebAduitPos(uint location)
	{
		return null;
	}

	private string GetReviewResultByDetailsWebAduit(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private string GetReviewResultByDetailsScreenShot(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private string GetReviewResultByDetailsPicture(uint slotID, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	private void DirtyWordFilter(ref HashSet<uint> hashSet, uint[] idxs)
	{
	}

	private List<string> DirtyWord2Strings(proto.WorkshopDirtyWord word)
	{
		return null;
	}

	public void SetReviewResult(uint serverSlotId, proto.EWorkshop.SlotType type, proto.EWorkshop.ReviewResult result)
	{
	}

	public proto.EWorkshop.ReviewResult GetReviewResult(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
		return proto.EWorkshop.ReviewResult.ReviewResult_PASS;
	}

	public void DelReviewResult(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public void DelReviewResuleAll(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public void SetDirtyScreenShots(List<proto.WorkshopDirtyPicture> dirtyPictures, uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public List<proto.WorkshopDirtyPicture> GetDirtyScreenShots(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	public void DelDirtyScreenShots(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public void SetDirtyWebAudit(List<WorkshopWebAuditInfo> dirtyPictures, uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public List<WorkshopWebAuditInfo> GetDirtyWebAudit(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	public void DelDirtyWebAudit(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public void SetDirtyPictures(List<proto.WorkshopDirtyPicture> dirtyPictures, uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public List<proto.WorkshopDirtyPicture> GetDirtyPictures(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	public void DelDirtyPictures(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public bool IsMapCoverAuditFailed(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	public void DelNeedShowDirtyWordsTips(uint serverSlotId, int type)
	{
	}

	public bool CheckNeedShowDirtyWordsTips(uint serverSlotId, int type)
	{
		return false;
	}

	public void SetDirtyWords(List<proto.WorkshopDirtyWord> dirtyWords, uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public List<proto.WorkshopDirtyWord> GetDirtyWords(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	public void DelDirtyWords(uint serverSlotId, proto.EWorkshop.SlotType type)
	{
	}

	public string GetResourceShopReviewSummary(proto.WorkshopReviewResult reviewResult, bool bLink = true)
	{
		return null;
	}

	public string[] GetWorkshopSearchHistories()
	{
		return null;
	}

	public void AddWorkshopSearchHistory(string searchHistory)
	{
	}

	public void ResetSearchHistory()
	{
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void OnStartMatch()
	{
	}

	public void OnRecordMatch()
	{
	}

	public List<NewbieTrainingCenterDesc> GetTrainingCenterDescs()
	{
		return null;
	}

	public void RequestTrainingCenterData()
	{
	}

	private void RequestTrainingCenterDesc()
	{
	}

	private void RequestTrainingCenterInfo()
	{
	}

	public bool RequestResourceStoreAuthorName(ulong[] ids, Action callback)
	{
		return false;
	}

	public void NotifyResourceShop(NotifyPlayer notifyPlayer)
	{
	}

	public bool RequestResourceStore(proto.EWorkshop.ResourceStoreCmd cmd, object reqObj, object[] extra)
	{
		return false;
	}

	public void RequestResourceShopPersonalInfo()
	{
	}

	public void RequestWorkshopMapDetection(string workshopCode, uint debug_count, uint save_count, uint upload_count, uint update_count, uint edit_time, uint object_count, uint block_count, uint widget_count)
	{
	}

	public void RequestCreateRoomInfo()
	{
	}

	public uint GetfFreeRoomCardCount()
	{
		return 0u;
	}

	public bool IsRoomFreeForever(bool defaultValue = false)
	{
		return false;
	}

	public bool IsFreeRoomCardRefresh()
	{
		return false;
	}

	public void UpdateReviewState(ReviewFinishedNtf nft)
	{
	}

	public void UpdateWorkShopRoomCard(uint freeNum, bool refresh)
	{
	}

	public void PredownloadCreateCDN()
	{
	}

	public List<UGCCustomModeTemplateRuleData> GetUGCCustomModeTemplateRuleDataList()
	{
		return null;
	}

	public List<WorkshopRecommendSeriesDesc> GetRecommendSeriesDesc()
	{
		return null;
	}

	public List<WorkshopCategoryPageDesc> GetCategoryPageDesc()
	{
		return null;
	}

	public List<WorkshopTemplateConfigDesc> GetWorkshopTemplateList()
	{
		return null;
	}

	public List<WorkshopUGCOpeningInfoDesc> GetUgcOpeningInfoDescs()
	{
		return null;
	}

	public List<SceneEditSlotInfo> GetTagMatchResourceDownloadInfos()
	{
		return null;
	}

	public WorkshopTimeLimitedModeRuleTagDesc GetTimeLimitedModeRuleTagDesc(uint tagId)
	{
		return null;
	}

	public void RequestWorkshopCustomModeTemplateRule(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	private void SetWorkshopMapSurveyData()
	{
	}

	public string GetWorkshopMapSurveyUrl(string code)
	{
		return null;
	}

	public int GetWorkshopMapPlayNum(string code)
	{
		return 0;
	}

	public void LogFunnelClickByName(string name)
	{
	}

	public static bool HasPendingClipboardWorkshopInfo()
	{
		return false;
	}

	public static bool HasPendingClipboardWorkshopRequest()
	{
		return false;
	}

	public static UIWorkshopDetailController OpenPendingClipboardWorkshopDetail()
	{
		return null;
	}

	public void RequestCheckShareCode(bool isLogin, LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 4u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public static void RequestCheckShareCodeStatic(bool isLogin, LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 4u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestShareCodeInGame(string str, Action<SceneEditSlotInfo> onFinished = null)
	{
	}

	public string GetMultipleMapNames(string code)
	{
		return null;
	}

	public void RequestEditorChoiceWorkshopDetail(string code, Action<WorkshopBasicInfo> onFinished, bool force = false)
	{
	}

	public void RequestWorkshopDetailByCode(string code, Action<bool> onFinished)
	{
	}

	public void RequestRoomDetailInfo(string code)
	{
	}

	public SceneEditSlotInfo GetRoomDetailInfo(string code)
	{
		return null;
	}

	public void ClearRoomDetailInfo()
	{
	}

	public int GetRoomTemplateID(string workshopcode)
	{
		return 0;
	}

	public void RequestSearch(string code, bool isGMPreview = false)
	{
	}

	public void RequestSearchMap(string code, bool skipCD = false, Action<bool, SceneEditSlotInfo> onFinished = null)
	{
	}

	public void RequestSearchMaps(string str, bool skipCD = false, bool offlineSerach = false)
	{
	}

	public void RequestReportAsset(UGCResourceShopMetaData metaData, List<uint> common_datas, string common_text, List<uint> other_datas, string other_text)
	{
	}

	public void RequestReport(string code, List<uint> common_datas, string common_text, List<uint> other_datas, string other_text, EUGCScene src, EUGCScene map_scene)
	{
	}

	public void UpdateWorkshopMatchResultData(uint DeltaExp, uint DeltaPlayCount, uint PlayDuration, uint AccountTotalExp, bool ReachDailyLimit)
	{
	}

	public WorkshopAccountInfo GetMyAccountWorkShopInfo()
	{
		return null;
	}

	public UGCRSP_PersonalInfoResInner GetMyAccountResourceShopInfo()
	{
		return null;
	}

	public void InitMyMaxCost()
	{
	}

	public void RequestWorkShopPersonalInfo()
	{
	}

	public void ReqSetWorkshopBirthYear(int birthYear)
	{
	}

	public bool IsCanClaimReward()
	{
		return false;
	}

	public void CheckLevelCanRewarded()
	{
	}

	public bool CheckLevelCanCreateBigMap()
	{
		return false;
	}

	private void SendUGCLoginInfo()
	{
	}

	public void RequestRecommendationInfo(bool force = false)
	{
	}

	public void RequestLatestReleaseMap(uint pageID, bool force = false)
	{
	}

	public void RequestEditorChoiceById(uint id)
	{
	}

	public List<WorkshopLatestInfo> GetWorkShopLatestInfos()
	{
		return null;
	}

	public void RequestLatestInfo()
	{
	}

	public Dictionary<uint, List<WorkshopRecommendSeriesInfo>> GetRecommendSeriesInfos()
	{
		return null;
	}

	public bool CheckRecommendSeriesCache(List<uint> seriList)
	{
		return false;
	}

	public void RequestRecommendSeriesInfo(List<uint> seriList)
	{
	}

	public void RequestCategoryInfo(uint id, int index)
	{
	}

	public void RequestOfficialMapInfo(int index)
	{
	}

	public void LeaveUGCCenter()
	{
	}

	public void CancelClearWaterfallData()
	{
	}

	public List<WorkshopMapPoolSortOptionDesc> GetWaterfallFliterData()
	{
		return null;
	}

	public List<WorkshopLeaderboardConfigDesc> GetWaterfallLeaderboardConfig()
	{
		return null;
	}

	public List<WorkshopCreatorPrivilegeDesc> GetWorkshopCreatorPrivilegeInfos()
	{
		return null;
	}

	public WorkshopCreatorRewardDesc GetWorkshopCreatorRewardInfoByLevel(uint level)
	{
		return null;
	}

	public WaterfallPoolData GetWaterfallPoolData(uint poolType = 0u, uint genreID = 0u)
	{
		return null;
	}

	public List<WorkshopCodeWithRankInfo> GetWaterfallLeaderboardData(uint poolType = 0u)
	{
		return null;
	}

	public void SetWaterfallLeaderboardData(uint poolType = 0u, List<WorkshopCodeWithRankInfo> data = null)
	{
	}

	public SceneEditSlotInfo GetWaterfallSlotInfo(string code)
	{
		return null;
	}

	public void SetWaterfallSlotInfo(string code, SceneEditSlotInfo info, proto.EWorkshop.SlotState state = proto.EWorkshop.SlotState.SlotState_NORMAL)
	{
	}

	public void PinWaterfallSlotInfo(string code)
	{
	}

	public void UnpinWaterfallSlotInfo(string code)
	{
	}

	public void ClearWaterfallData()
	{
	}

	public void RequestWaterfallPoolData(WaterfallPoolData data)
	{
	}

	public void RequestWaterfallLeaderboardData(WaterfallPoolData data)
	{
	}

	public void RequestBatchWaterfallLeaderboardData(List<WaterfallPoolData> dataList)
	{
	}

	public void RequestWaterfallSlotInfo(List<string> codes, WaterfallPoolData data = null, bool needAddToValidCodeList = false, int lastIndex = 0)
	{
	}

	public void RequestWaterfallSlotInfoByLeaderboard(List<int> nums, List<WaterfallPoolData> dataList = null, List<string> extraCodes = null)
	{
	}

	public List<WorkshopHistoryInfo> GetWorkshopHistoryInfos()
	{
		return null;
	}

	public void RequestHistoryInfo()
	{
	}

	public void RequestSelfdomInfo(bool isFirst)
	{
	}

	public bool CheckRefreshSelfdomInfoCD()
	{
		return false;
	}

	public void RequestLikeCode(string code, bool isLike, EUGCScene scene)
	{
	}

	public void RequestCommentCode(SceneEditSlotInfo info, uint[] tags, EUGCScene src, ulong match_id)
	{
	}

	public bool IsCommentDuringCD(string code)
	{
		return false;
	}

	public bool IsConsoleCheckCD(out float cd)
	{
		cd = default(float);
		return false;
	}

	public bool IsQuickJoinDuringCD(out float cd)
	{
		cd = default(float);
		return false;
	}

	private void HandleErrorMsg()
	{
	}

	private void ShowPopTips(string msg, object[] data)
	{
	}

	public void CloseWorkshopDetailLoadingUIImmediately()
	{
	}

	private void LoadSceneEditGame()
	{
	}

	public byte[] ExtractWorkshopBitMap(FFEAJEKGIIF sceneBuilder)
	{
		return null;
	}

	public byte[] ExtractWorkshopIconMap(Dictionary<int, SceneEditObjectBase> itemMap)
	{
		return null;
	}

	public List<uint> ExtractTags()
	{
		return null;
	}

	public List<uint> ExtractGraphTags()
	{
		return null;
	}

	public List<uint> ExtractSceneEditObjectTags(Dictionary<int, SceneEditObjectBase> itemMap)
	{
		return null;
	}

	public CLMPMGMIDGD ExtractModeSetting()
	{
		return null;
	}

	public bool IsSubscriptionSlotLastUpdated(SceneEditSlotInfo info)
	{
		return false;
	}

	public bool IsWorkshopBanned()
	{
		return false;
	}

	public bool IsWorkshopManager()
	{
		return false;
	}

	public uint GetAuthorTag()
	{
		return 0u;
	}

	public void RequestSetDisplaySocialMedia(GalleryShow.SocialMediaType targetType, Action<bool> callback)
	{
	}

	public void UpdateSelfSocialMediaProfile(SocialProfileInfo profileInfo, bool isBinding)
	{
	}

	public void RemoveSelfSocialMediaProfile(uint platform)
	{
	}

	public UIWorkshopDetailController OpenWorkshopDetailWnd(SceneEditSlotInfo slotInfo, EUGCScene scene, EOpenWorkshopDetailFrom from = EOpenWorkshopDetailFrom.None, UISceneEditUGCCenterController.ETabIndex tabIndex = UISceneEditUGCCenterController.ETabIndex.ETabIndex_Recommendation, bool needPopEventLog = true, EUGCWndFrom wndFrom = EUGCWndFrom.EUGCWndFrom_None, bool roomAutoEventLog = true, EditorConnectionMode editorConnectionMode = EditorConnectionMode.Online)
	{
		return null;
	}

	public void LogUGCMapPopup(SceneEditSlotInfo slotInfo, UINavigationUtil.UINavigationFrom ui_from, string from_info)
	{
	}

	public void RecordQuickJoinMap(SceneEditSlotInfo info)
	{
	}

	public List<SceneEditSlotInfo> GetCreateRoomSlotInfos(EWorkShopCreateRoomSrc src)
	{
		return null;
	}

	public void SetRoomCreateSrcWorkshopCode(EWorkShopCreateRoomSrc src, string wscode)
	{
	}

	public EWorkShopCreateRoomSrc GetRoomCreateSrc()
	{
		return EWorkShopCreateRoomSrc.RoomCurrent;
	}

	public string GetRoomCreateWorkshopCode()
	{
		return null;
	}

	public void SaveCreatorData(ulong mapSubscription, ulong mapLike, ulong assetLike, ulong assetBuy)
	{
	}

	private void SaveLastOpenCFTimeStamp()
	{
	}

	private void DeleteCFLocalData()
	{
	}

	public bool CheckShowCFPopWin()
	{
		return false;
	}

	public int GetAuthorPublishedAssetCount()
	{
		return 0;
	}

	public UISceneEditCreatorFeedbackPopWndController OpenCreatorFeedBackWnd()
	{
		return null;
	}

	public bool CheckHasOpendUserAgreement()
	{
		return false;
	}

	public void SetHasOpendUserAgreementOpen()
	{
	}

	public bool EnableShowGMVerify()
	{
		return false;
	}

	public UGCRoomMatchMakingData GetRoomMatchData()
	{
		return null;
	}

	public void RefreshDeterminedMap()
	{
	}

	public bool IsWorkshopItemForbidden(uint itemId)
	{
		return false;
	}

	public bool IsWorkshopAPIForbidden(string apiName)
	{
		return false;
	}

	public void RequestGoPosInfo(string shareCode, Action<WorkShopVideoInfo> callback)
	{
	}

	public void InitReportCSV()
	{
	}

	public void InitAssetStoreReportCSV()
	{
	}

	private void InitWorkshopMapLabelsDesc()
	{
	}

	public UGCMapLabelConfig GetActiveMapLabelConfig(uint[] ids)
	{
		return null;
	}

	private void InitWorkshopAuthorLabelsDesc()
	{
	}

	public UGCCreatorLabelConfig GetActiveAuthorLabelConfig(uint[] ids)
	{
		return null;
	}

	public void InitAlgorithmRecordDownloadGameData(List<string> workshopCodes)
	{
	}

	private void RecordStartDownloadGameData(string workshopCode)
	{
	}

	private void RecordFinishDownloadGameData(string workshopCode, byte[] gameData)
	{
	}

	public void StartRecordResCheck()
	{
	}

	public void EndRecordResCheck()
	{
	}

	public void SubmitRecordResCheck()
	{
	}

	public void CollectLevelObjectInfoAndShopInfo(List<EIJCHJHFFGI> itemInfos, List<EBEIAALOCBN> resourceInfos, List<NLNAMPBAGDC> hudPrefabDataList)
	{
	}

	private void InitUGCAISetParameterMapping()
	{
	}

	public UGCAI_SetParameter_Mapping GetParameterDataByName(string name)
	{
		return null;
	}

	public UGCAI_SetParameter_Mapping GetParameterDataByID(int id)
	{
		return null;
	}

	public void RequestChangeCraftlandEditPresence(proto.EPresence.AccountCraftLandEditStatus status)
	{
	}

	public string[] GetItemGenSearchHistories()
	{
		return null;
	}

	public void AddItemGenSearchHistory(string searchHistory)
	{
	}

	public void ResetItemGenSearchHistory()
	{
	}

	public bool HasItemGenSearchHistory()
	{
		return false;
	}

	public List<UGCAI_3DGen_RecoList> GetRandomItemGenGuess()
	{
		return null;
	}

	public bool DownloadResourceBytes(UGCResourceShopMetaData metaData, Action onSuccess = null, Action onFailure = null)
	{
		return false;
	}

	public List<WorkshopGenreID> GetWorkshopGenreIDs()
	{
		return null;
	}

	public WorkshopGenreID GetWorkshopGenreIDByID(uint genreId)
	{
		return null;
	}

	public WorkshopGenreID GetWorkshopEditGenreIDBySlotInfo(SceneEditSlotInfo info)
	{
		return null;
	}

	public WorkshopGenreID GetWorkshopServerGenreIDBySlotInfo(SceneEditSlotInfo info)
	{
		return null;
	}

	public string GetGenreTextBySlotInfo(SceneEditSlotInfo info)
	{
		return null;
	}

	public List<WorkshopTagType> GetWorkshopTagType()
	{
		return null;
	}

	public WorkshopTagType GetWorkshopTagTypeByID(uint tagId)
	{
		return null;
	}

	public List<WorkshopModeTagData> GetWorkshopModeTagDataByTagType(uint tagTypeId)
	{
		return null;
	}

	public List<uint> FilterManualTags(uint[] raw)
	{
		return null;
	}

	public List<WorkShopPlayerStartTag> GetWorkShopPlayerStartTag()
	{
		return null;
	}

	public void StoreBeforeClose(object[] parameters)
	{
	}

	public object[] GetRestoreParameters()
	{
		return null;
	}

	public void ClearRestoreParameters()
	{
	}

	public void ClearRestoreParametersDelayCall()
	{
	}

	public void StoreUGCUserCenterBeforeClose(uint tabType)
	{
	}

	public bool TryConsumeUGCUserCenterRestore(out uint tabType)
	{
		tabType = default(uint);
		return false;
	}

	public void ClearUGCUserCenterRestore()
	{
	}

	public void ClearUGCUserCenterRestoreDelayCall()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public bool CheckShowPlayPreference(out EventLogger.EventTypeUGCPlatformStartSurveySubmitTriggerReason triggerReason)
	{
		triggerReason = default(EventLogger.EventTypeUGCPlatformStartSurveySubmitTriggerReason);
		return false;
	}

	public void MarkPlayPreferenceShown()
	{
	}

	public void SetLoadingSceneSlotInfoOffline(SceneEditSlotInfo slotInfo)
	{
	}

	public void SetLoadingSceneSlotInfo(MatchmakingSussNtf resData)
	{
	}

	public SceneEditSlotInfo GetLoadingSccEditSlotInfo()
	{
		return null;
	}

	public bool EnterSceneEditInPreview(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	private void OnEnterSceneEditAdjustCameraData()
	{
	}

	public bool EnterSceneEditWithMySlot(uint slotID, uint templateID, uint mapID, uint areaID, bool download, bool reEnterEdit = false, EEnterSceneEditMode editMode = EEnterSceneEditMode.EMode_MySlot, proto.EWorkshop.SlotType slotType = proto.EWorkshop.SlotType.SlotType_AUTHOR, SceneEditSlotInfo oriSlotInfo = null)
	{
		return false;
	}

	public bool EnterSceneEditWithMySlot(SceneEditSlotInfo slotInfo, bool download, EEnterSceneEditMode editMode = EEnterSceneEditMode.EMode_MySlot)
	{
		return false;
	}

	public bool EnterSceneEditWithCreateNew(uint id, string name, bool nameEdited, uint map, uint mode, uint template, uint areaID = 0u)
	{
		return false;
	}

	public bool EnterSceneEditWithTutorialLevel()
	{
		return false;
	}

	public bool EnterSceneEditWithTutorialLevel(uint mapId, uint areaId = 0u)
	{
		return false;
	}

	public bool EnterSceneEditWithSecEdit(SceneEditSlotInfo info, uint slotId, string name)
	{
		return false;
	}

	public SceneEditSlotInfo GetLatestSceneEditSlotInfo()
	{
		return null;
	}

	public List<SceneEditSlotInfo> GetLatestSearchSlotInfos()
	{
		return null;
	}

	public bool GetLatestSearchWithCodeSucceeded()
	{
		return false;
	}

	public uint GetLatestSelectedSlotID()
	{
		return 0u;
	}

	public void SetLatestSelectedSlotID(uint id)
	{
	}

	public void SetLatestSource(UINavigationUtil.UINavigationFrom ui_from)
	{
	}

	public UINavigationUtil.UINavigationFrom GetLatestSource()
	{
		return UINavigationUtil.UINavigationFrom.None;
	}

	public bool PopulateSlotInfoToSceneEditGame(SceneEditSlotInfo slotInfo)
	{
		return false;
	}

	private void LoadLocalSaves()
	{
	}

	public void NotifyDataSavedInGame()
	{
	}

	public void UpdateAuthorAndLocalSaveSlot(uint slotId)
	{
	}

	public void UpdtaeAuthorAndLocalRuntimeData(uint slotId)
	{
	}

	public void CopyLocalSaveTo(uint srcSlotId, uint destSlotId, proto.EWorkshop.SlotType srcType)
	{
	}

	public bool SaveAsToSlot(uint srcSlotId, uint destSlotId, proto.EWorkshop.SlotType srcSlotType)
	{
		return false;
	}

	public void LobbySaveAsToEmptySlot(uint srcSlotId, proto.EWorkshop.SlotType srcSlotType, Action<bool, uint> callback)
	{
	}

	public void InGameSaveAsToEmptySlot(uint srcSlotId, proto.EWorkshop.SlotType srcSlotType, Action<bool, uint> callback)
	{
	}

	public void SwitchEditingToNewSlot(uint destSlotId, bool reopenModeSetting)
	{
	}

	public uint GetNextUnlockSlotID()
	{
		return 0u;
	}

	public uint GetNextEmptySlotID()
	{
		return 0u;
	}

	public void RequestGameMapSlotInfo(string code, bool isGMPreview = false, Action action = null)
	{
	}

	public void OnUploadCDNSuccResponse(KKMFBJGIEBD info, proto.EWorkshop.SlotType slotType)
	{
	}

	public int GetAuthorPublishedSlotCount()
	{
		return 0;
	}

	public static byte[] CompressGzip(byte[] inputBytes)
	{
		return null;
	}

	public static byte[] UnGZip(byte[] byteArray)
	{
		return null;
	}

	private void AppendCreatorTrace(CSGetUploadWorkshopURLReq req, uint slotID)
	{
	}

	private void AppendUGCDefinedStrings(CSGetUploadWorkshopURLReq req, SceneEditSlotInfo slot)
	{
	}

	private void AddMapScoreDetails(CSGetUploadWorkshopURLReq req, SceneEditSlotInfo slot)
	{
	}

	private void AddAutoSaveDataStorage(CSGetUploadWorkshopURLReq req, SceneEditSlotInfo localSave)
	{
	}

	private bool IsAutoSaveEnabledInProjectFile(SceneEditSlotInfo localSave)
	{
		return false;
	}

	private bool HasAutoSaveAttribute(ALHOCINMDFH projectData, uint slotId)
	{
		return false;
	}

	private bool CheckBlockTxtValid(CSGetUploadWorkshopURLReq req)
	{
		return false;
	}

	public void RequestUploadWorkShopDirtyWord(uint slot_id, proto.EWorkshop.SlotType type, List<WorkshopWordFilter> strs)
	{
	}

	public bool RequestUploadWorkshopCDN(SceneEditSlotInfo slot, bool update, bool needNotify = false)
	{
		return false;
	}

	public void RequestDownloadWorkshopCDN(EWorkshopDownloadType downloadType, proto.EWorkshop.SlotType slotType, uint slotID, uint destId, proto.EWorkshop.SlotType destType = proto.EWorkshop.SlotType.SlotType_AUTHOR, Action callback = null, bool needTips = true)
	{
	}

	public void OnDownLoadWorkShopCDNSuccResponse(CSDownloadWorkshopRes data, EWorkshopDownloadType downloadType, proto.EWorkshop.SlotType slotType, proto.EWorkshop.SlotType destType, uint slotID, uint destID, byte[] cdnProjectBytes, byte[] cdnRuntimeBytes, byte[] coverBytes, Action callback = null, bool needTips = true)
	{
	}

	private void HandleDownloadInGame(proto.EWorkshop.SlotType slotType, uint slotID, uint destID, byte[] downloadedProjectDataBytes, byte[] downloadedRuntimeDataBytes, byte[] coverBytes = null, Action callback = null)
	{
	}

	private void HandleDownloadLobbySaveAs(proto.EWorkshop.SlotType slotType, uint srcId, uint destId, byte[] projectBytes, byte[] runtimeBytes, byte[] customCover = null, proto.EWorkshop.SlotType destType = proto.EWorkshop.SlotType.SlotType_AUTHOR, Action callback = null, bool needTips = true)
	{
	}

	private void HandleDownloadAndSave(proto.EWorkshop.SlotType slotType, uint srcId, uint destId, byte[] projectBytes, byte[] runtimeBytes, byte[] customCover = null, proto.EWorkshop.SlotType destType = proto.EWorkshop.SlotType.SlotType_AUTHOR, Action callback = null, bool needTips = true)
	{
	}

	private void ProcessLocalSaveOnDel(uint slotId, proto.EWorkshop.SlotType slotType)
	{
	}

	public void ClearCDNCache()
	{
	}

	public void RequestPreview(string previewCode)
	{
	}

	public void RequestSecEdit(SceneEditSlotInfo info, uint destId)
	{
	}

	public void RequestSecEditInGame()
	{
	}

	private void InitClearResInfoMapLimit()
	{
	}

	private void ClearResInfoMapLimit()
	{
	}

	public bool IsInErrorMapSet(string workshopCode)
	{
		return false;
	}

	public void RequestResInfo(SceneEditSlotInfo slotInfo, bool showDownloadPop = false, bool needLoading = true, bool force = false, EUGCScene from = EUGCScene.EUGCScene_None)
	{
	}

	public void RequestResInfoWithExportUrl(SceneEditSlotInfo slotInfo)
	{
	}

	public bool IsMapDownloading(string workshopCode)
	{
		return false;
	}

	public void RequestGameData(SceneEditSlotInfo slotInfo, bool showDownloadPop = false)
	{
	}

	public bool DownloadResourceBytes(List<UGCResInfo> resInfos, Dictionary<string, UGCResourceForGameData.PackageOrABFileInfo> fileInfos)
	{
		return false;
	}

	private void DownloadResourceBytesInternal(List<UGCResourceForGameData.PackageOrABFileInfo> fileInfos)
	{
	}

	public void OnDownLoadPreivewCDNSuccResponse(CSPreviewWorkshopCodeRes data, string previewCode, byte[] downloadedBytes)
	{
	}

	public void OnDownLoadSecEditCDNSuccResponse(CSAllowRecreateRes data, SceneEditSlotInfo info, uint destId, byte[] downloadedBytes, byte[] runtimeBytes)
	{
	}

	public void OnDownLoadInGameSecEditCNDSuccResponse(uint slotID, byte[] cdnProjectBytes, byte[] cdnRuntimeBytes, byte[] coverBytes, Action callback)
	{
	}

	public bool CheckLastCDNDownloadFailed()
	{
		return false;
	}

	public void OnDownloadFailed(EWorkshopDownloadType downloadType, SceneEditSlotInfo slotInfo)
	{
	}

	public void OnDownloading()
	{
	}

	public void OnUploadFailed(bool isUpdate)
	{
	}

	private void HandlePreviewInGame(string previewCode, byte[] downloadedProjectDataBytesForPreview)
	{
	}

	private void HandleDownLoadForSecEdit(SceneEditSlotInfo info, uint destId, byte[] downloadedProjectDataBytesForSecEdit, byte[] runtimeBytes)
	{
	}

	private void HandleDownloadGameData(SceneEditSlotInfo info, byte[] gameData, bool showDownloadPop)
	{
	}

	private void OnGameDataReady(SceneEditSlotInfo info, byte[] gameData, bool showDownloadPop)
	{
	}

	public void CloseLoadingUI(string reason = null)
	{
	}

	public void OpenLoadingUI(string reason = null, bool needResetDepth = false, int newDepth = 200, EUGCScene from = EUGCScene.EUGCScene_None)
	{
	}

	private void CloseLoadingUIImmediately()
	{
	}

	public static bool IsCreatorFeedbackScreenshotWithinConfiguredLimit(byte[] bytes)
	{
		return false;
	}

	public static void ShowCreatorFeedbackFailureBox(string infoLocKey, UIPopupMessageBoxController.EStandardMessageBoxType mbType = UIPopupMessageBoxController.EStandardMessageBoxType.Error, string reportLog = null, EventLogger.UGCSurveySceneType surveySceneType = EventLogger.UGCSurveySceneType.EditorMoreFeedback)
	{
	}

	public void UploadCreatorFeedbackBytes(byte[] bytes, ECreatorFeedback.UploadFileType fileType, string fileExt, Action<bool, string, string> callback)
	{
	}

	public void FilterCreatorFeedbackDirtyWord(string description, Action<bool, bool, string> callback)
	{
	}

	public void SubmitCreatorFeedback(uint feedbackType, uint moduleSelection, string description, List<string> screenshotUrls, string reportLog, Action<bool, string> callback)
	{
	}

	private IEnumerator UploadOneCreatorFeedbackFile(string url, byte[] data, Action<bool, string> done)
	{
		return null;
	}

	public uint GetFirstEmptyAuthorPublishedSlotId()
	{
		return 0u;
	}

	public bool RequestSlotInfo(bool force = false)
	{
		return false;
	}

	public void RequestUnlock(uint slotId, proto.EWorkshop.UnlockSlotCostType costType)
	{
	}

	public void RequestShare(uint slot)
	{
	}

	public void RequestDelAuthor(uint id, EWorkshopDelType type, SceneEditSlotInfo workshopInfo)
	{
	}

	private void RequestDel(proto.EWorkshop.SlotType type, uint id, EWorkshopDelType delType, SceneEditSlotInfo workshopInfo)
	{
	}

	public bool CheckUploadAllowDisclosureDuringCD()
	{
		return false;
	}

	public bool RequestSetWorkshopAuthorTag(bool toggle, bool skipCD = false)
	{
		return false;
	}

	public WorkshopAuthorInfo GetWorkshopAuthorInfo()
	{
		return null;
	}

	public void RequestWorkshopAuthorInfo(ulong author_id, bool myself = false, bool cache = false)
	{
	}

	public WorkshopAuthorInfo GetOtherWorkshopAuthorInfoFromCache(ulong author_id)
	{
		return null;
	}

	public static bool CanMapBeEdited(uint mapid)
	{
		return false;
	}

	public bool CanBeUpdated(uint id)
	{
		return false;
	}

	public int GetSlotInfoIndex(uint slotID)
	{
		return 0;
	}

	public ulong CalculateDefaultResCnt(ulong resCnt, ulong preCost)
	{
		return 0uL;
	}

	public SceneEditSlotInfo GetSceneEditSlotInfoBySlotTypeAndID(uint slotType, uint slotID)
	{
		return null;
	}

	public SceneEditSlotInfo GetAuthorSceneEditSlotInfo(uint slotID)
	{
		return null;
	}

	public SceneEditSlotInfo GetAuthorSceneEditSlotInfoByServerId(uint serverId)
	{
		return null;
	}

	public List<WorkshopHotInfo> GetHotWorkshopInfoList()
	{
		return null;
	}

	public List<WorkshopBasicInfo> GetLatestReleaseMapList()
	{
		return null;
	}

	public List<WorkshopHotSearchConfigDesc> GetHotSearchConfigDescList()
	{
		return null;
	}

	public List<WorkshopEditorChoiceDesc> GetWorkshopEditorChoiceList()
	{
		return null;
	}

	public List<WorkshopEditorChoiceDesc> GetResourceShopEditorChoiceList()
	{
		return null;
	}

	public bool IsHotWorkshopMap(SceneEditSlotInfo info)
	{
		return false;
	}

	public bool GetWorkshopPictureURL(string workshopCode, out string result)
	{
		result = null;
		return false;
	}

	public void SaveNotifySubscriberTipsTime()
	{
	}

	public bool CheckIsShowNotifySubscriberTips()
	{
		return false;
	}

	public bool CheckShowNotifySettingTips()
	{
		return false;
	}

	public void SaveShowNotifySettingTips()
	{
	}

	public bool CheckIsShowNotifySubscriber(long notifyTime, bool isUGCCenter = true)
	{
		return false;
	}

	public bool CheckIsShowCrown(string workshopCode)
	{
		return false;
	}

	private byte[] GetWorkShopBitMapBytes(int width, int[,] arr)
	{
		return null;
	}

	public int[,] GetWorkShopBitMapArr(int width, byte[] bytes)
	{
		return null;
	}

	public WorkshopShowMapIconData GetWorkShopMapShowIconData(uint itemid)
	{
		return null;
	}

	public List<SceneEditSlotInfo> GetSlotListByType(proto.EWorkshop.SlotType type)
	{
		return null;
	}

	public List<SceneEditPublishedSlotInfo> GetPublishedSlotInfoList()
	{
		return null;
	}

	public Dictionary<uint, SceneEditPublishedSlotInfo> GetPublishedSlotInfoMap()
	{
		return null;
	}

	public SceneEditPublishedSlotInfo GetPublishedSlotInfoByServerSlotId(uint slotId)
	{
		return null;
	}

	public SceneEditSlotInfo GetLocalSaveBySlotId(uint slotId, proto.EWorkshop.SlotType type)
	{
		return null;
	}

	public uint GetFirstEmptyAuthorSlotId()
	{
		return 0u;
	}

	public bool HasThisCodeSubscribed(string code)
	{
		return false;
	}

	public bool IsThisCodeCanBeSubscribed(string code)
	{
		return false;
	}

	public void RequestSubscriptionSlotInfo()
	{
	}

	public void RequestDelSubscription(uint id, SceneEditSlotInfo workshopInfo)
	{
	}

	public void RequestBatchDelSubscription(uint[] slots)
	{
	}

	public bool CheckSubscribeCapacity()
	{
		return false;
	}

	public bool TryDeleteInvalidSubscribe(out uint slotId)
	{
		slotId = default(uint);
		return false;
	}

	public EQuickSubResult TryRequestQuickSubscribeOrDel(string code, EUGCScene src)
	{
		return EQuickSubResult.EDel;
	}

	private bool IsValidQuickOp()
	{
		return false;
	}

	public ulong GetSubscribeFixedCount(SceneEditSlotInfo info)
	{
		return 0uL;
	}

	public void RequestSubscribe(uint id, string code, EUGCScene src)
	{
	}

	public void RequestSetWorkshopRecommendInfoSubscription(bool subscribe)
	{
	}

	private bool _003CGetUGCAdvancedData_003Eb__203_0(WorkshopEditLevelDesc item)
	{
		return false;
	}

	private void _003CRequestTrainingCenterDesc_003Eb__456_0(HttpErrorCode err, object res)
	{
	}

	private void _003CRequestResourceShopPersonalInfo_003Eb__461_0(HttpErrorCode errorCode, object resObj)
	{
	}

	private void _003CRequestCreateRoomInfo_003Eb__463_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestWorkshopCustomModeTemplateRule_003Eb__493_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestWorkShopPersonalInfo_003Eb__526_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestRecommendationInfo_003Eb__534_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLatestReleaseMap_003Eb__535_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLatestInfo_003Eb__541_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestRecommendSeriesInfo_003Eb__545_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestHistoryInfo_003Eb__580_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCommentCode_003Eb__584_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRefreshDeterminedMap_003Eb__657_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSecEditInGame_003Eb__850_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSlotInfo_003Eb__913_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestUnlock_003Eb__914_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestShare_003Eb__915_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSubscriptionSlotInfo_003Eb__970_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestBatchDelSubscription_003Eb__972_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
