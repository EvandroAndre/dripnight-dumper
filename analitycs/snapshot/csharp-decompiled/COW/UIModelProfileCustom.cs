using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using UnityEngine;
using proto;

namespace COW;

public class UIModelProfileCustom : UIBaseModel
{
	public enum EDataSource
	{
		None,
		CollectionBox,
		LeftGrid,
		RightGrid,
		UGCProfile
	}

	private class PendingServerResponse
	{
		public bool HasPending;

		public ulong AccountID;

		public CSGetPlayerGalleryInfoSettingRes RawData;

		public bool IsLeft;
	}

	public enum ProfileSocialMediaBindType
	{
		Unbind,
		Bind
	}

	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public UIModelProfileCustom _003C_003E4__this;

		public string waitingCmd;

		public string platformName;

		public int platform;

		internal void _003CRequestBindSocialMedia_003Eb__0(SDKSocialMediaProfile.LinkResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public UIModelProfileCustom _003C_003E4__this;

		public string waitingCmd;

		public int platform;

		internal void _003CRequestUnbindSocialMedia_003Eb__0(SDKSocialMediaProfile.UnlinkResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public bool isSelf;

		public UIModelProfileCustom _003C_003E4__this;

		public ulong accountID;

		public bool isLeft;

		public string waitingCmd;

		internal void _003CRequestCustomModuleData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public UIModelProfileCustom _003C_003E4__this;

		public ProfileCustomBigEventEquippedData data;

		public uint oldBigEventId;

		public uint oldBigEventLevel;

		internal void _003CRequestSetBigEventCollectionCover_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public Action failAction;

		internal void _003CRequestSetPlayerGalleryInfoSettingSingle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public uint weaponID;

		internal bool _003CIsProficiencyV2_003Eb__0(WeaponAwardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public uint weaponID;

		internal bool _003CCreateProficiencyData_003Eb__0(WeaponExpInfo x)
		{
			return false;
		}
	}

	public const uint PropID_DataReady = 1u;

	public const uint PropID_BigEventDataUpdate = 2u;

	public const uint PropID_SocialMediaUpdate = 4u;

	public const ulong REQ_CD_SECONDS = 300uL;

	public const string FORMAT_HELPER = "{0}_{1}";

	private Dictionary<uint, Type> m_DictCtrlEnumToCtrlType;

	private Dictionary<uint, Vector2Int> m_DictCtrlEnumToCellSize;

	private HashSet<int> m_ValidTabs;

	private HashSet<int> m_ValidTemplate;

	private Dictionary<ulong, List<ProfileCustomModuleData>> m_ClientData_Left;

	private Dictionary<ulong, List<ProfileCustomModuleData>> m_ClientData_Right;

	private Dictionary<ulong, ulong> m_ReqCD_Left;

	private Dictionary<ulong, ulong> m_ReqCD_Right;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private List<ProfileCustomModuleData> m_SelfCache_Left;

	private List<ProfileCustomModuleData> m_SelfCache_Right;

	private bool m_CacheDirty_Left;

	private bool m_CacheDirty_Right;

	private ProfileCustomModuleData m_BigEventEquippedData;

	private PendingServerResponse m_PendingServerResponse_Left;

	private PendingServerResponse m_PendingServerResponse_Right;

	private UIModelProfile m_ModelProfile;

	private UIModelAchievement m_ModelAchievement;

	private UIModelInventory m_ModelInventory;

	private UIModelBooyahPass m_ModelBP;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelWeaponPower m_ModelWeaponPower;

	private int m_RandomIndexForAutoFill;

	private Dictionary<ulong, GallerySocialMediaInfo> m_SocialMediaInfoDictServer;

	private Dictionary<uint, SocialProfileInfo> m_SelfMSDKProfileCache;

	private bool m_HasRequestedMSDKSocialMedia;

	private bool m_MSDKSocialMediaReady;

	private bool m_MSDKSocialMediaSuccess;

	private uint m_MSDKTimeoutHandle;

	public static readonly GalleryShow.SocialMediaType[] ALL_SOCIAL_MEDIA_TYPES;

	private UIModelProfile ModelProfile => null;

	private UIModelAchievement ModelAchievement => null;

	private UIModelInventory ModelInventory => null;

	private UIModelBooyahPass ModelBP => null;

	private UIModelWeaponProficiency ModelWeaponProficiency => null;

	private UIModelAreaLeaderBoard ModelAreaLeaderBoard => null;

	private UIModelWeaponPower ModelWeaponPower => null;

	public int RandomIndexForAutoFill => 0;

	public override void Init()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public bool CtrlEnumToCtrlType(ProfileCollectionItemTemplate ctrlType, out Type t)
	{
		t = null;
		return false;
	}

	public bool CtrlEnumToCellSize(ProfileCollectionItemTemplate itemType, out Vector2Int cellSize)
	{
		cellSize = default(Vector2Int);
		return false;
	}

	public string GetIconByTab(ProfileCustomTab tab)
	{
		return null;
	}

	public ProfileCustomTab GetTabByItemTemplate(ProfileCollectionItemTemplate ctrlType)
	{
		return ProfileCustomTab.None;
	}

	private void ClearValidSet()
	{
	}

	public void ProcessValidSet(List<profileModuleSwitchDesc> list)
	{
	}

	public bool IsValid(ProfileCustomTab tab)
	{
		return false;
	}

	public bool IsValid(ProfileCollectionItemTemplate ctrl)
	{
		return false;
	}

	private void ClearReqDatas()
	{
	}

	public void RequestCustomModuleData(ulong accountID, bool isLeft)
	{
	}

	private void SetPendingServerResponse(ulong accountID, CSGetPlayerGalleryInfoSettingRes rawData, bool isLeft)
	{
	}

	private void TryFlushPendingServerResponses()
	{
	}

	private void FlushSinglePendingServerResponse(PendingServerResponse pending)
	{
	}

	private void ProcessServerGalleryResponse(ulong accountID, CSGetPlayerGalleryInfoSettingRes rawData, bool isLeft)
	{
	}

	public void RequestUploadCacheWhenDirty()
	{
	}

	public void RequestUploadProfileCustomData(List<ProfileCustomModuleData> left, List<ProfileCustomModuleData> right)
	{
	}

	private void FilterInvalidItems(List<ProfileCustomModuleData> list)
	{
	}

	public void RequestSetBigEventCollectionCover(uint bigEventId, uint bigEventLevel)
	{
	}

	private void RequestSetPlayerGalleryInfoSettingSingle(List<GalleryShowInfo> infoItems, Action failAction)
	{
	}

	private void ClearSelfCustomData()
	{
	}

	public List<ProfileCustomModuleData> GetPlayerCustomModuleData(ulong accountID, bool isLeft, bool selfUseCache = true)
	{
		return null;
	}

	public ProfileCustomModuleData GetSelfCustomBigEventModuleDataSingle(bool isForceGet = false, bool isLeft = false)
	{
		return null;
	}

	public ProfileCustomModuleData GetSelfCustomBigEventModuleData(bool isForceGet = false)
	{
		return null;
	}

	private void ClientListToProtoList(List<ProfileCustomModuleData> left, List<ProfileCustomModuleData> right, List<GalleryShowInfo> protoDataList)
	{
	}

	private GalleryShow.InfoType CreateProtoItem(bool isLeft, ProfileCustomModuleData clientItem, out GalleryShowInfoItem protoItem)
	{
		protoItem = null;
		return GalleryShow.InfoType.InfoType_NONE;
	}

	private BattleStatsInfo ProtoBRDataToClientBRData(CSPlayerRankingSeasonStatsRes res)
	{
		return null;
	}

	private BattleStatsInfo ProfoCSDataToClientCSData(CSPlayerCSRankingSeasonStatsRes res)
	{
		return null;
	}

	private BattleStatsInfo ProfoCSPeakDataToClientCSData(PlayerCSPeakSeasonStats res)
	{
		return null;
	}

	private ProfileCustomModuleData CreateClientData(ulong accountID, GalleryShow.InfoType infoType, GalleryShowInfoItem protoItem, List<BasicEPInfo> bpList, BattleStatsInfo brData, BattleStatsInfo csData, BattleStatsInfo csPeakData, CSGetAccountWeaponExpInfoRes weaponProficiency, List<AchievementEntryInfo> bigEventEntryInfo)
	{
		return null;
	}

	private WeaponSkinBaseInfo CreateWeaponSkinItem(uint id)
	{
		return null;
	}

	private TitleInfo CreateTitleInfo(uint id)
	{
		return null;
	}

	private bool IsProficiencyV2(uint weaponID, uint exp, List<WeaponAwardInfo> res)
	{
		return false;
	}

	private ProfileCustomWeaponProficiencyData CreateProficiencyData(uint weaponID, CSGetAccountWeaponExpInfoRes res)
	{
		return null;
	}

	public EventLogger.EventTypeSetGallery.GalleryInfo[] GenerateLogInfos(List<ProfileCustomModuleData> leftList, List<ProfileCustomModuleData> rightList)
	{
		return null;
	}

	private EventLogger.EventTypeSetGallery.GalleryInfo GetLogInfo(ProfileCustomModuleData data, bool isLeft)
	{
		return null;
	}

	public void SetCacheDirtyFlag(bool? leftDirty = null, bool? rightDirty = null)
	{
	}

	private void ClearSocialMediaData()
	{
	}

	public void RequestSocialMediaInfoFromMSDK()
	{
	}

	private void OnMSDKSocialMediaTimeout()
	{
	}

	private void UpdateGallerySocialMediaInfoFromServer(ulong accountID, GallerySocialMediaInfo socialMediaInfo)
	{
	}

	public void UpdateSelfSocialMediaInfoFromMSDK(SDKSocialMediaProfile.SocialMediaProfileData profileData, bool isBinding)
	{
	}

	public GallerySocialMediaInfo GetGallerySocialMediaInfoByAccountID(ulong accountID)
	{
		return null;
	}

	public Dictionary<GalleryShow.SocialMediaType, ProfileCustomSocialMediaData> GetSelfLinkedSocialMediaData(ulong accountID)
	{
		return null;
	}

	public ProfileCustomSocialMediaData GetSelfSocialMediaDataByPlatform(uint platform)
	{
		return null;
	}

	public ProfileCustomSocialMediaData CreateSocialMediaData(SocialProfileInfo profileInfo, GallerySocialMediaInfo socialMediaInfo)
	{
		return null;
	}

	public ProfileCustomSocialMediaData GetSocialMediaDataByType(GalleryShow.SocialMediaType type, GallerySocialMediaInfo socialMediaInfo)
	{
		return null;
	}

	public void RequestBindSocialMedia(GalleryShow.SocialMediaType mediaType)
	{
	}

	public void RequestUnbindSocialMedia(GalleryShow.SocialMediaType mediaType)
	{
	}

	public int ConvertSocialMediaTypeToSDKPlatform(GalleryShow.SocialMediaType mediaType)
	{
		return 0;
	}

	public string GetPlatformName(int platform)
	{
		return null;
	}

	private string GetErrorCodeName(int errorCode)
	{
		return null;
	}

	public bool HasAnySupportedSocialMedia()
	{
		return false;
	}

	public bool IsSocialMediaTypSupported(GalleryShow.SocialMediaType mediaType)
	{
		return false;
	}

	private ESwitch.SwitchFunc GetSocialMediaSwitchFunc(GalleryShow.SocialMediaType mediaType)
	{
		return ESwitch.SwitchFunc.SwitchFunc_NONE;
	}

	public bool IsSocialMediaPlatformEnabled(GalleryShow.SocialMediaType mediaType)
	{
		return false;
	}

	private string FormatMSDKProfileLog(SDKSocialMediaProfile.SocialMediaProfileData profile)
	{
		return null;
	}

	private void _003CRequestUploadCacheWhenDirty_003Eb__64_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestUploadProfileCustomData_003Eb__65_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSocialMediaInfoFromMSDK_003Eb__94_0(SDKSocialMediaProfile.ProfileInfoResult result)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
