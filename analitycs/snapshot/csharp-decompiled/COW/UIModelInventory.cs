using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelInventory : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__119_0;

		public static Comparison<LegendClothPrivilege> _003C_003E9__129_0;

		public static Comparison<Item> _003C_003E9__160_0;

		public static Comparison<Item> _003C_003E9__160_1;

		public static Comparison<Item> _003C_003E9__160_2;

		public static Converter<BundleShowData, uint> _003C_003E9__205_0;

		public static Converter<BundleShowData, uint> _003C_003E9__223_0;

		public static Predicate<Item> _003C_003E9__259_0;

		public static Predicate<Item> _003C_003E9__260_0;

		public static Predicate<Item> _003C_003E9__261_0;

		public static Predicate<Item> _003C_003E9__262_0;

		public static Predicate<Item> _003C_003E9__263_0;

		public static Predicate<Item> _003C_003E9__264_0;

		public static Predicate<Item> _003C_003E9__265_0;

		public static Predicate<Item> _003C_003E9__266_0;

		public static Predicate<Item> _003C_003E9__268_0;

		public static Predicate<Item> _003C_003E9__269_0;

		internal void _003CRequestWallet_003Eb__119_0(HttpErrorCode errorCode, object res)
		{
		}

		internal int _003CGetLegendClothPriviledgeList_003Eb__129_0(LegendClothPrivilege x, LegendClothPrivilege y)
		{
			return 0;
		}

		internal int _003CUpdateInventoryItems_003Eb__160_0(Item a, Item b)
		{
			return 0;
		}

		internal int _003CUpdateInventoryItems_003Eb__160_1(Item a, Item b)
		{
			return 0;
		}

		internal int _003CUpdateInventoryItems_003Eb__160_2(Item a, Item b)
		{
			return 0;
		}

		internal uint _003CGetCurOwnedUponOrangeItemNumShowInImageShare_003Eb__205_0(BundleShowData i)
		{
			return 0u;
		}

		internal uint _003CBundleContainsItemAllOwned_003Eb__223_0(BundleShowData item)
		{
			return 0u;
		}

		internal bool _003CGetValidCSRankNoDeductItem_003Eb__259_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidRankTimesRPCardItem_003Eb__260_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidRankNoDeductCardItem_003Eb__261_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidBRDoubleBonusCardItem_003Eb__262_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidBRDoubleBonusCardItemList_003Eb__263_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidCSDoubleBonusCardItem_003Eb__264_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidCSDoubleBonusCardItemList_003Eb__265_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidRankNoDeductCardItemList_003Eb__266_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidRankTiemsRPCardItemList_003Eb__268_0(Item t)
		{
			return false;
		}

		internal bool _003CGetValidCSRankNoDeductItemList_003Eb__269_0(Item t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public ulong currentTime;

		internal bool _003CRequestBackpack_003Eb__0(Item item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public UIModelInventory _003C_003E4__this;

		public bool refreshAll;

		internal void _003CRequestLegendClothDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public ulong currentTime;

		public UIModelEvoPass modelEvoPass;

		internal bool _003CIsPrivilegeWeaponExpired_003Eb__0(Item item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass164_0
	{
		public Item it;

		internal bool _003CUpdateBackpackAvatar_003Eb__0(uint a)
		{
			return false;
		}

		internal bool _003CUpdateBackpackAvatar_003Eb__1(uint a)
		{
			return false;
		}

		internal bool _003CUpdateBackpackAvatar_003Eb__2(CSSharedAvatarData i)
		{
			return false;
		}

		internal bool _003CUpdateBackpackAvatar_003Eb__3(CSSharedAvatarData i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass165_0
	{
		public Item it;

		internal bool _003CUpdateBackpackClothes_003Eb__0(InventoryClothInfo i)
		{
			return false;
		}

		internal bool _003CUpdateBackpackClothes_003Eb__1(InventoryClothInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass166_0
	{
		public Item item;

		internal bool _003CUpdateItemToListByOperate_003Eb__0(Item i)
		{
			return false;
		}

		internal bool _003CUpdateItemToListByOperate_003Eb__1(Item i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass207_0
	{
		public uint iid;

		internal bool _003CGetExpiredItemByID_003Eb__0(PermanentValueItem item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass217_0
	{
		public AvatarWardrobeData cloth;

		internal bool _003CUpdateClothNewOwnedState_003Eb__0(InventoryClothInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public ItemChannelInfo channel;

		internal bool _003CGetTokenUseChannelInfos_003Eb__0(ItemChannelInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass252_0
	{
		public Item item;

		internal bool _003CGetValidRankTimesRPCardData_003Eb__0(RankCardData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass254_0
	{
		public ulong curTime;

		internal bool _003CGetValidBRRankNoDropDivisionCardItemList_003Eb__0(Item t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass258_0
	{
		public ulong curTime;

		internal bool _003CGetValidCSRankNoDropDivisionCardItemList_003Eb__0(Item t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass301_0
	{
		public UIModelInventory _003C_003E4__this;

		public List<uint> sendItemlist;

		internal void _003CRequestListItemChannelinfo_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	public const uint PropID_InventoryBagpack = 2u;

	public const uint PropID_InventoryNew = 4u;

	public const uint PropID_InventoryBagpackChanged = 8u;

	public const uint PropID_InventoryTopupNotification = 16u;

	public const uint PropID_InventoryFetchLegendClothDesc = 128u;

	public const uint PropID_InventoryChooseLoadout = 256u;

	public const uint PropID_InventoryChooseLoadoutFailed = 512u;

	public const uint PropID_GetItemSourcesByItemIDsSucess = 1024u;

	public const uint PropID_GetTokenSourcesByItemIDsSucess = 2048u;

	public const uint PropID_LaunchTagServerNumberUpdate = 4096u;

	public const uint propID_LaunchTagObtain = 8192u;

	private bool m_isLogin;

	private bool purchase_flag;

	public const string NORMAL_LOADOUT_GUIDE_KEY = "normal_loadout_guide";

	public const string ADVANCE_LOADOUT_GUIDE_KEY = "advance_loadout_guide";

	private bool m_IsIPMusicValid;

	private uint m_CurrentFindID;

	private Dictionary<int, ETipsType> InvTypeToTipsMap;

	public Dictionary<int, ETipsType> clothTypeToTipsMap;

	public Dictionary<uint, SkinTimelineDesc> SkinTimelineDescMap;

	private Dictionary<ulong, uint> m_DicIdToSeasonLimitedData;

	private Dictionary<uint, uint> m_DicIdToMatchMode;

	public List<uint> PlayedAnimItem;

	private CSGetBackpackRes _003CBackpackData_003Ek__BackingField;

	private Item[] _003CNewInventories_003Ek__BackingField;

	private string m_StrWeaponPropertyChangePlayerPrefersKey;

	private List<uint> m_ListPlayerClickedChangedWeaponID;

	private Dictionary<int, ResourceID> m_dictBGMPath;

	private Dictionary<uint, InventoryItemInfo> m_dicCacheNewInventories;

	public Dictionary<uint, Dictionary<uint, LegendClothUnlockDesc>> DictLegendClothLevelConfigs;

	private uint m_SelectedLoadoutId;

	private uint m_SelectedLoadoutV2;

	private Dictionary<int, List<CSSharedAvatarData>> m_DictBackpackAvatar;

	private Dictionary<int, List<InventoryClothInfo>> m_DictBackpackCloth;

	private Dictionary<uint, Item> m_DictFaceInfo;

	private Dictionary<uint, Item> m_DictClothInfo;

	private Dictionary<uint, Item> m_DictLoadoutInfo;

	private Dictionary<uint, Item> m_DictTreasureBoxInfo;

	private Dictionary<uint, Item> m_DictDebrisInfo;

	private Dictionary<uint, Item> m_DictBundleInfo;

	private Dictionary<uint, Item> m_DictExchangeCurrency;

	private bool m_OwnedBundleClothesSetItemsDirty;

	private List<uint> m_OwnedBundleClothesSetItems;

	private HashSet<uint> m_OwnedBundleClothesItemIdsSet;

	private HashSet<uint> m_OwnedBundleClothesSetIdsSet;

	private Dictionary<uint, Item> m_DictGrowthCardInfo;

	private Dictionary<uint, Item> m_DictRoomCardInfo;

	private readonly List<Item> m_BRRankTimesRPCardList;

	private readonly List<Item> m_BRRankNoDeductCardList;

	private readonly List<Item> m_CSRankNoDeductCardList;

	private readonly List<Item> m_BRDoubleBonusCardList;

	private readonly List<Item> m_CSDoubleBonusCardList;

	private List<Item> m_BRRankNoDropDivisionCardList;

	private List<Item> m_CSRankNoDropDivisionCardList;

	private Dictionary<uint, Item> m_dicAllBackPackIter;

	private HashSet<uint> m_BackpackItemIDCache;

	private List<uint> m_ExpireItemIDCache;

	private List<Item> m_SortedLoadoutList;

	private List<Item> m_SortedGrowthCardList;

	private List<Item> m_PlayCardList;

	private List<Item> m_ShowInInventoryPropList;

	private HashSet<uint> m_SelectedSlots;

	private List<InventoryTopupNtf> _TopupNotifications;

	private List<int> m_PendingRequest;

	private List<Item> m_PlayItemLimitedCardList;

	private List<Item> m_GachaCouponList;

	private List<Item> m_DrawShopCouponList;

	private List<uint> m_CacheLimitAvatar;

	private readonly Dictionary<uint, BonusCardDesc> m_BonusCardDescDict;

	private readonly Dictionary<uint, ItemNumLimitDesc> m_ItemNumLimitDescDict;

	private Dictionary<uint, List<ItemCheckSummaryDesc>> m_ItemSourcesDict;

	private HashSet<uint> m_HasRequestedButNoInfosItemId;

	private Dictionary<uint, List<ItemConsumeSummaryDesc>> m_TokenUseChannelDict;

	private Dictionary<uint, ConsumeGoposSummaryDesc> m_TokenGoposDict;

	private ProtoGetBackpackCache m_ProtoGetBackpackCache;

	private uint _003CChipCount_003Ek__BackingField;

	public bool NeedShowLegendVaultColorTip;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private uint m_CoinsLimitOutGameWeekly;

	private Dictionary<uint, TCPUpdateItemInfo> m_TcpUpdateItemInfoDict;

	public const int BACKPACK_DATA_SLOTS_INDEX_LootBox = 0;

	public const int BACKPACK_DATA_SLOTS_INDEX_BackPack = 1;

	public const int BACKPACK_DATA_SLOTS_INDEX_Parachute = 2;

	public const int BACKPACK_DATA_SLOTS_INDEX_Skyboard = 3;

	public bool HasGetBackPackInfo;

	private Dictionary<uint, proto.RandomSlotInfo> m_dicRandSlotInfos;

	private List<RandomSkinSwitchDesc> m_RandomSkinSwitch;

	private Dictionary<uint, proto.RandomSkinInfo> m_dicRandSkinInfos;

	public const uint LegendCloth_UnlockDesc_ConfigLevel = 1u;

	private Dictionary<uint, uint> m_ItemNumLimitUpdateItemInfoDict;

	private Dictionary<uint, uint> m_DictLaunchTag_ItemTagID;

	private Dictionary<uint, OgTagConfigDesc> m_DictLaunchTag_Config;

	private Dictionary<uint, uint> m_DictLaunchTag_ServerProgress;

	private Dictionary<uint, uint> m_DictLaunchTag_UILastDisplay;

	private Dictionary<uint, proto.ItemTagInfo> m_DictLaunchTag_Owned;

	private ulong m_LaunchTag_ServerProgressReqTime;

	private bool m_LaunchTag_PendingReqServerProgress;

	public CSGetBackpackRes BackpackData
	{
		get
		{
			return _003CBackpackData_003Ek__BackingField;
		}
		private set
		{
			_003CBackpackData_003Ek__BackingField = value;
		}
	}

	public Item[] NewInventories
	{
		get
		{
			return _003CNewInventories_003Ek__BackingField;
		}
		private set
		{
			_003CNewInventories_003Ek__BackingField = value;
		}
	}

	public Dictionary<int, ResourceID> DictBGMPath => null;

	public List<InventoryTopupNtf> TopupNotifications => null;

	public List<Item> GachaCouponList => null;

	public List<Item> DrawShopCouponList => null;

	public List<uint> CacheLimitAvatar => null;

	public HashSet<uint> HasRequestedButNoInfosItemId => null;

	public uint ChipCount
	{
		get
		{
			return _003CChipCount_003Ek__BackingField;
		}
		private set
		{
			_003CChipCount_003Ek__BackingField = value;
		}
	}

	private UIModelWeaponSkinUpgrader ModelWeaponSkinUpgrader => null;

	public uint CoinLimitOutGameWeekly => 0u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public uint GetSelectedLoadoutId()
	{
		return 0u;
	}

	public SkinTimelineDesc GetIPMusicDesc()
	{
		return null;
	}

	public string GetSkinTimeLineResConf1Name(InventorySkinTimelineType type, int confIndex = 0)
	{
		return null;
	}

	public string GetSkinTimeLineResConfNameByType(InventorySkinTimelineType type, uint subType)
	{
		return null;
	}

	public SkinTimelineDesc GetSkinTimeLineByType(InventorySkinTimelineType type)
	{
		return null;
	}

	public string GetSkinTimeLineResConfNameByType(SkinTimelineDesc desc, uint subType)
	{
		return null;
	}

	public void UpdateIsIPMusicValid()
	{
	}

	public bool IfIPMusicConfigValid()
	{
		return false;
	}

	public ResourceID GetIPMusicResID()
	{
		return default(ResourceID);
	}

	public string GetIPMusicIconSpriteName()
	{
		return null;
	}

	public uint GetIPMusicItemID()
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

	public void RequestWallet(bool isRebateCard)
	{
	}

	public bool RequestBackpack(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
		return false;
	}

	private void RequestBackpackResponse(HttpErrorCode errorCode, object res)
	{
	}

	public void RequestLegendClothDesc(uint legendClothId = 0u, bool forceReq = false, uint httpOp = 0u)
	{
	}

	private void RefreshLegendClothDesc(CSGetLegendClothesDescRes res, bool refreshAll)
	{
	}

	public HashSet<uint> GetLegendClothSetList()
	{
		return null;
	}

	public Dictionary<uint, LegendClothUnlockDesc> GetLegendClothConfigSetDict(uint legendId)
	{
		return null;
	}

	public bool IsLegendClothNew(uint legendId)
	{
		return false;
	}

	public bool IsLegendClothAllCdtStateZeroByLegendClothId(uint legendId)
	{
		return false;
	}

	public LegendClothUnlockDesc GetLegendClothUnlockDesc(uint legendId, uint level)
	{
		return null;
	}

	public List<LegendClothPrivilege> GetLegendClothPriviledgeList(uint legendClothId)
	{
		return null;
	}

	private void RefreshPropertyInNormalEmote(List<LegendClothPrivilege> privilegeList, uint itemId, uint featureType)
	{
	}

	private void RefreshTransformAnimPropertyInNormalEmote(List<LegendClothPrivilege> privilegeList, uint itemId)
	{
	}

	public bool IsPrivilegeWeaponExpired()
	{
		return false;
	}

	public bool CheckLimitIsOwned(uint id)
	{
		return false;
	}

	public bool CheckRealIsOwend(uint id)
	{
		return false;
	}

	public bool CheckIsOwned(uint id)
	{
		return false;
	}

	public bool CheckIsOwnedAndNotExpired(uint id, ulong curTime)
	{
		return false;
	}

	public bool CheckPermanetAndUnique(uint id)
	{
		return false;
	}

	public bool CheckIsUniqueAndOwnerByItemData(CSSharedItemData itData)
	{
		return false;
	}

	public bool CheckIsUniqueAndOwned(uint id)
	{
		return false;
	}

	public Dictionary<uint, Item> GetClothDictInfo()
	{
		return null;
	}

	public Dictionary<int, List<InventoryClothInfo>> GetDictBackpackCloth()
	{
		return null;
	}

	public Item GetClothinfoByItemID(uint id)
	{
		return null;
	}

	public Dictionary<uint, Item> GetBundleDictInfo()
	{
		return null;
	}

	public Dictionary<uint, Item> GetDebrisDictInfo()
	{
		return null;
	}

	public void UpdateBackPackInfo(InventoryChangeMessage res)
	{
	}

	private bool FindItem(Item a)
	{
		return false;
	}

	public bool IsNewGetByItemID(uint itemID)
	{
		return false;
	}

	public InventoryItemInfo FindItemInCacheNewInventory(uint itemID)
	{
		return null;
	}

	private void UpdateCachedNewInventory(Item it, Item origItem = null)
	{
	}

	public void UpdateBackPackWalletByTcp(uint coins, int gems)
	{
	}

	private void IncrementUpdateBackPackInfo(List<Item> items, bool isTcpNtf = true)
	{
	}

	public void UpdateBackPackInfo(CSGetBackpackRes res, bool isTcpNtf = false)
	{
	}

	public TCPUpdateItemInfo TryGetTcpUpdateItemInfo(uint id)
	{
		return null;
	}

	private void UpdateInventoryItems(List<Item> items, bool isTcpNtf = false)
	{
	}

	private void UpdateWeaonSkinStat(List<proto.WeaponSkinStat> weaponSkinStatList)
	{
	}

	private void UpdateWeaponSkinCustomData(List<proto.WeaponSkinCustom> weaponSkinCustomList)
	{
	}

	private void UpdateBackpackItemIDCache(Item it, EUpdateItemOperate operate, bool oldItemIsLimitCard)
	{
	}

	private void UpdateBackpackAvatar(Item it, EUpdateItemOperate operate, bool oldItemIsLimitCard)
	{
	}

	private void UpdateBackpackClothes(Item it, EUpdateItemOperate operate)
	{
	}

	private void UpdateItemToListByOperate(Item item, List<Item> list, EUpdateItemOperate operate)
	{
	}

	private void UpdateItemToDictByOperate(Item item, Dictionary<uint, Item> dict, EUpdateItemOperate operate)
	{
	}

	public bool IsNormalEquip(int slotIndex, int id)
	{
		return false;
	}

	public void ProcessCSGetRandomSkinSwitchDescRes(List<RandomSkinSwitchDesc> resRandomSkinSwitch)
	{
	}

	public Dictionary<uint, proto.RandomSlotInfo> GetRandomSlotInfos()
	{
		return null;
	}

	public void RefreshRandomSlots()
	{
	}

	public proto.RandomSlotInfo GetRandomSlotInfoBySlotIndex(uint slotIndex)
	{
		return null;
	}

	public proto.EInventory.SlotChooseType GetMultiSelectChooseType(uint slotIndex)
	{
		return proto.EInventory.SlotChooseType.SlotChooseType_NONE;
	}

	public Dictionary<uint, proto.RandomSkinInfo> GetRandomSkinInfos()
	{
		return null;
	}

	public bool IsWeaponUseRandomSlot(uint weaponId)
	{
		return false;
	}

	public void RefreshRandomSkins()
	{
	}

	public void RefreshRandomSkins(uint subCollection, uint uniqueID, uint[] skinIDs)
	{
	}

	public proto.RandomSkinInfo GetRandomSkinInfo(uint subCollection, uint uniqueID)
	{
		return null;
	}

	public proto.EInventory.SlotChooseType GetMultiSelectChooseTypeInRandomSkin(uint subCollection, uint uniqueID)
	{
		return proto.EInventory.SlotChooseType.SlotChooseType_NONE;
	}

	public bool IsMultiSelectEquippedInRandomSkin(uint subCollection, uint uniqueID, uint skinID)
	{
		return false;
	}

	public List<uint> GetRandomSkillSkins(uint subCollection, uint uniqueID)
	{
		return null;
	}

	public Dictionary<uint, List<uint>> GetAllRandomSkillSkinsDic(uint subCollection)
	{
		return null;
	}

	public bool IsOpenMultiSelectFunction(uint subCollection, uint uniqueID)
	{
		return false;
	}

	public uint GetMultiSelectUniqueIDInVault(CSSharedItemData item)
	{
		return 0u;
	}

	public bool CanUsePlayCard(Item PlayCardData)
	{
		return false;
	}

	public bool IsFeatureItemNeedShrink(CSSharedItemData itemData)
	{
		return false;
	}

	public void ChooseLoadOut(uint itemId, uint httpOp = 0u)
	{
	}

	public void UpdateSelectedLoadouts(List<proto.LoadoutInfo> selectedinfo)
	{
	}

	public uint GetCurrModeSelectedLoadoutV2()
	{
		return 0u;
	}

	public void UpdateSelectedLoadoutsV2(uint loadoutV2)
	{
	}

	public void UpdateNewInventories()
	{
	}

	public Item GetItemById(uint iid)
	{
		return null;
	}

	public bool CheckItemHasOwnById(uint iid)
	{
		return false;
	}

	public List<uint> GetOwnedBundleClothesSetItems()
	{
		return null;
	}

	public List<uint> GetOwnedBundleClothesSetIds()
	{
		return null;
	}

	public bool IsOwnedBundleClothesSetItem(uint itemId)
	{
		return false;
	}

	private void RefreshOwnedBundleClothesSetItemsIfDirty()
	{
	}

	private bool CheckIsAllOwnSetClothesBySetID(uint setID)
	{
		return false;
	}

	private void MarkOwnedBundleClothesSetItemsDirty()
	{
	}

	private void ClearOwnedBundleClothesSetItemsCache()
	{
	}

	public bool CheckItemOrBundleHasOwnById(uint iid)
	{
		return false;
	}

	public uint GetCurOwnedUponOrangeItemNumShowInImageShare()
	{
		return 0u;
	}

	public bool CheckIsOwnedUponOrangeItemNumShowInImageShare(CSSharedItemData item)
	{
		return false;
	}

	public PermanentValueItem GetExpiredItemByID(uint iid)
	{
		return null;
	}

	public int GetItemCount(uint iid)
	{
		return 0;
	}

	public uint GetLikeItemCountByType(proto.EInventory.LikeItemType likeItemType)
	{
		return 0u;
	}

	public int GetTotalItemCount(IEnumerable<uint> idList)
	{
		return 0;
	}

	public Item GetPlayCardById(uint id)
	{
		return null;
	}

	public bool ContainsItemIDInBackpack(uint id)
	{
		return false;
	}

	public bool ContainsExpireItemIdInBackpack(uint id)
	{
		return false;
	}

	public List<InventoryItemInfo> GetInventoryItemList(List<Item> itemList)
	{
		return null;
	}

	public List<Item> GetShowInInventoryPropList()
	{
		return null;
	}

	public void UpdatePreviewClothItem(AvatarWardrobeData wardrobeData)
	{
	}

	public void UpdateClothNewOwnedState(AvatarWardrobeData cloth)
	{
	}

	public void RemoveItemsInNewItemCache(IEnumerable<uint> itemIDs, bool updateTipsNum = true)
	{
	}

	public void RemoveItemInNewItemCache(uint itemID)
	{
	}

	public void RemoveItemInNewItemCache(InventoryItemInfo info)
	{
	}

	private void UpdateTipsNum(InventoryItemInfo infoInNewCache, int num)
	{
	}

	public bool CheckBundleOwned(uint itemID)
	{
		return false;
	}

	public bool BundleContainsItemAllOwned(uint id)
	{
		return false;
	}

	public bool CheckIsAvaliableItem(InventoryItemInfo info)
	{
		return false;
	}

	public bool CheckIsAvaliableCloth(InventoryItemInfo info)
	{
		return false;
	}

	public bool IsShowInInventoryPropItem(uint itemID)
	{
		return false;
	}

	public ETipsType GetTipsType(InventoryItemInfo info)
	{
		return ETipsType.None;
	}

	public ETipsType GetTipsType(UIModelAvatarBase.EWardrobeType wType)
	{
		return ETipsType.None;
	}

	public ETipsType GetTipsType(CSSharedItemDataManager.ItemType itemType)
	{
		return ETipsType.None;
	}

	public ItemChannelInfo GetItemChannelInfo(uint itemId)
	{
		return null;
	}

	public List<ItemChannelInfo> GetItemChannelInfos(uint itemId, ref bool realHasChannelInfo)
	{
		return null;
	}

	public long GetItemChannelEndTimeStamp(uint itemId)
	{
		return 0L;
	}

	public bool CompareItemCheckSummaryDesc(ItemCheckSummaryDesc desc1, ItemCheckSummaryDesc desc2)
	{
		return false;
	}

	public static int CompareItemCheckSummaryDescSort(ItemCheckSummaryDesc desc1, ItemCheckSummaryDesc desc2)
	{
		return 0;
	}

	public bool CheckItemChannelExist(uint itemId)
	{
		return false;
	}

	public ItemChannelInfo GetTokenUseChannelInfo(uint itemId)
	{
		return null;
	}

	public List<ItemChannelInfo> GetTokenUseChannelInfos(uint itemId)
	{
		return null;
	}

	public long GetTokenChannelEndTimeStamp(uint itemId)
	{
		return 0L;
	}

	public bool CompareTokenCheckSummaryDesc(ItemConsumeSummaryDesc desc1, ItemConsumeSummaryDesc desc2)
	{
		return false;
	}

	public int CompareItemUseSummaryDescSort(ItemConsumeSummaryDesc desc1, ItemConsumeSummaryDesc desc2)
	{
		return 0;
	}

	public bool CheckTokenChannelExist(uint itemId)
	{
		return false;
	}

	public ConsumeGoposSummaryDesc GetTokenGoposDataByChannel(uint channelId)
	{
		return null;
	}

	public void UpdateTipsNum(UIModelAvatarBase.EWardrobeType wType)
	{
	}

	public int GetTipNum(UIModelAvatarBase.EWardrobeType wType, bool legendOnly = false)
	{
		return 0;
	}

	private void SetTipsNum(ETipsType tipsType, int number = 0)
	{
	}

	public bool HaveOwnedPermanetUniqueItem(uint id)
	{
		return false;
	}

	public bool HasRoomCard(proto.EInventory.ItemSubType type)
	{
		return false;
	}

	public uint GetRoomCardCount(proto.EInventory.ItemSubType type)
	{
		return 0u;
	}

	public uint GetRoomCardExpiredTime(proto.EInventory.ItemSubType type)
	{
		return 0u;
	}

	public bool HasLimitedRoomCard(proto.EInventory.ItemSubType type)
	{
		return false;
	}

	public int SortRankCardItemByExpireTime(Item a, Item b)
	{
		return 0;
	}

	public RankCardData GetValidRankTimesRPCardData()
	{
		return null;
	}

	public CSRankingCardData GetValidCSRankNoDeductCardData()
	{
		return null;
	}

	public List<Item> GetValidBRRankNoDropDivisionCardItemList()
	{
		return null;
	}

	public uint GetItemListCnt(List<Item> items)
	{
		return 0u;
	}

	public uint GetBRRankNoDropDivisionCardProtectTimes()
	{
		return 0u;
	}

	public uint GetCSRankNoDropDivisionCardProtectTimes()
	{
		return 0u;
	}

	public List<Item> GetValidCSRankNoDropDivisionCardItemList()
	{
		return null;
	}

	public Item GetValidCSRankNoDeductItem()
	{
		return null;
	}

	public Item GetValidRankTimesRPCardItem()
	{
		return null;
	}

	public Item GetValidRankNoDeductCardItem()
	{
		return null;
	}

	public Item GetValidBRDoubleBonusCardItem()
	{
		return null;
	}

	public List<Item> GetValidBRDoubleBonusCardItemList()
	{
		return null;
	}

	public Item GetValidCSDoubleBonusCardItem()
	{
		return null;
	}

	public List<Item> GetValidCSDoubleBonusCardItemList()
	{
		return null;
	}

	public List<Item> GetValidRankNoDeductCardItemList()
	{
		return null;
	}

	public uint GetBRRankNoDeductCardProtectTimes()
	{
		return 0u;
	}

	public List<Item> GetValidRankTiemsRPCardItemList()
	{
		return null;
	}

	public List<Item> GetValidCSRankNoDeductItemList()
	{
		return null;
	}

	public uint GetCSRankNoDeductCardProtectTimes()
	{
		return 0u;
	}

	public void SetPurchaseFlag(bool state)
	{
	}

	public bool GetPurchaseFlag()
	{
		return false;
	}

	public void ProcessSkinTimelineDescRes(CSSkinTimelineDescRes data)
	{
	}

	public ulong ConverIdToSeasonLimitedKey(uint id)
	{
		return 0uL;
	}

	public uint FindSeasonLimitedItemByID(ulong id)
	{
		return 0u;
	}

	public uint FindSeasonLimitedItemMatchMode(uint id)
	{
		return 0u;
	}

	public void ProcessSeasonLimitedItemData(List<SeasonLimitedItemDesc> descs)
	{
	}

	public List<ChoosedEmote> GetCurEquipEmote()
	{
		return null;
	}

	public uint GetEmoteIndex(uint emoteID)
	{
		return 0u;
	}

	public uint GetCurEmoteByIndex(uint slotIndex)
	{
		return 0u;
	}

	public bool CanEquipNewEmote()
	{
		return false;
	}

	public uint[] GetCurSlot()
	{
		return null;
	}

	public List<proto.RandomSlotInfo> GetCurRandomSlot()
	{
		return null;
	}

	public List<proto.RandomSkinInfo> GetCurRandomSkin()
	{
		return null;
	}

	public bool NeedDownloadLegendClothResByLegendId(uint legendId)
	{
		return false;
	}

	public List<ResourceID> GetLegendClothNeedDownloadResListByLegendId(uint legendId)
	{
		return null;
	}

	public void ProcessBonusCardDesc(List<BonusCardDesc> bonusCardDescList)
	{
	}

	public void SetProtoGetBackpackCacheDirty(bool dirty)
	{
	}

	public void ProcessItemNumLimitDesc(List<ItemNumLimitDesc> itemNumLimitDescList)
	{
	}

	public ItemNumLimitDesc FindItemNumLimitDataById(uint id)
	{
		return null;
	}

	public string GetItemNumLimitDescById(uint id)
	{
		return null;
	}

	public void UpdateItemNumLimitInfo(InventoryChangeMessage res)
	{
	}

	public bool CheckItemExceedMaxNum(uint id)
	{
		return false;
	}

	public bool CheckIsHasItemExceedMaxNum()
	{
		return false;
	}

	private void RequestUsePlayItemLimitedCards(List<Item> items)
	{
	}

	public List<Item> GetPlayItemLimitedCardList()
	{
		return null;
	}

	public void ProcessGoldLimitOutGame(uint coinsLimitOutGameWeekly)
	{
	}

	public bool CheckHasLimitedCard()
	{
		return false;
	}

	public void RequestListItemChannelinfo(List<uint> ItemList)
	{
	}

	public void RequestTokenSourceSetting(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Background)
	{
	}

	private void ClearLaunchTagAllData()
	{
	}

	public void ProcessLaunchTagItem(List<OgTagItemDesc> list)
	{
	}

	public void ProcessLaunchTagDesc(List<OgTagConfigDesc> list)
	{
	}

	public void ProcessTCPLaunchTagInfo(InventoryChangeMessage tcpMsg)
	{
	}

	private void ProcessOwnedLaunchTagInfo(List<proto.ItemTagInfo> list)
	{
	}

	public bool GetLaunchTagServerProgress(uint tagID, out uint serialNumber)
	{
		serialNumber = default(uint);
		return false;
	}

	public bool GetLaunchTagUILastDisplay(uint tagID, out uint serialNumber)
	{
		serialNumber = default(uint);
		return false;
	}

	public void SetLaunchTagUILastDisplay(uint tagID, uint number)
	{
	}

	public bool GetLaunchTagID(uint itemID, out uint tagID)
	{
		tagID = default(uint);
		return false;
	}

	public bool GetLaunchTagSerialNumber(uint itemID, out uint serialNumber, bool checkBundleDetail = true)
	{
		serialNumber = default(uint);
		return false;
	}

	public void GetLaunchTagByLegendID(uint legendId, out uint tagID, out uint serialNumber)
	{
		tagID = default(uint);
		serialNumber = default(uint);
	}

	public List<proto.ItemTagInfo> GetOwnedLaunchTagByTagID(uint tagID)
	{
		return null;
	}

	public OgTagConfigDesc GetLaunchTagDesc(uint tagID)
	{
		return null;
	}

	public proto.ItemTagInfo SelectLaunchTagByPriority(List<proto.ItemTagInfo> list)
	{
		return null;
	}

	public proto.ItemTagInfo SelectLaunchTagByPriority(List<proto.ItemTagInfo> list, uint[] filter)
	{
		return null;
	}

	public proto.ItemTagInfo SelectLaunchTagByPrioritySelf()
	{
		return null;
	}

	private uint GetLaunchTagDisplayPriorityByItemID(uint itemID)
	{
		return 0u;
	}

	public void RequestLaunchTagServerProgress()
	{
	}

	private void _003CRequestTokenSourceSetting_003Eb__302_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestLaunchTagServerProgress_003Eb__327_0(HttpErrorCode errorCode, object res)
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
