using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelNewVault : UIBaseModel
{
	public enum eNewVault_VehicleType
	{
		PickupVehicle = 112,
		JeepVehicle = 113,
		TukTukVehicle = 114,
		AmphibiousVehicle = 115,
		MonsterVehicle = 116,
		MotorVehicle = 117,
		SportVehicle = 118,
		HorseVehicle = 302
	}

	public enum eFirstTab
	{
		None = 0,
		Fashion = 1,
		Accessory = 2,
		Vehicle = 3,
		CallSign = 4,
		Emote = 5,
		Others = 7,
		Posture = 8,
		SkillEffect = 9
	}

	public enum eSecondTab
	{
		None = 0,
		Chest = 10203,
		Legs = 10204,
		Feet = 10205,
		Face = 10208,
		Hair = 10211,
		Set = 10212,
		HeadAdditive = 10214,
		ClothesBundle = 10007,
		OwnClothesSet = 10001,
		LootBox = 20903,
		BackPack = 20904,
		Parachute = 20905,
		Skyboard = 20906,
		Flight = 20911,
		PickupVehicle = 30112,
		JeepVehicle = 30113,
		TukTukVehicle = 30114,
		AmphibiousVehicle = 30115,
		MonsterVehicle = 30116,
		MotorVehicle = 30117,
		SportVehicle = 30118,
		HorseVehicle = 30302,
		Banner = 40901,
		HeadPic = 40902,
		Pin = 40910,
		LoadingCard = 40925,
		Emote = 50909,
		GroupAnim = 50912,
		Music = 60913,
		Transformer = 50914,
		SuperEmote = 50924,
		FinalShot = 50934,
		Mortgage = 70000,
		TreasureBox = 70004,
		Bundle = 70007,
		Debris = 70008,
		BonusCard = 70011,
		ActionJump = 80917,
		ActionUseMedkit = 80918,
		ActionCrossWindow = 80919,
		ActionFallingHigh = 80920,
		SkillEffectTasuya = 80921,
		SkillEffectHomer = 80922,
		SkillEffectWukong = 80923,
		SkillEffectAlok = 80924,
		SkillEffectSonia = 80925,
		SkillEffectOrion = 80926,
		SkillEffectSkyler = 80927,
		FinishMove = 80928
	}

	public enum eNewVaultTag
	{
		None,
		Discount,
		BestSell,
		Latest,
		CountLimit,
		TimeLimit
	}

	public enum eNewVaultGoPosType
	{
		Normal,
		NotHave
	}

	public class NewVaultItemSortInfo
	{
		public uint ID;

		public bool IsOwned;

		public bool IsEquiped;

		public bool IsNewGet;

		public bool IsLoved;

		public bool IsCanEquip;

		public int Quality;

		public bool IsTimeLimit;

		public bool IsDefault;

		public uint SortID;

		public bool IsMultiSelect => false;

		public NewVaultItemSortInfo Clone()
		{
			return null;
		}

		public NewVaultItemSortInfo()
		{
		}

		public NewVaultItemSortInfo(uint id)
		{
		}

		public void RefreshInfo()
		{
		}

		public void RefreshIsLoved()
		{
		}
	}

	public class NewVaultClothSetSortInfo
	{
		public uint SetID;

		public List<uint> LinkSetIDList;

		public uint LikeItemID;

		public bool IsEquiped;

		public bool IsNewGet;

		public bool IsLoved;

		public bool IsCanEquip;

		public int Quality;

		public uint SortID;

		public NewVaultClothSetSortInfo Clone()
		{
			return null;
		}

		public NewVaultClothSetSortInfo(uint setID)
		{
		}

		public void RefreshInfo()
		{
		}

		public void RefreshIsLoved()
		{
		}

		public void RefreshEquiped()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__169_0;

		public static Action<HttpErrorCode, object> _003C_003E9__171_0;

		internal void _003CUploadLovedItemsToServer_003Eb__169_0(HttpErrorCode err, object res)
		{
		}

		internal void _003CUploadClothesSetLovedItemsToServer_003Eb__171_0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass172_0
	{
		public EAccount.ExternalIconShowType externalIconShowType;

		internal void _003CRequestUpdateExternalIconShowType_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_GetNewVault_Success = 2u;

	public const uint PropID_ShowItemChanged = 4u;

	public const uint PropID_GetLovedItems_Success = 8u;

	public const uint PropID_GetClothesSetLovedItems_Success = 16u;

	public const int ESECONDTABENUMCOUNT = 32;

	public const int PLATFORM_HEADPIC_ID = 902040026;

	public const int DEFAULT_HEADPIC_ID = 900000013;

	public bool m_AutoEquipDefaultMusic;

	private uint _003Cm_CurrentMusicDefaultId_003Ek__BackingField;

	private bool m_GetNewDefaultMusicVault;

	private const string LastDefaultMusicIdKey = "LastDefaultMusicIdKey";

	private Dictionary<uint, FirstTabDesc> m_dicTabCfg;

	private Dictionary<uint, SecondTabDesc> m_dicSecondTabCfg;

	private Dictionary<uint, NewVaultDefaultID> m_dicNewVaultDefaultCfg;

	private Dictionary<uint, ResourceID> m_dicSecondTabIconRes;

	private Dictionary<int, uint> m_dicNewVaultDefaultItems;

	private Dictionary<int, uint> m_dicDefaultClothes;

	private HashSet<uint> m_setSeriesClothIds;

	private HashSet<uint> m_hsForceHideFirstTab;

	private HashSet<uint> m_hsForceHideSecondTab;

	private Dictionary<uint, HashSet<uint>> m_LovedItemsServer;

	private Dictionary<uint, HashSet<uint>> m_LovedItemsLocal;

	private bool m_LovedItemsServerReady;

	private bool m_LovedItemsLocalReady;

	private bool m_ClothesSetLovedItemsServerReady;

	private bool m_ClothesSetLovedItemsLocalReady;

	private HashSet<uint> m_ClothesSetLovedItemsServer;

	private HashSet<uint> m_ClothesSetLovedItemsLocal;

	private List<uint> m_lovableSecondTabs;

	private uint m_LoveLimit;

	private List<NewVaultItemDesc> m_NewVaultItemExtraInfo;

	private Dictionary<uint, NewVaultItemDesc> m_dicNewVaultItemExtraInfo;

	private Dictionary<uint, HashSet<uint>> m_dicShowItemInfos;

	private Dictionary<uint, HashSet<uint>> m_dicShowOnlyOwnedItemInfos;

	private Dictionary<uint, NewVaultItemSortInfo> m_dicNewVaultItemSortInfo;

	private Dictionary<uint, NewVaultClothSetSortInfo> m_dicNewVaultItemClothesSetSortInfo;

	private Dictionary<uint, bool> m_dicNewVaultClothesSetIsNewCacheInfo;

	private Dictionary<int, List<int>> m_dicShowTab;

	private List<int> m_sortShowFirstTab;

	private UIModelInventory m_Inventory;

	private bool m_bSortInfoIsDirty;

	public uint m_CurrentPlayLobbyId;

	private bool? PlatformHeadPicNewGetPrefs;

	private string[] m_Regions;

	public bool m_SelectOpenMore;

	public List<int> m_SelectMoreBoxs;

	public static uint MAX_SELECT_TYPE;

	private bool m_SelectMoreTypeInit;

	public const uint MAX_SELECT_COUNT = 99u;

	public bool m_IfContainsSelectMoreBox;

	private NewPlayerGuideData m_EmoteGuide;

	public List<TreasureBoxInfo> m_SelectBoxs;

	private const string HideBackpackKey = "BagShowInLobby";

	private const string HideCSBackpackKey = "CSBagShowInLobby";

	private int m_HideCSBackpack;

	private int m_HideBackpack;

	private Dictionary<uint, CSSharedItemData> m_CompareDataDict;

	public uint m_CurrentMusicDefaultId
	{
		get
		{
			return _003Cm_CurrentMusicDefaultId_003Ek__BackingField;
		}
		private set
		{
			_003Cm_CurrentMusicDefaultId_003Ek__BackingField = value;
		}
	}

	public Dictionary<int, uint> dicNewVaultDefaultItems => null;

	public bool HideBackpack
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HideCSBackpack
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	private void SetSortInfo(uint id, bool? isOwned = null, bool? isEquipped = null, bool? isNewGet = null, bool? isCanEquip = null, bool? isTimeLimit = null, bool? isLoved = null)
	{
	}

	private void SetClothesSetSortInfo(uint id, bool? isLoved = null)
	{
	}

	private int NormalSort(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	private int FinalShotSort(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	private int NormalSortWithMultiSelect(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	private int NormalSortWithMultiSelectByRare(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	private int OwnClothesSetSort(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	public uint GetMultiSelectEquipFirstItemIDInVault(uint subCollection, uint uniqueID, eFirstTab eFirstTab, eSecondTab eSecondTab)
	{
		return 0u;
	}

	private int SelectMoreBoxSort(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	private int SelectMoreSort(NewVaultItemSortInfo CurSortInfo, NewVaultItemSortInfo NextSortInfo, bool OptionalBundleX, bool OptionalBundleY)
	{
		return 0;
	}

	private int SkillEffectSort(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	private int SkillEffectSortWithMultiSelect(uint curItemID, uint nextItemID)
	{
		return 0;
	}

	public bool IsOwned(int id)
	{
		return false;
	}

	public bool IsDefault(int id)
	{
		return false;
	}

	public bool IsEquiped(int id, eSecondTab tab)
	{
		return false;
	}

	public bool IsNewGet(int id)
	{
		return false;
	}

	public bool IsClothesSetNewGet(uint setID)
	{
		return false;
	}

	public bool IsClothesSetEquiped(uint setID)
	{
		return false;
	}

	public bool IsMultiSelect(int id)
	{
		return false;
	}

	public NewVaultItemSortInfo GetSortInfo(uint id)
	{
		return null;
	}

	public NewVaultClothSetSortInfo GetSortInfoForClothesSet(uint id)
	{
		return null;
	}

	public NewVaultItemDesc GetItemExtraInfoById(uint id)
	{
		return null;
	}

	public bool CheckItemShowByItemIDAndSecondId(int secondTabID, int itemID)
	{
		return false;
	}

	public bool CheckSecondTabShowBySecondTabID(int secondTabID)
	{
		return false;
	}

	public bool CheckFirstTabShowByTabID(int firstTabId)
	{
		return false;
	}

	public List<int> GetShowFirstTab()
	{
		return null;
	}

	public List<uint> GetSortedShowItemIdsBySecondTabID(eSecondTab tab, bool box_spcial_sort = false, bool sort = true, eFirstTab eFirstTab = eFirstTab.None, bool isMultiSelectToggleOpen = false)
	{
		return null;
	}

	public List<uint> GetSortedOnlyOwnedShowItemIdsBySecondTabID(eSecondTab tab)
	{
		return null;
	}

	public bool UnOptionalBundleLeft(eSecondTab tab)
	{
		return false;
	}

	public override void Init()
	{
	}

	public void InitAfterLogin()
	{
	}

	private void RefreshSeriesConfig()
	{
	}

	private bool IsHiddenSeriesItem(uint id)
	{
		return false;
	}

	public bool IsNewVaultDefault(int id)
	{
		return false;
	}

	public int NewVaultDefaultID2RealItemID(int id)
	{
		return 0;
	}

	private uint GetCurEquipCloth(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return 0u;
	}

	private uint GetCurEquipVehicle(eNewVault_VehicleType vehicleType)
	{
		return 0u;
	}

	public uint GetCurEquipItemID(int tabID)
	{
		return 0u;
	}

	public void OnBackpackChanged(List<Item> items, bool isTcpNotify)
	{
	}

	private void OnDescChanged()
	{
	}

	private bool IsForceHideByNewVaultCfg(uint id)
	{
		return false;
	}

	private bool IsShowableDebrisInNewVault(uint id)
	{
		return false;
	}

	public eSecondTab GetSecondTabByItemID(uint id)
	{
		return eSecondTab.None;
	}

	public int SecondTabID2FirstTabID(int secondTabID)
	{
		return 0;
	}

	public eSecondTab GetSecondTabByItemID(CSSharedItemData itemData)
	{
		return eSecondTab.None;
	}

	public CSSharedItemDataManager.CollectionSubType GetCollectionSubTypeBySecondTab(eSecondTab secondTab)
	{
		return CSSharedItemDataManager.CollectionSubType.NOTCOLLECTION;
	}

	private CollectionSkillDataManager.CollectionSkills GetCollectionSkillTypeBySecondTab(eSecondTab secondTab)
	{
		return CollectionSkillDataManager.CollectionSkills.None;
	}

	public uint GetCollectionMultiSelectUniqueID(eSecondTab secondTab)
	{
		return 0u;
	}

	public string GetFirstTabName(uint tabID)
	{
		return null;
	}

	public bool IsCanEquipBySecondTab(eSecondTab secondTab)
	{
		return false;
	}

	public uint GetDefaultItemIDByNewVaultSecondTab(eSecondTab secondTab)
	{
		return 0u;
	}

	public uint GetDefaultClothesIDByNewVaultSecondTab(eSecondTab secondTab)
	{
		return 0u;
	}

	public void ProcessServerTabData(List<FirstTabDesc> firstTabList, List<SecondTabDesc> secondTabList)
	{
	}

	private void ProcessIOSReviewHideTabs()
	{
	}

	private void InitDefaultItemCfg()
	{
	}

	private void InitTabCfg()
	{
	}

	private bool CheckForceHideFirstTabByTabID(uint tabID)
	{
		return false;
	}

	public bool CheckForceHideSecondTabByTabID(uint tabID)
	{
		return false;
	}

	public void ProcessNewVaultDefaultMusicCfg(SkinTimelineDesc data)
	{
	}

	public void UpdateLobbyMusic(bool isIPMusic, bool changeDataOnly = false)
	{
	}

	public void UpdateLobbyBGMAfterGetMusicSlotData()
	{
	}

	private bool IsCheckSendAutoEquipDefault()
	{
		return false;
	}

	private void RequesetEquipDefaultMusic()
	{
	}

	public void SetAutoEquipMusic(bool value)
	{
	}

	private void RefreshShowTabList()
	{
	}

	private int SecondTabPriorityCompare(int cur, int next)
	{
		return 0;
	}

	public Dictionary<int, List<int>> GetmShowTab()
	{
		return null;
	}

	public void UpdateShowItemSpecial(Item item, EUpdateItemOperate operate)
	{
	}

	private void UpdateShowItemInventoryAndCfg(List<Item> items, bool isTcpNotify = false)
	{
	}

	private void SetAllClothesSetItemInfos()
	{
	}

	private void SetOwnedClothesSetItemInfos(List<uint> ownedClothesSetIds)
	{
	}

	private void RefreshOwnedClothesSetSortInfos(HashSet<uint> clothesSetHashSet)
	{
	}

	private void SetNotifyClothesSetItemInfos(List<Item> items)
	{
	}

	private void SetClothesBundleItemInfos()
	{
	}

	private void UpdateDictByOperate(Dictionary<uint, HashSet<uint>> dict, uint id, uint tab, bool isTcpNotify, EUpdateItemOperate operate, bool needCheckForceDisplay)
	{
	}

	private bool IsOwnedShowByNewVaultCfg(uint id)
	{
		return false;
	}

	public void RefreshAllSortInfo()
	{
	}

	public void RefreshSortInfoBySecondTab(eSecondTab secondTab)
	{
	}

	public void RefreshSortInfoForClothesSetBySecondTab(bool isOnlyRefreshEquiped = false)
	{
	}

	public int GetTabPriority(uint tabID)
	{
		return 0;
	}

	public int GetSecondTabPriority(uint tabID)
	{
		return 0;
	}

	public List<int> GetSecondTabsIDByFirstTabID(int firstTabID)
	{
		return null;
	}

	public ResourceID GetSecondTabDefaultIconID(uint SecondTabID)
	{
		return default(ResourceID);
	}

	public int GetSecondTabCount(uint secondTabId)
	{
		return 0;
	}

	public int GetSecondTabCountModifier(uint secondTabId)
	{
		return 0;
	}

	public int GetSecondTabIsNeedFilter(uint secondTabId)
	{
		return 0;
	}

	public bool IsShowTipByFirstTabID(uint firstTabID)
	{
		return false;
	}

	public bool IsShowTipBySecondtTabID(uint secondTabID)
	{
		return false;
	}

	public void UpdateNewGetByInventory(uint id)
	{
	}

	public void CloseTipBySecondTab(int secondTabID)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestAllNewVault(LoadingType loadingType = LoadingType.CircleLoading, bool sendImmediately = false)
	{
	}

	public void RequestLovedItemsFromServer(LoadingType loadingType = LoadingType.CircleLoading, bool sendImmediately = false)
	{
	}

	public void UploadLovedItemsToServer()
	{
	}

	public void RequestClothesSetLovedItemsFromServer(LoadingType loadingType = LoadingType.CircleLoading, bool sendImmediately = false)
	{
	}

	public void UploadClothesSetLovedItemsToServer()
	{
	}

	public void RequestUpdateExternalIconShowType(EAccount.ExternalIconShowType externalIconShowType)
	{
	}

	public void GetTreasureBoxMaxNum(bool sendImmediately = false)
	{
	}

	public void OnClothesChanged()
	{
	}

	public void OnCollectionChanged()
	{
	}

	private List<uint> FilterLovedItems(uint secondTab)
	{
		return null;
	}

	private void ResetLovedDictionary(Dictionary<uint, HashSet<uint>> dict)
	{
	}

	private void InitLovableSecondTabs()
	{
	}

	public int TabStarItemInfoComparison(TabStarItemInfo x, TabStarItemInfo y)
	{
		return 0;
	}

	private void SyncLovedItems()
	{
	}

	private void SyncClothesSetLovedItems()
	{
	}

	public bool IsLovedItem(uint id)
	{
		return false;
	}

	public bool IsLovedClothesSet(uint id)
	{
		return false;
	}

	public bool SetItemLovedStatues(uint id, bool newStatus, out List<uint> filteredIDs)
	{
		filteredIDs = null;
		return false;
	}

	public bool SetClothesSetLovedStatues(uint id, bool newStatus)
	{
		return false;
	}

	public List<uint> GetAllLovedItems(bool fromLocal = true)
	{
		return null;
	}

	public List<uint> GetAllClothesSetLovedItems(bool fromLocal = true)
	{
		return null;
	}

	public bool ShowPlatformHeadPicSwitch()
	{
		return false;
	}

	public bool GetPlatformHeadPicNewGetPrefs()
	{
		return false;
	}

	public void SetPlatformHeadPicNewGetPrefs()
	{
	}

	public bool CheckExternalIconCheckboxBtnCanShow()
	{
		return false;
	}

	public void SetSelectMoreBox(int itemId)
	{
	}

	public uint GetMultiSelectFirstItemInDressUp(uint subCollection)
	{
		return 0u;
	}

	public eSecondTab GetSecondTabNyCollectionSubType(uint collectionSubType)
	{
		return eSecondTab.None;
	}

	public bool ClothesSetIsEquipBySetIDAndLinkSetIDList(uint SetID, List<uint> LinkSetIDList)
	{
		return false;
	}

	public uint GetEquipedSetIdByLikeItemID(uint likeItemID)
	{
		return 0u;
	}

	public bool ClothesSetIsEquipBySetID(uint SetID)
	{
		return false;
	}

	private bool ClothesSetIsNewGetBySetID(uint SetID)
	{
		return false;
	}

	public void RefreshClothesSetIsEquiped(uint setID)
	{
	}

	public uint GetCurrentEquipedClothesLikeItemID()
	{
		return 0u;
	}

	private bool CheckIsClothesSetNewGet()
	{
		return false;
	}

	public void ClearClothesSetIsNewGetCache()
	{
	}

	public void RemoveClothesSetIsNewGetCache(uint setID)
	{
	}

	public bool CheckIsClothesSexValid(uint ItemID)
	{
		return false;
	}

	public bool CheckEquipedGuideEmote()
	{
		return false;
	}

	private int _003CRefreshShowTabList_003Eb__140_0(int cur, int next)
	{
		return 0;
	}

	private void _003CRequestAllNewVault_003Eb__167_0(HttpErrorCode err, object res)
	{
	}

	private void _003CRequestLovedItemsFromServer_003Eb__168_0(HttpErrorCode err, object res)
	{
	}

	private void _003CRequestClothesSetLovedItemsFromServer_003Eb__170_0(HttpErrorCode err, object res)
	{
	}

	private void _003CGetTreasureBoxMaxNum_003Eb__173_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
