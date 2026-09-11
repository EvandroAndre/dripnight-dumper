using System;
using System.Collections.Generic;
using GCommon;
using proto;
using proto.Login;

namespace COW;

public class UIModelCollection : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__139_1;

		internal void _003CRequestDressUpChooseBagShow_003Eb__139_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public UIModelCollection _003C_003E4__this;

		public CSChooseBannerReq req;

		internal void _003CRequestChooseBanner_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public UIModelCollection _003C_003E4__this;

		public CSChoosePinReq req;

		internal void _003CRequestChoosePin_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public uint[] randomCardIds;

		public UIModelCollection _003C_003E4__this;

		public CSChooseCollectionLoadingCardsReq req;

		public List<uint> autoEquipSkinIds;

		internal void _003CRequestChooseLoadingCard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public UIModelCollection _003C_003E4__this;

		public uint title;

		internal void _003CRequestChooseTitle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public UIModelCollection _003C_003E4__this;

		public uint[] randomFinalShotIds;

		public List<uint> reqList;

		internal void _003CRequestChooseFinalShot_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public UIModelCollection _003C_003E4__this;

		public CSChooseHeadPicReq req;

		internal void _003CRequestChooseHeadPic_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public EAccount.ExternalIconStatus externalIconStatus;

		public UIModelCollection _003C_003E4__this;

		internal void _003CRequestChooseExternalIcon_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public UIModelCollection _003C_003E4__this;

		public List<ChoosedEmote> emotes;

		internal void _003CRequestChooseEmote_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public uint[] randomSkinIDs;

		public List<uint> autoEquipSkinIds;

		public uint superEmoteId;

		internal void _003CRequestChooseSuperEmote_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public UIModelCollection _003C_003E4__this;

		public CSChooseSlotsReq req;

		public bool refresh;

		public bool hasweapon;

		public List<uint> reqList;

		public Action callback;

		public bool uselog;

		public uint slotid;

		internal void _003CRequestDressUpChooseSlots_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass124_0
	{
		public CSChooseSlotsReq req;

		public UIModelWeaponSkinCustom modelWeaponSkinCustom;

		public UIModelCollection _003C_003E4__this;

		public bool hasweapon;

		public List<uint> reqList;

		internal void _003CRequestChooseSlots_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public WeaponSkinData wSkinData;

		internal bool _003CSetSlotReqListValue_003Eb__0(uint a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_1
	{
		public VehicleSkinData vSkinData;

		internal bool _003CSetSlotReqListValue_003Eb__1(uint a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass126_0
	{
		public UIModelCollection _003C_003E4__this;

		public CSChooseSlotsReq req;

		public Action callback;

		internal void _003CRequestEquipPveWeaponSkin_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public CSChooseCollectionActionsReq req;

		public CSSharedItemDataManager.CollectionSubType collectionType;

		public UIModelCollection _003C_003E4__this;

		public List<uint> collectionActions;

		internal void _003CRequestCollectionAction_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public UIModelCollection _003C_003E4__this;

		public List<RandomSkinInfo> randomSkinInfos;

		public List<uint> autoEquipSkinIds;

		public List<uint> collectionActions;

		internal void _003CRequestBatchCollectionAction_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public UIModelCollection _003C_003E4__this;

		public CSChooseSlotsReq req;

		public uint itemID;

		public uint prevItemId;

		public List<uint> reqList;

		public Action callback;

		internal void _003CRequestChooseSlots_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public CSChooseSlotsAndShowReq req;

		public UIModelWeaponSkinCustom modelWeaponSkinCustom;

		public UIModelCollection _003C_003E4__this;

		public uint itemID;

		public CSSharedItemDataManager.CollectionSubType type;

		public List<uint> autoEquipSkinIds;

		public List<uint> slotsList;

		internal void _003CRequestChooseSlotsAndShow_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass131_0
	{
		public WeaponSkinCustom weapon;

		public bool equip;

		public UIModelCollection _003C_003E4__this;

		public CSSetWeaponSkinCustomReq req;

		public List<uint> slotsList;

		internal void _003CRequestSaveAndChooseCustomWeaponSkin_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public List<WeaponSkinCustom> weapons;

		public bool equip;

		public UIModelCollection _003C_003E4__this;

		public CSBatchSetWeaponSkinCustomReq req;

		public List<uint> autoEquipSkinIds;

		public List<uint> slotsList;

		internal void _003CRequestBatchSaveAndChooseCustomWeaponSkin_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public CSChooseCollectionSkillSkinsReq req;

		public UIModelCollection _003C_003E4__this;

		public List<uint> autoEquipSkinIds;

		public List<uint> equipedSkins;

		internal void _003CRequestChooseSkillEffect_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public UIModelCollection _003C_003E4__this;

		public bool refresh;

		internal void _003CRequestDressUpChooseBagShow_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass142_0
	{
		public UIModelCollection _003C_003E4__this;

		public List<uint> autoEquipSkinIds;

		public List<uint> reqList;

		public bool isTransformerChange;

		internal void _003CRequestChooseShow_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public uint[] randomFinishMoveIds;

		public uint finishMoveId;

		internal void _003CRequestChooseFinishMove_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public FinalShotData data;

		internal bool _003CAddAvailableFinalShotInfo_003Eb__0(FinalShotInfo fshot)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public Item item;

		internal bool _003CUpdateBannerList_003Eb__0(BannerBaseInfo i)
		{
			return false;
		}

		internal bool _003CUpdateBannerList_003Eb__1(BannerBaseInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public Item item;

		internal bool _003CUpdateHeadPicList_003Eb__0(HeadPicBaseInfo i)
		{
			return false;
		}

		internal bool _003CUpdateHeadPicList_003Eb__1(HeadPicBaseInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public Item item;

		internal bool _003CUpdateTitleList_003Eb__0(TitleInfo x)
		{
			return false;
		}

		internal bool _003CUpdateTitleList_003Eb__1(TitleInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public FinalShotData finalShotData;

		public Item item;

		internal bool _003CUpdateFinalShot_003Eb__0(FinalShotInfo i)
		{
			return false;
		}

		internal bool _003CUpdateFinalShot_003Eb__1(FinalShotInfo i)
		{
			return false;
		}

		internal bool _003CUpdateFinalShot_003Eb__2(FinalShotInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public uint titleId;

		internal bool _003CFindTitleInfoByTitleId_003Eb__0(TitleInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public Item item;

		internal bool _003CUpdateSkyboardList_003Eb__0(SkyboardBaseInfo i)
		{
			return false;
		}

		internal bool _003CUpdateSkyboardList_003Eb__1(SkyboardBaseInfo i)
		{
			return false;
		}
	}

	private BaseProfileInfo m_MyProfileInfo;

	public const uint PropID_CollectionRetOK = 2u;

	public const uint PropID_CollectionEquip = 4u;

	public const uint PropID_BannerEquipOK = 8u;

	public const uint PropID_HeadPicEquipOK = 16u;

	public const uint PropID_ProfileDataUpdate = 32u;

	public const uint PropID_NewCollection = 64u;

	public const uint PropID_LootBoxEquipOK = 128u;

	public const uint PropID_BackPackEquipOK = 256u;

	public const uint PropID_CollectionHideDataOK = 512u;

	public const uint PropID_EmoteEquipOk = 1024u;

	public const uint PropID_ShowEquipOK = 2048u;

	public const uint PropID_PinEquipOK = 4096u;

	public const uint PropID_ExternalIconUpdate = 8192u;

	public const uint PropID_TitleEquipOK = 16384u;

	public const uint PropID_EmoteEquipError = 32768u;

	public const uint PropID_CustomSkinEquipSuccess = 65536u;

	public const uint PropID_CustomSkinEquipFail = 131072u;

	public const uint propID_FinalShotEquipOK = 262144u;

	public const uint propID_ShowFastEquipOK = 524288u;

	public const uint PropID_AvatarFrameEquipOK = 1048576u;

	public const uint PropID_SocialLobbyLoginBagShowReady = 2097152u;

	private List<BannerBaseInfo> m_SortedListBannerInfo;

	private List<HeadPicBaseInfo> m_SortedListHeadPicInfo;

	private List<TitleInfo> m_SortedListTitleInfo;

	private List<AvatarFrameBaseInfo> m_SortedListAvatarFrameInfo;

	public Dictionary<uint, Item> PrivilegeCacheReplaceWeapon;

	private Dictionary<uint, List<WeaponSkinBaseInfo>> m_SortedListWeaponInfo;

	private Dictionary<uint, List<WeaponSkinBaseInfo>> m_SortedListOfOwnedWeaponInfo;

	private List<FinalShotInfo> m_SortedListOfFinalShotInfo;

	private Dictionary<uint, List<VehicleSkinBaseInfo>> m_SortedListVehicleInfo;

	private List<SkyboardBaseInfo> m_SortedListSkyboardInfo;

	private const string COLLECTION_BANNER_KEY = "collection_banner";

	private const string COLLECTION_HEADPIC_KEY = "collection_headpic";

	public const string COLLECTION_NEW_OPEN = "collection_new_open";

	public const string COLLECTION_NEW_LOOTBOX = "collection_new_lootbox";

	public const string COLLECTION_NEW_BACKPACK = "collection_new_backpack";

	public const string COLLECTION_NEW_PARACHUTE = "collection_new_parachute";

	public const string COLLECTION_NEW_SKYBOARD = "collection_new_skyboard";

	public const string COLLECTION_NEW_FLIGHT = "collection_new_flight";

	public const string COLLECTION_NEW_WEAPON = "collection_new_weapon";

	public const string COLLECTION_NEW_VEHICLESKIN = "collection_new_vehicle_skin";

	public const string COLLECTION_NEW_EMOTE = "collection_new_emote";

	public const string COLLECTION_NEW_GROUPANIM = "collection_new_group_anim";

	public const string COLLECTION_NEW_TITLE = "collection_new_title";

	private Dictionary<uint, string> m_DictWeaponType2Text;

	private bool m_IsRequestingChooseFinalShot;

	private Dictionary<byte, Dictionary<uint, Item>> m_DictCollectionInfo;

	private Dictionary<byte, int> CollectionTypeToTipsMap;

	private List<byte> m_CollectionTypesList;

	private Dictionary<byte, List<uint>> m_NewCollectionDict;

	private List<uint> m_NewPopMenuTypeList;

	private Dictionary<uint, List<uint>> m_NewPVEWeaponDict;

	private HashSet<uint> m_HideCollections;

	private HashSet<uint> m_CollectionGuidesInfo;

	private Dictionary<uint, List<uint>> m_DictWeaponTypeToWeaponIdList;

	private List<uint> m_AllOwnedWeaponIdList;

	private List<uint> m_AllOwnedVehicleIdList;

	public uint MvpAnimID;

	private bool gotNewEmote;

	private bool iceWallSkinDataInit;

	private Dictionary<uint, IceWallSkinData> iceWallSkinData;

	private Dictionary<uint, VoicePackageDesc> m_DictVoiceCollection;

	public List<AvatarFrameBaseInfo> SortedListAvatarFrameInfo => null;

	public List<TitleInfo> SortedListTitleInfo => null;

	public bool GoNewEmote
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

	public BaseProfileInfo MyProfileInfo()
	{
		return null;
	}

	public List<BannerBaseInfo> SortedListBannerInfo()
	{
		return null;
	}

	public List<HeadPicBaseInfo> SortedListHeadPicInfo()
	{
		return null;
	}

	public List<WeaponSkinBaseInfo> SortedListWeaponInfo(uint wpId)
	{
		return null;
	}

	public List<WeaponSkinBaseInfo> SortedListOfOwnedWeaponInfo(uint wpId)
	{
		return null;
	}

	public List<WeaponSkinBaseInfo> GetOwnedWeaponInfo()
	{
		return null;
	}

	public string GetWeaponTypeLabelById(uint id)
	{
		return null;
	}

	public FinalShotInfo GetAnyFinalShotInfo(bool mustOwned = true)
	{
		return null;
	}

	public FinalShotInfo GetFinalShotInfoByFinalShotId(uint finalShotId)
	{
		return null;
	}

	public List<VehicleSkinBaseInfo> SortedListVehicleSkinInfo(uint vId)
	{
		return null;
	}

	public List<SkyboardBaseInfo> SortedListSkyboardInfo()
	{
		return null;
	}

	public Dictionary<byte, List<uint>> NewCollectionDict()
	{
		return null;
	}

	public List<uint> GetAllWeaponTypes()
	{
		return null;
	}

	public List<uint> GetWeaponIdListByWeaponType(CollectionDataManager.ECollectionWeaponType wType)
	{
		return null;
	}

	public List<uint> GetAllOwnedWeaponIdList()
	{
		return null;
	}

	public List<uint> GetAllOwnedVehicleIdList()
	{
		return null;
	}

	public void AfterGetBackpack(CSGetBackpackRes backpackData, bool refreshgamebag = true, bool notifySocialLobbyLoginBagShow = false)
	{
	}

	public void UnlockEP()
	{
	}

	public void UpdateBPLevel()
	{
	}

	public uint GetCollectCfgSortID(int id)
	{
		return 0u;
	}

	public void SortCollectionData(List<Item> items, bool isIncrementUpdate)
	{
	}

	private void AddAvailableFinalShotInfo()
	{
	}

	private void UpdateBannerList(Item item, List<BannerBaseInfo> list, EUpdateItemOperate operate)
	{
	}

	private void UpdateHeadPicList(Item item, List<HeadPicBaseInfo> list, EUpdateItemOperate operate)
	{
	}

	public void UpdateAvatarFrameInfo()
	{
	}

	private void UpdateTitleList(Item item, List<TitleInfo> list, EUpdateItemOperate operate)
	{
	}

	private void UpdateFinalShot(Item item, List<FinalShotInfo> list, EUpdateItemOperate operate)
	{
	}

	public TitleInfo FindTitleInfoByTitleId(uint titleId)
	{
		return null;
	}

	private void UpdateSkyboardList(Item item, List<SkyboardBaseInfo> list, EUpdateItemOperate operate)
	{
	}

	public void UpdateClanName(string clanname)
	{
	}

	public void UpdateLadderRank(int rank, bool showCallsignRank, int rankPoint, int peakRankPos)
	{
	}

	public void UpdateCSLadderRank(int rank, int rankPoint, int peakRankPos)
	{
	}

	public void UpdateCSPeakTournamentLadderRank(uint cs_peak_point, bool display_cs_peak_point, uint cs_peak_tournament_rank_pos)
	{
	}

	public void UpdateUserData(EGLJDBDMENB userData)
	{
	}

	public Dictionary<byte, Dictionary<uint, Item>> GetCollectionDictInfo()
	{
		return null;
	}

	public void ClearCollectionDictInfo()
	{
	}

	public void UpdateOwnedCollectionByOperate(CSSharedItemDataManager.CollectionSubType cType, Item it, EUpdateItemOperate operate)
	{
	}

	public void RequestChooseBanner(uint bannerId)
	{
	}

	public void RequestChoosePin(uint pinId)
	{
	}

	public void RequestChooseLoadingCard(uint cardId, uint[] randomCardIds, List<uint> autoEquipSkinIds = null)
	{
	}

	public void RequestChooseTitle(uint title)
	{
	}

	public void RequestEquipFinalShot(List<uint> finalshotIds, uint[] randomFinalShotIds = null)
	{
	}

	public void RequestUnEquipFinalShot(uint preFinalShotId)
	{
	}

	private void RequestChooseFinalShot(List<WeaponFinalShotItem> finalshotItems, List<uint> reqList = null, uint[] randomFinalShotIds = null)
	{
	}

	public void RequestChooseAvatarFrame(uint avatarFrameId, bool isPrime)
	{
	}

	public void RequestChooseHeadPic(uint headpic)
	{
	}

	public void RequestChooseExternalIcon(EAccount.ExternalIconStatus externalIconStatus)
	{
	}

	private void UpdateDicExternalInfo(EAccount.ExternalIconStatus externalIconStatus)
	{
	}

	public void RequestChooseEmote(List<ChoosedEmote> emotes, bool isLocked = false, uint emoteID = 0u)
	{
	}

	public void RequestChooseSuperEmote(uint superEmoteId, uint[] randomSkinIDs, List<uint> autoEquipSkinIds = null)
	{
	}

	public void OnBackpackChange(List<Item> items, bool isTcpNotify)
	{
	}

	public void SortWeapon()
	{
	}

	private void RemoveSameSetEvoGun(List<Item> items, bool isTcpNotify)
	{
	}

	public void RefreshCollectionAfterGetEvoPass()
	{
	}

	public uint GetReplacedPrivilegeWeaponId(uint skinId)
	{
		return 0u;
	}

	public bool RequestBackpackCollection(bool sendImmediately = false)
	{
		return false;
	}

	public void RequestDressUpChooseSlots(List<uint> itemIdList, Action callback, bool refresh, bool uselog = false, uint slotid = 0u)
	{
	}

	private List<uint> CreateSlotData()
	{
		return null;
	}

	private void FillPveSkinData(List<PveSlotInfo> slots)
	{
	}

	private CSChooseSlotsReq CreateCSChooseSlotsReq()
	{
		return null;
	}

	public void RequestChooseSlots(List<uint> itemIdList)
	{
	}

	public void SetSlotReqListValue(List<uint> reqList, uint itemID, uint prevItemId = 0u)
	{
	}

	public void RequestEquipPveWeaponSkin(uint weaponId, uint preItemId, uint itemID, Action callback = null)
	{
	}

	public void RequestCollectionAction(uint actionId, CSSharedItemDataManager.CollectionSubType collectionType, List<RandomSkinInfo> randomSkinInfos = null)
	{
	}

	public void RequestBatchCollectionAction(List<uint> actionIds, List<RandomSkinInfo> randomSkinInfos = null, List<uint> autoEquipSkinIds = null)
	{
	}

	public void RequestChooseSlots(uint prevItemId, uint itemID, Action callback = null)
	{
	}

	public void RequestChooseSlotsAndShow(uint prevItemId, uint itemID, CSSharedItemDataManager.CollectionSubType type = CSSharedItemDataManager.CollectionSubType.Weapon, List<RandomSkinInfo> randomSkinInfos = null, List<uint> autoEquipSkinIds = null)
	{
	}

	public void RequestSaveAndChooseCustomWeaponSkin(WeaponSkinCustom weapon, bool equip = true)
	{
	}

	public void RequestBatchSaveAndChooseCustomWeaponSkin(List<WeaponSkinCustom> weapons, bool equip = true, List<uint> autoEquipSkinIds = null)
	{
	}

	public void RequestChooseSkillEffect(List<RandomSkinInfo> randomSkinInfos, List<uint> autoEquipSkinIds = null)
	{
	}

	private void LobbyShowResFinished(CSGetSelectedItemsRes nRes)
	{
	}

	private void EquipedResFinished(CSGetSelectedItemsRes nRes, CSChooseSlotsAndShowReq req, uint itemID)
	{
	}

	public void RequestEquipWeapon(uint prevSkinId, uint skinid)
	{
	}

	public bool HasBagShow()
	{
		return false;
	}

	public void ClearBagShow()
	{
	}

	public void RequestDressUpChooseBagShow(uint showItemId, bool refresh)
	{
	}

	public void RequestChooseBagShow(uint showItemId)
	{
	}

	public void RequestSimpleChooseBagShow(uint showItemId)
	{
	}

	public void RequestChooseShow(uint showItemId, CSSharedItemDataManager.CollectionSubType type = CSSharedItemDataManager.CollectionSubType.Weapon, List<RandomSkinInfo> randomSkinInfos = null, List<uint> autoEquipSkinIds = null)
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void UpdateNewOwnedItem(Item[] newInventories)
	{
	}

	public void UpdatePreviewItem(CSSharedItemDataManager.CollectionSubType collectionType, uint itemId)
	{
	}

	public void UpdatePreviewTypes(CSSharedItemDataManager.CollectionSubType collectionType)
	{
	}

	public void UpdateTipsNum(bool updateall = true)
	{
	}

	private void UpdateTipsNum(CSSharedItemDataManager.CollectionSubType collectionType, bool checkNew = false)
	{
	}

	private void SetTipsNum(ETipsType tipsType, int number = 0)
	{
	}

	private void SaveNewItems()
	{
	}

	private static void AddRecipeAbResIds(List<ResourceID> dst, int[] recipes)
	{
	}

	private static void AddRecipeAbResIds(List<ResourceID> dst, int recipe)
	{
	}

	public IceWallSkinData GetIceWallSkinDataByItemId(uint itemId)
	{
		return null;
	}

	public ResourceID GetIcewallIngameModelResIdByItemId(uint itemId)
	{
		return default(ResourceID);
	}

	public Item FindOwnedItemByTypeAndId(CSSharedItemDataManager.CollectionSubType cType, uint itemId)
	{
		return null;
	}

	public void UpdateExternalIcon(string externalIcon)
	{
	}

	public void UpdateCollectionGuidesInfo(uint[] guidesInfo)
	{
	}

	public void UpdateCollectionGuidesInfo(uint guidesID)
	{
	}

	public bool CheckCollectionGuideHasGotByID(uint id)
	{
		return false;
	}

	public uint GetBaselvEvoGunIdByItemid(uint itemId)
	{
		return 0u;
	}

	public void RequestChooseFinishMove(uint finishMoveId, uint[] randomFinishMoveIds = null)
	{
	}

	public void ProcessVoiceCollectionConfig(List<VoicePackageDesc> voicePackageDescs)
	{
	}

	public VoicePackageDesc GetVoiceCollectionConfigByItemID(uint itemID)
	{
		return null;
	}

	public VoicePackageDesc GetDefaultVoiceCollectionConfig()
	{
		return null;
	}

	private void _003CRequestChooseAvatarFrame_003Eb__108_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestChooseBagShow_003Eb__140_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSimpleChooseBagShow_003Eb__141_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
