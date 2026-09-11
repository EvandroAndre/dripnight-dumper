using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class CollectionDataManager : SingletonModule<CollectionDataManager>, IUIModelDataChangeObserver
{
	public enum ECallSignSourceType
	{
		All,
		Avatar,
		Events,
		LadderMatch,
		Mall,
		ElitePass
	}

	public enum ECollectionWeaponType
	{
		fist = 0,
		rifle = 1,
		sniper = 2,
		handGun = 3,
		subMachineGun = 4,
		shotGun = 5,
		melee = 6,
		grenade = 7,
		others = 8,
		designatedmarksmanrifle = 9,
		lightmachinegun = 10,
		max = 11,
		all = 99
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<EmoteData> _003C_003E9__87_1;

		public static Comparison<TransformData> _003C_003E9__87_2;

		internal int _003CLoadCSVData_003Eb__87_1(EmoteData a, EmoteData b)
		{
			return 0;
		}

		internal int _003CLoadCSVData_003Eb__87_2(TransformData a, TransformData b)
		{
			return 0;
		}
	}

	public const int WeaponID_Fist = 1;

	public const int WeaponID_Pan = 16;

	public const int WeaponID_Machete = 17;

	public const int WeaponID_BaseballPole = 27;

	public const int WeaponID_Katana = 34;

	public const int WeaponID_Sickle = 51;

	public const int WeaponID_Throwing_Knife = 53;

	public const int WeaponID_Grenade = 601;

	public const int WeaponID_Smoke_Grenade = 603;

	public const int WeaponID_Ice_Wall = 1201;

	private Dictionary<uint, BannerData> m_dictIdToBannerData;

	private Dictionary<uint, HeadPicData> m_dictIdToHeadPicData;

	private Dictionary<uint, LootBoxData> m_dictIdToLootBoxData;

	private Dictionary<uint, BackPackData> m_dictIdToBackPackData;

	private Dictionary<uint, ParachuteData> m_dictIdToParachuteData;

	private Dictionary<uint, FlightData> m_dictIdToFlightData;

	private Dictionary<uint, SkyboardData> m_dictIdToSkyboardData;

	private Dictionary<uint, WeaponSkinData> m_dictIdToWeaponSkinData;

	private Dictionary<uint, FinalShotData> m_dictIdToFinalShotData;

	private CSVAsyncDataMap<uint, WeaponPrivilegeSkinConfig> m_dictIdToWeaponPrivilegeSkinConfig;

	private Dictionary<uint, List<uint>> m_dictIdToCanUpgradeWeaponSkinSeriesData;

	private List<CollectionWeaponExt> m_CollectionWeaponExtArray;

	private Dictionary<uint, VehicleSkinData> m_dictIdToVehicleSkinData;

	private Dictionary<uint, EmoteData> m_dictIdToEmoteData;

	private CSVAsyncDataMap<uint, CollectionSuperEmote> m_dictIdToSuperEmote;

	private CSVAsyncDataMap<uint, CooperateEmoteData> m_dictIdToCooperateEmote;

	private CSVAsyncDataMap<uint, SocialLobbyDancingTemplate> m_dictIdToSocialLobbyDancing;

	private CSVAsyncDataMap<uint, SocialHallDanceSetting> m_dictIdToSocialHallDanceSetting;

	private CSVAsyncDataMap<uint, SocialHallArenaSetting> m_dictIdToSocialHallArenaSetting;

	private Dictionary<uint, List<uint>> m_dictSetIdToCooperateEmote;

	private Dictionary<uint, TransformData> m_dictIdToTransformData;

	private Dictionary<uint, GroupAnimData> m_dictIDToGroupAnimData;

	private Dictionary<uint, CollectionActionData> m_dictIdToCollectionActionData;

	private Dictionary<uint, List<CollectionActionData>> m_dictCollectionTypeToListActionData;

	private Dictionary<uint, CollectionGuideData> m_DictGuideData;

	private Dictionary<uint, WeaponEffectConfigData> m_dictIdToWeaponEffectData;

	private Dictionary<uint, MusicData> m_dictIdToMusicData;

	private Dictionary<uint, PinData> m_PinDataDict;

	private Dictionary<uint, TitleData> m_dicIdToTitleData;

	private Dictionary<uint, CollectionQuickChatData> m_dicIdToQuickChatData;

	private Dictionary<int, int> m_DictTabPriority;

	private List<EmoteData> m_ListSourceEmoteData;

	private List<TransformData> m_ListSourceTransformData;

	private Dictionary<uint, Dictionary<uint, List<WeaponSkinData>>> m_DictWeaponDataSortedByType;

	private List<uint> m_WeaponTypeList;

	private List<uint> m_WeaponIdList;

	private Dictionary<uint, uint> m_dictWeaponIdToWeaponType;

	private List<WeaponScoreName> m_WeaponScoreNameList;

	private Dictionary<uint, WeaponPropertyScore> m_dictIdToWeaponScore;

	private Dictionary<uint, WeaponSkinPropertyScore> m_dictIdToWeaponSkinScore;

	private Dictionary<uint, VehicleSkinPropertyScoreData> m_dictIdToVehicleSkinScore;

	private Dictionary<uint, WeaponSkinPropertyScore> m_dictIdToPVEWeaponSkinScore;

	private Dictionary<string, uint> m_WeaponScoreConfig;

	private Dictionary<uint, Dictionary<uint, uint>> m_DicItemIdToHackProperty;

	private Dictionary<uint, Dictionary<uint, uint>> m_DicPveItemIdToHackProperty;

	private Dictionary<uint, Dictionary<uint, uint>> m_DicWeaponIdToHackProperty;

	private List<WeaponSkinPropertyScore> m_WeaponSkinPropertyScoreListTemp;

	private List<WeaponSkinPropertyScore> m_PVEWeaponSkinPropertyScoreListTemp;

	private List<uint> m_VehicleIdList;

	private Dictionary<uint, List<VehicleSkinData>> m_DictSortedVehicleSkinDataByVehicleID;

	private CSVAsyncDataMap<uint, CollectionLoadingCardData> m_DicLoadingCardData;

	private CSVAsyncDataMap<uint, CollectionAvatarFrameData> m_DicAvatarFrameData;

	private CSVAsyncDataMap<uint, FinalShotSkinUpgradeInfoData> m_DicFinalShotSkinUpgradeInfo;

	private List<uint> m_AlwaysDisplayProperty;

	private List<uint> m_IceWallDisplayProperty;

	private UIModelLogin m_ModelLogin;

	private UIModelInventory m_ModelInventory;

	private UIModelClan m_ModelClan;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelCollection m_ModelCollection;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelUser m_ModelUser;

	private List<ResourceID> m_resourceIDList;

	public List<WeaponScoreName> WeaponScoreNameList()
	{
		return null;
	}

	public Dictionary<string, uint> GetWeaponScoreConfigDict()
	{
		return null;
	}

	public List<uint> GetAlwaysDisplayProperty()
	{
		return null;
	}

	public List<EmoteData> GetSourceEmoteData()
	{
		return null;
	}

	public List<uint> GetAllWeaponIds()
	{
		return null;
	}

	public List<WeaponSkinData> GetWeaponSkinDataListByWeaponId(uint wpId)
	{
		return null;
	}

	public List<uint> GetAllVehicleIds()
	{
		return null;
	}

	public List<VehicleSkinData> GetVehicleSkinDataListByVehicleId(uint wpId)
	{
		return null;
	}

	public void MultiThreadLoad(object o)
	{
	}

	public void MultiThreadInit()
	{
	}

	protected override void OnInit()
	{
	}

	public void LoadCSVData()
	{
	}

	public bool GetCollectionWeaponExtByIndex(int index, out CollectionWeaponExt result)
	{
		result = null;
		return false;
	}

	public void LoadCollectionGuideData()
	{
	}

	private uint GetDictGuidDataKey(uint type, uint subType, uint collectionType)
	{
		return 0u;
	}

	protected override void OnCleanup()
	{
	}

	public void LoadWithRegion()
	{
	}

	private void LoadSkinConfig()
	{
	}

	private void parseSkinPropertyScoreCfg(ResourceID cfgId, Dictionary<uint, WeaponSkinPropertyScore> cfgDic)
	{
	}

	private void ProcessHackSkinProperty()
	{
	}

	private Dictionary<uint, Dictionary<uint, uint>> ProcessHackProperty(Dictionary<uint, WeaponSkinPropertyScore> weaponSkinScores)
	{
		return null;
	}

	private Dictionary<uint, Dictionary<uint, uint>> ProcessHackProperty(Dictionary<uint, WeaponPropertyScore> weaponScores)
	{
		return null;
	}

	public uint GetHackProperty(uint skinId, uint scoreId)
	{
		return 0u;
	}

	public uint GetPveHackProperty(uint skinId, uint scoreId)
	{
		return 0u;
	}

	public uint GetWeaponHackProperty(uint weaponId, uint scoreId)
	{
		return 0u;
	}

	private void WeaponSkinPropertyScoreFilter(List<WeaponSkinPropertyScore> sources, ref Dictionary<uint, WeaponSkinPropertyScore> targets)
	{
	}

	protected override void OnUnloadMemeory()
	{
	}

	protected override void OnReloadMemory()
	{
	}

	public Dictionary<uint, TitleData> GetAllTitleData()
	{
		return null;
	}

	public BannerData FindBannerDataById(uint iid)
	{
		return null;
	}

	public ResourceID FindInGameWeaponEffectByWeaponId(uint weaponSkinId)
	{
		return default(ResourceID);
	}

	public HeadPicData FindHeadPicDataById(uint iid)
	{
		return null;
	}

	public HeadPicData FindHeadPicDataById(uint iid, ulong accountId, string external_icon, EAccount.ExternalIconStatus status, EAccount.ExternalIconShowType show_type)
	{
		return null;
	}

	public HeadPicData GetDefaultHeadPicData()
	{
		return null;
	}

	public LootBoxData FindLootBoxDataById(uint iid)
	{
		return null;
	}

	public BackPackData FindBackPackDataById(uint iid)
	{
		return null;
	}

	public ParachuteData FindParachuteDataById(uint iid)
	{
		return null;
	}

	public FlightData FindFlightDataById(uint id)
	{
		return null;
	}

	public bool CanFlightPrivilegePreview(uint id)
	{
		return false;
	}

	public CollectionLoadingCardData FindLoadingCardDataByID(uint id)
	{
		return null;
	}

	public CollectionAvatarFrameData FindAvatarFrameDataByID(uint id)
	{
		return null;
	}

	public CSVAsyncDataMap<uint, CollectionAvatarFrameData> GetAllAvatarFrameData()
	{
		return null;
	}

	public FinalShotSkinUpgradeInfoData GetFinalShotSkinUpgradeInfoDataByFinalShotId(uint finalShotId)
	{
		return null;
	}

	public Dictionary<uint, SkyboardData> GetAllSkyboardData()
	{
		return null;
	}

	public Dictionary<uint, BannerData> GetAllBannerData()
	{
		return null;
	}

	public Dictionary<uint, HeadPicData> GetAllHeadPicData()
	{
		return null;
	}

	public List<uint> GetCollectionResIdsByType(CSSharedItemDataManager.CollectionSubType subType)
	{
		return null;
	}

	public SkyboardData FindSkyboardDataById(uint iid)
	{
		return null;
	}

	public Dictionary<uint, WeaponSkinData> GetAllWeaponSkinData()
	{
		return null;
	}

	public WeaponSkinData GetAWeaponSkinByWeaponId(uint weaponId)
	{
		return null;
	}

	public WeaponSkinData FindWeaponSkinDataById(uint iid)
	{
		return null;
	}

	public WeaponPrivilegeSkinConfig FindWeaponPrivilegeSkinConfigById(uint weaponSkinID)
	{
		return null;
	}

	public ECollectionWeaponType FindWeaponTypeByWeaponId(uint iid)
	{
		return ECollectionWeaponType.fist;
	}

	public bool CanWeaponSkinPrivilegePreview(uint id)
	{
		return false;
	}

	public bool IsOrangePlusWeapon(uint id)
	{
		return false;
	}

	public bool IsPrivilegeFinalShot(uint id)
	{
		return false;
	}

	public bool IsMaterielWeapon(uint id)
	{
		return false;
	}

	public VehicleSkinPropertyScoreData FindVehicleSkinPropertyScoreDataById(uint iid)
	{
		return null;
	}

	public List<uint> FindWeaponSkinSuitByItemId(uint iid)
	{
		return null;
	}

	public List<uint> FindWeaponSkinSuitBySuitId(uint suitId)
	{
		return null;
	}

	public List<uint> GetWeaponSkinsCanUpgrade()
	{
		return null;
	}

	public WeaponPropertyScore FindWeaponScoreById(uint iid)
	{
		return null;
	}

	public List<uint> GetAllDisplayWeaponProperty(uint id)
	{
		return null;
	}

	public List<uint> GetIceWallDisplayWeaponProperty()
	{
		return null;
	}

	public WeaponSkinPropertyScore FindPVEWeaponScoreById(uint iid)
	{
		return null;
	}

	public bool HasWeaponSkinProperty(uint itemid)
	{
		return false;
	}

	public bool NeedShowWeaponPropertyInFrontEndPreview(uint itemid, uint weaponId)
	{
		return false;
	}

	public WeaponSkinPropertyScore FindWeaponSkinScoreById(uint iid)
	{
		return null;
	}

	public VehicleSkinData FindVehicleSkinDataById(uint iid)
	{
		return null;
	}

	public PinData FindPinDataById(uint pinId)
	{
		return null;
	}

	public MusicData FindMusicDataById(uint pinId)
	{
		return null;
	}

	public TitleData FindTitleDataById(uint iid)
	{
		return null;
	}

	public FinalShotData FindFinalShotDataById(uint iid)
	{
		return null;
	}

	public List<FinalShotData> GetAllFinalShotData()
	{
		return null;
	}

	public bool CanFinalShotPrivilegePreview(uint id)
	{
		return false;
	}

	public Dictionary<uint, MusicData> FindAllMusicData()
	{
		return null;
	}

	public Dictionary<uint, EmoteData> GetEmoteDataMap()
	{
		return null;
	}

	public EmoteData FindEmoteDataById(uint iid)
	{
		return null;
	}

	public CollectionSuperEmote FindSuperEmoteDataById(uint itemID)
	{
		return null;
	}

	public CooperateEmoteData FindCooperateEmoteDataById(uint itemId)
	{
		return null;
	}

	public void LoadSocialLobbyDancingData()
	{
	}

	public void UnloadSocialLobbyDancingData()
	{
	}

	public SocialLobbyDancingTemplate FindSocialLobbyDancingById(uint itemId)
	{
		return null;
	}

	public List<SocialLobbyDancingTemplate> GetAllSocialLobbyDancingData()
	{
		return null;
	}

	public void LoadSocialHallDanceSetting()
	{
	}

	public void UnLoadSocialHallDanceSetting()
	{
	}

	public uint GetSocialHallDanceTitleMinTime()
	{
		return 0u;
	}

	public void LoadSocialHallArenaSetting()
	{
	}

	public void UnLoadSocialHalllArenaSetting()
	{
	}

	public uint GetSocialHallArenaTitleWinStreak()
	{
		return 0u;
	}

	public List<uint> FindCooperateEmoteIdBySetID(uint setID)
	{
		return null;
	}

	public TransformData FindTransformDataById(uint iid)
	{
		return null;
	}

	public GroupAnimData FindGroupAnimDataById(uint iid)
	{
		return null;
	}

	public WeaponEffectConfigData FindWeaponEffectConfigDataById(uint iid)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private ECollectionType ToCollectionType(CSSharedItemDataManager.CollectionSubType subType)
	{
		return ECollectionType.None;
	}

	public int GetWeaponTypeSort(ECollectionWeaponType type)
	{
		return 0;
	}

	public bool IsCurrentRegion(string regions)
	{
		return false;
	}

	public bool IsCurrentRegionGCFree(string regions)
	{
		return false;
	}

	public bool IsCurrentRegionOri(string regionString)
	{
		return false;
	}

	private void InitCollectionTypeToListActionData()
	{
	}

	public void FindAllActionDataByCollectionType(ref List<CollectionActionData> listData, ECollectionType type)
	{
	}

	public void FindAllActionIdByCollectionType(ref List<uint> listID, ECollectionType type)
	{
	}

	public CollectionActionData FindActionDataByItemID(uint itemID)
	{
		return null;
	}

	public CollectionQuickChatData GetQuickChatDataByItemID(uint itemID)
	{
		return null;
	}

	public ResourceID GetQuickChatResIdByItemID(uint itemID)
	{
		return default(ResourceID);
	}

	public CollectionGuideData FindGuideDataByType(uint typeID = 0u, uint subTypeID = 0u, uint collectionTypeID = 0u)
	{
		return null;
	}

	private int _003CLoadCSVData_003Eb__87_0(uint x, uint y)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUnloadMemeory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnReloadMemory()
	{
	}
}
