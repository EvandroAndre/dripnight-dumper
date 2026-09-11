using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelWeaponSkinUpgrader : UIBaseModel
{
	private class SortOwnedOrOpenningSkins : IComparer<SkinOwnAndOpenInfo>
	{
		public bool UseOwnedWeight;

		private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

		public int Compare(SkinOwnAndOpenInfo a, SkinOwnAndOpenInfo b)
		{
			return 0;
		}
	}

	private class WSUFeatureComparer : IComparer<int>
	{
		public EWeaponPrivilegeType weaponPrivilegeType;

		private Dictionary<uint, WeaponSkinUpgradeInfoData> m_WeaponSkinUpgradeInfo;

		public WSUFeatureComparer(Dictionary<uint, WeaponSkinUpgradeInfoData> weaponSkinUpgradeInfo)
		{
		}

		public int Compare(int x, int y)
		{
			return 0;
		}

		private int GetWeight(int feature)
		{
			return 0;
		}
	}

	private class FeatureByCarouselComparer : IComparer<WeaponSkinUpgradeInfoData>
	{
		public EWeaponPrivilegeType weaponType;

		public int Compare(WeaponSkinUpgradeInfoData x, WeaponSkinUpgradeInfoData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public uint id;

		internal bool _003CGetNeedDownloadResListBySkinId_003Eb__0(CSVBaseData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass146_0
	{
		public UIModelWeaponSkinUpgrader _003C_003E4__this;

		public CSUpgradeWeaponSkinReq req;

		public UIModelCollection modelCollection;

		public WeaponSkinData skinData;

		internal void _003CUpgradeWeaponSkin_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass148_0
	{
		public UIModelWeaponSkinUpgrader _003C_003E4__this;

		public List<uint> weaponSkinIds;

		internal void _003CExchangeWeaponSkinUpgradeToken_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass155_0
	{
		public UIModelWeaponSkinUpgrader _003C_003E4__this;

		public proto.WeaponSkinStat stat;

		internal void _003CRequestChangeEvoWeaponSkinProperty_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass156_0
	{
		public UIModelWeaponSkinUpgrader _003C_003E4__this;

		public proto.WeaponSkinStat stat;

		internal void _003CRequestChangeNotEvoWeaponSkinRights_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public uint skinItemId;

		internal bool _003CGetOwnAndOpenInfoById_003Eb__0(CSVBaseData x)
		{
			return false;
		}
	}

	public const uint KILL_COUNT_MIDDLE_NUM = 999999u;

	public const uint KILL_COUNT_MAX_NUM = 99999999u;

	private List<uint> m_HaveHadSkinIds;

	private HashSet<uint> m_HaveHadSetIds;

	private Dictionary<uint, SuitOpenInfo> m_DictSuitOpenInfos;

	private List<uint> m_HaveSeenSets;

	private List<CSVBaseData> m_UpgradeConfig;

	private long m_SystemOpenTimeStamp;

	private Dictionary<uint, WeaponSkinUpgradeInfoData> m_WeaponSkinUpgradeInfo;

	private Dictionary<uint, List<WeaponSkinUpgradeInfoData>> m_SortedFeatureByEWeaponPrivilegeType;

	private Dictionary<uint, EvoGunPickItemRedPoint> m_DictNewTipWeaponSetID;

	private List<WeaponEntranceDesc> m_ListWeaponEntranceDesc;

	private Dictionary<uint, proto.WeaponSkinStat> m_DictSetIdToWeaponSkinStat;

	private Dictionary<uint, proto.WeaponSkinStat> m_DictSkinIdToWeaponSkinStat;

	private SortOwnedOrOpenningSkins m_SortOwnedOrOpenningSkins;

	private SkinOwnAndOpenInfo m_CurSkinOwnAndOpenInfo;

	private Dictionary<uint, WeaponSetData> m_WeaponSet;

	private Dictionary<uint, SkinOwnAndOpenInfo> m_DicSkinIDToSkinOwnAdnOpenInfo;

	private Dictionary<uint, uint> m_DictEvoGunVer1ToVer2;

	private List<WeaponSkinUpgradeGratitudeData> m_ListWeaponSkinUpgradeGratitudeData;

	private Dictionary<uint, WeaponSkinUpgradeGratitude> m_DictWeaponSkinUpgradeGratitudeInfo;

	private bool m_CanClaimWeaponSkinUpgradeGratitudeReward;

	private Dictionary<uint, NewMatInfoData> m_DictNewMatInfo;

	private int m_EvoGunRedPointFlag;

	public const int PropID_EvoGunRedPoint_ShareGuidLobby = 2;

	public const int PropID_EvoGunRedPoint_ShareGuidWeaponPopUp = 4;

	public const int PropID_EvoGunRedPoint_ShareGuidEvoGunMainPickItem = 8;

	public const int PropID_EvoGunRedPoint_ShareGuidEvoGunSharePopUp = 16;

	public const int PropID_EvoGunRedPoint_ShareGuidEvoGunShareBtn = 32;

	public const int PropID_GetOpenningSetConfig = 2;

	public const int PropID_UpgradeSuccessd = 4;

	public const int PropID_RefreshHaveHadSkinIds = 8;

	public const int PropID_RefreshUpgradeConfig = 16;

	public const int PropID_UpgradeFail = 32;

	public const int PropID_ExchangeWeaponSkinUpgradeToken = 64;

	public const int PropID_RenameError = 128;

	public const int PropID_RenameSuccess = 256;

	public const int PropID_GetWeaponSkinStat = 512;

	public const int PropID_ChangeWeaponSkinProperty = 1024;

	public const int PropID_GetWeaponEntrance = 2048;

	public const int PropID_GetWeaponSkinUpgradeGratitude = 4096;

	public const int PropID_ClaimWeaponSkinUpgradeGratitudeReward = 8192;

	private bool _003CWeaponSkinStatReady_003Ek__BackingField;

	private bool _003COpenningSetConfigReady_003Ek__BackingField;

	public SkinOwnAndOpenInfo CurSkinOwnAndOpenInfo => null;

	public bool WeaponSkinStatReady
	{
		get
		{
			return _003CWeaponSkinStatReady_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponSkinStatReady_003Ek__BackingField = value;
		}
	}

	public bool OpenningSetConfigReady
	{
		get
		{
			return _003COpenningSetConfigReady_003Ek__BackingField;
		}
		private set
		{
			_003COpenningSetConfigReady_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool CheckObtainCanShow(SkinOwnAndOpenInfo info)
	{
		return false;
	}

	public void GetObtainGoPos(SkinOwnAndOpenInfo info, out uint goPos, out string subGoPos)
	{
		goPos = default(uint);
		subGoPos = null;
	}

	public WeaponSkinUpgradeInfoData GetFeatureInfo(WeaponSkinFeature feature)
	{
		return null;
	}

	public EWeaponPrivilegeType GetEWeaponPreivilegeTypeByWeaponType(EvoWeaponType weaponType, bool isCarsouselList = false)
	{
		return EWeaponPrivilegeType.none;
	}

	public void AnalyseCarouselFeatureInfo(EWeaponPrivilegeType weaponType, Action<WeaponSkinUpgradeInfoData> lambda)
	{
	}

	public WeaponSetData GetWeaponSetData(uint WeaponSetID)
	{
		return null;
	}

	public NewMatInfoData GetNewMatInfoData(uint NewMatType)
	{
		return null;
	}

	public void SetSystemOpenTimeStamp(long systemOpenTimeStamp)
	{
	}

	public void RefreshDictTips()
	{
	}

	public bool HasUnclickedNewSkin()
	{
		return false;
	}

	public EvoGunPickItemRedPoint GetNewRedPointStateByWeaponSetID(uint weaponsetID)
	{
		return null;
	}

	public bool IsSystemOpen()
	{
		return false;
	}

	public void SeeSuitAnimation(uint setId)
	{
	}

	public bool HaveSeenSuitAnimation(uint setId)
	{
		return false;
	}

	public uint GetRealHaveHadSkinId(uint skinId)
	{
		return 0u;
	}

	public uint GetHaveHadSkinInSuit(uint suitId, bool ChangePrivilegeToOrigin = false)
	{
		return 0u;
	}

	public uint GetHaveHadSkinInSameSuit(uint skinId, bool ChangePrivilegeToOrigin = false)
	{
		return 0u;
	}

	public uint GetNextUnhaveSkinInSameSuit(uint skinId, bool ChangePrivilegeToOrigin = false)
	{
		return 0u;
	}

	public WeaponSkinUpgradeConfig GetUpgradeConfigBySkin(uint skinId)
	{
		return null;
	}

	public WeaponSkinUpgradeConfig GetUpgradeConfigByWepaonSet(uint SetId)
	{
		return null;
	}

	public uint GetWeaponSetIdBySkinId(uint skinId)
	{
		return 0u;
	}

	public WeaponSetData GetWeaponSetDataBySkinID(uint skinID)
	{
		return null;
	}

	public uint getTotalNumNeedForHigherLevel(WeaponSkinUpgradeConfig upgradeConfig, uint itemId)
	{
		return 0u;
	}

	public uint GetEmoteRewardByWeaponSkinID(uint weaponSkinID)
	{
		return 0u;
	}

	public uint GetFinalShotRewardByWeaponSkinID(uint weaponSkinID)
	{
		return 0u;
	}

	public uint GetTitleRewardByWeaponSkinID(uint weaponSkinID)
	{
		return 0u;
	}

	public List<SkinOwnAndOpenInfo> GetOwnedOrOpenningSkins(bool toggleOwned = false)
	{
		return null;
	}

	public void SortOwnedOrOpeningSkins(ref List<SkinOwnAndOpenInfo> skinOwnAndOpenInfos, bool toggleOwned)
	{
	}

	private void LoadEvoGunRedPointFlag()
	{
	}

	public void SetEvoGunRedPointFlag(int prop)
	{
	}

	public bool GetEvoGunRedPointFlagHasPorpID(int prop)
	{
		return false;
	}

	public void SetCurOwnAndOpenInfo(SkinOwnAndOpenInfo skinOwnAndOpenInfo)
	{
	}

	public List<WeaponSkinUpgradeInfoData> GetWeaponPrivilegeForItemDescExternalDisplay(uint skinItemId)
	{
		return null;
	}

	public List<WeaponSkinUpgradeInfoData> GetWeaponAllPrivilegeForItemDescTips(uint skinItemId)
	{
		return null;
	}

	public EWeaponPrivilegeType GetEWeaponPrivilegeTypeById(uint weaponid)
	{
		return EWeaponPrivilegeType.none;
	}

	public SkinOwnAndOpenInfo GetOwnAndOpenInfoById(uint skinItemId)
	{
		return null;
	}

	public void GetWeaponFeatures(uint weaponSkinID, ref List<int> features, bool isShowInEvoGunSystem = true)
	{
	}

	public bool IsUnlockSkill(uint skinId)
	{
		return false;
	}

	public bool IsUnlockPowerSwitch(uint skinId)
	{
		return false;
	}

	public bool IsUnlockSkillSwitch(uint skinId)
	{
		return false;
	}

	public uint GetSelfSelectedWeaponSkinIdById(uint weaponSkinId)
	{
		return 0u;
	}

	public uint GetSelectedWeaponSkinIdByIdAndStat(uint weaponSkinId, tcp.WeaponSkinStat stat)
	{
		return 0u;
	}

	public List<uint> GetSuitSkinIdsBySkinId(uint skinItemId)
	{
		return null;
	}

	public List<uint> GetSuitSkinIdsBySuitId(uint suitId)
	{
		return null;
	}

	public bool IsMaxLevelSkin(uint skinId)
	{
		return false;
	}

	public int GetMaxLevelSkin(uint skinId)
	{
		return 0;
	}

	public uint GetMaxLevelSkinBySuitId(uint suitId)
	{
		return 0u;
	}

	public uint GetMinLevelSkinBySuitId(uint suitId)
	{
		return 0u;
	}

	public GoPos GetGoPosWhenOpen(uint skinId)
	{
		return null;
	}

	public bool GetCanUpgradeCauseMaterialEnoughBySkinId(uint skinID)
	{
		return false;
	}

	public void RefreshHaveHadSkinIds()
	{
	}

	public List<ResourceID> GetNeedDownloadResListBySkinId(uint skinId)
	{
		return null;
	}

	public List<WeaponScoreName> GetEVOGunPropertyNameList(uint skinID)
	{
		return null;
	}

	public string GetEvoGunSkillDescByWeaponSkinID(uint weaponSkinID)
	{
		return null;
	}

	public SuitOpenInfo GetSuitOpenInfoDataFromWeaponSetID(uint weaponSetID)
	{
		return null;
	}

	public proto.WeaponSkinStat GetWeaponSkinStatByWeaponSetID(uint weaponSetID)
	{
		return null;
	}

	public proto.WeaponSkinStat GetWeaponSkinStatByWeaponSkinID(uint weaponSkinID)
	{
		return null;
	}

	public void RefreshWeaponSkinStatDict(List<proto.WeaponSkinStat> statList)
	{
	}

	public bool GetWeaponSkinStasBySkinID(uint skinID, out proto.WeaponSkinStat stat)
	{
		stat = null;
		return false;
	}

	public uint GetEvoGunVer2SetIdByVer1SetId(uint ver1SkinId)
	{
		return 0u;
	}

	public bool HasCustomPrivilege(SkinOwnAndOpenInfo info)
	{
		return false;
	}

	public WeaponSkinFeatureShowStyle GetWeaponSkinFeatureShowStyleByFeature(WeaponSkinFeature feature)
	{
		return WeaponSkinFeatureShowStyle.None;
	}

	public bool GetRightsStateInWeaponSkinStatByFeature(SkinOwnAndOpenInfo info, proto.WeaponSkinStat stat, uint feature)
	{
		return false;
	}

	public void GetPropertySkillSkinIDInOwned(SkinOwnAndOpenInfo info, out uint weaponSkinIDInProperty, out uint weaponSkinIDInSkill)
	{
		weaponSkinIDInProperty = default(uint);
		weaponSkinIDInSkill = default(uint);
	}

	public bool HaveHadEvoGunVer2GtLevel(int level)
	{
		return false;
	}

	public uint GetCounterByWeaponSetId(uint weaponSetId, uint condition)
	{
		return 0u;
	}

	public SkinOwnAndOpenInfo GetNextLevelOwnAndInfoDataBySkinID(uint skinID, bool ChangePrivilegeToOrigin = false)
	{
		return null;
	}

	public WeaponEntranceDesc GetWeaponEntranceDesc(uint entrance)
	{
		return null;
	}

	public bool CheckHaveHadWeaponByWeaponSetID(uint weaponSetID)
	{
		return false;
	}

	public void AddWeaponSetToHaveHadSet(uint itemId)
	{
	}

	public bool CheckHaveTheWeaponOrWeaponSet(WeaponSkinData weaponSkinData)
	{
		return false;
	}

	public bool CheckCurrentWeaponHasSpecialGift(uint evoGunVer2SkinID)
	{
		return false;
	}

	public bool CheckCurrentWeaponHasSpecialGift(SkinOwnAndOpenInfo evoGunVer2Info)
	{
		return false;
	}

	public BaseItemInfo GetGratitudeGiftFromWeaponInfo(SkinOwnAndOpenInfo evoGunVer2SkinInfo)
	{
		return null;
	}

	public bool CheckCurrentWeaponIsNeverClaimedSpecialGift(SkinOwnAndOpenInfo skininfo)
	{
		return false;
	}

	public int GetEvoGunLevel(uint weaponSkinID)
	{
		return 0;
	}

	public void ChangeEvoGunPreviewHitEffectIfNoblood(ref ResourceID resourceId)
	{
	}

	private void InitFeatureInThisLevel()
	{
	}

	private void InitWeaponSetData()
	{
	}

	private void InitNewMatInfoData()
	{
	}

	private void LoadUpgradeConfig()
	{
	}

	private void InitFeatureByCarousel()
	{
	}

	private void UpdateWeaponSkinStat(uint skinId, uint nextSkinId)
	{
	}

	private void UpdateWeaponSkinStatInternal(proto.WeaponSkinStat stat, uint nextSkinId)
	{
	}

	private bool CheckWeaponSkinUpgradeGratitudeRewardCanClaim(uint weaponset2ID, uint weaponset1Level)
	{
		return false;
	}

	private void AutoExchangeTokenIfMaxLevelSkin(uint skinId)
	{
	}

	public void GetOpenningSetIds(bool forceRequest = false)
	{
	}

	public void UpgradeWeaponSkin(WeaponSkinData skinData)
	{
	}

	private void UpdateWeaponSysUpgradeTips()
	{
	}

	public void ExchangeWeaponSkinUpgradeToken(List<uint> weaponSkinIds, bool flag = false)
	{
	}

	public void RequestGetWeaponSkinStat(bool sendImmediately = false)
	{
	}

	public void RequestChangeWeaponSkinProperty(proto.WeaponSkinStat stat)
	{
	}

	public bool CheckIsHasNewPrivilegeBySkinId(uint skinId)
	{
		return false;
	}

	public uint GetNewPrivilegeCountBySkinId(uint skinId)
	{
		return 0u;
	}

	public bool CheckIsHasNewPrivilegeByFeatureId(uint featureId)
	{
		return false;
	}

	public string CheckIsCustomCDNWeaponSkin(uint skinId)
	{
		return null;
	}

	private void RequestChangeEvoWeaponSkinProperty(proto.WeaponSkinStat stat, ulong groupId = 0uL, ulong roomId = 0uL)
	{
	}

	private void RequestChangeNotEvoWeaponSkinRights(proto.WeaponSkinStat stat, ulong groupId = 0uL, ulong roomId = 0uL)
	{
	}

	public void RequestGetWeaponEntranceDesc()
	{
	}

	public void RequsestGetWeaponSkinupgradeGratitude(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void ProcessWeaponSkinUpgradeGratitude(List<WeaponSkinUpgradeGratitude> gratitudeInfoList)
	{
	}

	public void RequestClaimWeaponSkinUpgradeGratitudeReward(SkinOwnAndOpenInfo skinOwnAndOpenInfo)
	{
	}

	private int _003CGetWeaponFeatures_003Eb__93_0(int a, int b)
	{
		return 0;
	}

	private void _003CGetOpenningSetIds_003Eb__145_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetWeaponSkinStat_003Eb__149_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetWeaponEntranceDesc_003Eb__157_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequsestGetWeaponSkinupgradeGratitude_003Eb__158_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestClaimWeaponSkinUpgradeGratitudeReward_003Eb__160_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
