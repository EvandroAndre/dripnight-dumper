using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelHippoCrisis : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__96_0;

		public static Comparison<HippoCrisisOutGameItemUIData> _003C_003E9__135_0;

		internal int _003CCheckAndGetNotSatisfiedStartCondition_003Eb__96_0(uint a, uint b)
		{
			return 0;
		}

		internal int _003CCheckAndMergeInventoryItem_003Eb__135_0(HippoCrisisOutGameItemUIData a, HippoCrisisOutGameItemUIData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public HippoInventoryChangeInfo modify;

		internal bool _003CUpdateInventoryInfoByModifyInfos_003Eb__1(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_1
	{
		public proto.HippoInventoryEquipItem changeItem;

		internal bool _003CUpdateInventoryInfoByModifyInfos_003Eb__0(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public uint itemId;

		internal bool _003CCheckOwnedItemByItemId_003Eb__0(IHippoCrisisBackPackItemUIData a)
		{
			return false;
		}

		internal bool _003CCheckOwnedItemByItemId_003Eb__1(IHippoCrisisBackPackItemUIData a)
		{
			return false;
		}

		internal bool _003CCheckOwnedItemByItemId_003Eb__2(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass210_0
	{
		public IHippoCrisisBackPackItemUIData item;

		internal bool _003CBackpackSafeBoxStoreToInventory_003Eb__0(int x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass210_1
	{
		public IHippoCrisisBackPackItemUIData item;

		internal bool _003CBackpackSafeBoxStoreToInventory_003Eb__1(int x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public HippoInventoryChangeInfo item;

		internal bool _003CRequestHippoCrisisInventorySell_003Eb__1(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}

		internal bool _003CRequestHippoCrisisInventorySell_003Eb__2(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public HippoInventoryChangeInfo item;

		internal bool _003CRequestHippoCrisisInventoryWarehouseUpgrade_003Eb__1(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}

		internal bool _003CRequestHippoCrisisInventoryWarehouseUpgrade_003Eb__2(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIModelHippoCrisis _003C_003E4__this;

		public List<CSHippoInventoryPurchasesReq.PurchasesInfo> purchases_list;

		public int purchaseMethod;

		internal void _003CRequestPurchaseItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_1
	{
		public HippoInventoryChangeInfo item;

		internal bool _003CRequestPurchaseItem_003Eb__1(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}

		internal bool _003CRequestPurchaseItem_003Eb__2(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_2
	{
		public HippoCrisisStoreItemData storeItemData;

		internal bool _003CRequestPurchaseItem_003Eb__3(CSHippoInventoryPurchasesReq.PurchasesInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_3
	{
		public CSHippoInventoryPurchasesReq.PurchasesInfo purchase;

		internal bool _003CRequestPurchaseItem_003Eb__4(HippoCrisisStoreItemData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public UIModelHippoCrisis _003C_003E4__this;

		public bool isBriefBoxReq;

		public bool isFromRepair;

		public bool isRecommendReq;

		public uint purchaseRecommendPreset;

		public bool isPreStartExitReq;

		public bool isPreStartConfirmReq;

		public bool isPreStartEnterRecommendReq;

		public bool isInventoryEnterBlackMarket;

		public bool isInventoryExit;

		public bool isInventoryEnterSelling;

		public bool isPreStartBuy;

		internal void _003CRequestModifyEquip_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private CSGetHippoInventoryDescRes m_HippoCrisisDescRes;

	private CSGetHippoInventoryAccountInfoRes m_CSGetHippoInventoryAccountInfoRes;

	private HippoCrisisInventoryData m_HippoCrisisInventoryData;

	private uint m_HippoCrisisMoney;

	public Dictionary<uint, uint> VirtualItemCntDict;

	public List<HippoCrisisOutGameItemUIData> InventorySelectedItems;

	public const uint PropID_GetAccountInfoRes = 1u;

	public const uint PropID_HippoInventorySell = 2u;

	public const uint PropID_HippoInventoryCapacityUpgrade = 4u;

	public const uint PropID_MoneyChange = 8u;

	public const uint PropID_HCModifyInfoOK = 16u;

	public const uint PropID_TimeOutCntReachThreshold = 32u;

	public const uint PropID_TcpDataUpdate = 64u;

	public const uint PropID_OnStroeAllToInventory = 128u;

	public const uint PropID_HCModifyInfoOK_EquipRecommendPreStart = 256u;

	public const uint PropID_HCRepairResOK = 512u;

	public const uint PropID_HCModifyInfoOK_PreStartExit = 1024u;

	public const uint PropID_HCModifyInfoOK_PreStartConfirm = 2048u;

	public const uint PropID_HCModifyInfoOK_PreStartEnterRecommend = 4096u;

	public const uint PropID_PreStartBtnChange = 8192u;

	public const uint PropID_HCModifyInfoOK_InventoryEnterBlackMarket = 16384u;

	public const uint PropID_HCModifyInfoOK_InventoryExit = 32768u;

	public const uint PropID_HCModifyInfoOK_InventoryEnterSelling = 65536u;

	public const uint PropID_HCModifyInfoOK_PreStatBuy = 131072u;

	public const uint PropId_GetHippoInventoryDesc = 262144u;

	public const uint moneyId = 1670000u;

	public readonly uint[] ReviveItemIds;

	public readonly uint[] SafeBoxItemIds;

	public const string moneyIcon = "UI_HC_Item_Value";

	public const string reviveIcon = "UI_HC_Material_Icon_ResurrectionAddOne_BP";

	public const string safeBoxIcon = "UI_HC_Material_Icon_StrongBoxAddCard_BP";

	public bool IneventoryIsSelling;

	public bool ShowPreStartBtn;

	public List<HippoCrisisStoreItemData> StoreItems;

	public List<HippoCrisisStoreItemData> PurchaseItems;

	public List<HippoCrisisOutGameItemUIData> PurchaseInventoryItems;

	public List<CSHippoInventoryModifyEquipReq.ModifyInfo> OperationList;

	private Dictionary<uint, HippoCrisisStoreItemData> m_StoreItemDict;

	private Dictionary<uint, HippoCrisisStoreItemData> m_StoreItemDictByItemID;

	public Dictionary<uint, uint> StorePurchaseCnt;

	public Dictionary<uint, uint> DifficultyValueLimitDict;

	public List<ClientActivityDesc> HippoCrisisActivityDescs;

	private bool m_IsInRequest;

	private bool m_HippoCrisisInventoryAccountInfoCacheDirty;

	public bool NeedSyncData;

	public bool StartLogLobbyTime;

	public ulong LeaveHCLobbyStartTime;

	public bool BackToHippoCrisisLobby;

	public bool BackToHippoCrisisStorage;

	public string LoadingCdnURL;

	public int InventoryLastStep;

	public uint ModifyEquipRequestTimeOutCnt;

	private HashSet<int> m_CannotSelectLevels;

	public List<int> ClickedRecommendPreset;

	private HippoCrisisOutGameEquipmentData m_HippoCrisisLobbyEquipmentData_UI;

	private HippoCrisisOutGameEquipmentData m_HippoCrisisLobbyEquipmentData_Backup;

	private HippoCrisisInGameEquipmentData m_HippoCrisisInGameEquipmentData;

	private List<int> CheckCanEquipItemTmpList;

	public HippoCrisisInventoryData HippoCrisisInventoryData => null;

	public uint HippoCrisisMoney
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public HippoCrisisOutGameEquipmentData LocalHippoCrisisLobbyEquipmentData => null;

	public HippoCrisisInGameEquipmentData HippoCrisisInGameEquipmentData => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public uint GetEquipWeaponID()
	{
		return 0u;
	}

	public static bool InHippoCrisisMatch()
	{
		return false;
	}

	public List<ResourceID> GetHCNeedDownloadMapResList()
	{
		return null;
	}

	public MapModeData GetUIHippoCrisisMapDataByDifficulty(int difficulty)
	{
		return null;
	}

	public uint GetMemberValue(GroupMemberInfo member)
	{
		return 0u;
	}

	public void TryBackupLobbyBackpackData()
	{
	}

	public void RequestHippoCrisisDescs()
	{
	}

	public void SetHippoInventoryAccountInfoCacheDirty(bool dirty)
	{
	}

	public void RequestHippoCrisisGetInfo(uint httpOption = 0u, bool force = false)
	{
	}

	private void UpdateBackpackInfoByHttpRes(CSGetHippoInventoryAccountInfoRes info)
	{
	}

	public void UpdateMoney(uint money)
	{
	}

	public void OperationListAdd(CSHippoInventoryModifyEquipReq.ModifyInfo modifyInfo)
	{
	}

	public void AddMoveToOperation(proto.EHippoInventory.EquipType srcEquipType, ulong srcInstId, uint srcItemId, proto.EHippoInventory.EquipType dstEquipType, uint dstSlot, uint amount = 1u)
	{
	}

	public void AddAttachmentEquipOperation(proto.EHippoInventory.EquipType srcEquipType, ulong srcInstId, proto.EHippoInventory.EquipType dstEquipType, ulong dstInstId, uint dstSlot, uint srcItemId = 0u)
	{
	}

	public void AddAttachmentUnEquipOperation(proto.EHippoInventory.EquipType srcEquipType, ulong srcInstId, uint srcSlot, proto.EHippoInventory.EquipType dstEquipType)
	{
	}

	public void AddAttachmentMoveOperation(proto.EHippoInventory.EquipType srcEquipType, ulong srcInstId, uint srcSlot, proto.EHippoInventory.EquipType dstEquipType, ulong dstInstId, uint dstSlot)
	{
	}

	public void AddPurchaseOperation(uint storeid, uint purchaseAmount, bool freeBuy = false)
	{
	}

	public void RequestHippoCrisisInventorySell(List<CSHippoInventorySellReq.SellInfo> sellList)
	{
	}

	public void RequestHippoCrisisInventoryWarehouseUpgrade()
	{
	}

	public void RequestHippoCrisisInventoryRepair(List<HCRepairRequestItemInfo> list)
	{
	}

	public void RequestPurchaseItem(List<CSHippoInventoryPurchasesReq.PurchasesInfo> purchases_list, int purchaseMethod)
	{
	}

	public void RequestModifyEquip(uint httpOption = 0u, bool isBriefBoxReq = false, bool isFromRepair = false, bool isRecommendReq = false, bool isPreStartExitReq = false, bool isPreStartConfirmReq = false, bool isPreStartEnterRecommendReq = false, bool isInventoryEnterBlackMarket = false, bool isInventoryExit = false, bool isInventoryEnterSelling = false, uint purchaseRecommendPreset = 0u, bool isPreStartBuy = false)
	{
	}

	private void UpdateLobbyBackpackData(CSHippoInventoryModifyEquipRes modifyEquipRes)
	{
	}

	private void RestoreLobbyBackpackData()
	{
	}

	public void OnInventoryDragDropItemDragRelease(HippoCrisisDragOperationResult dragOperationResult, HippoCrisisDragSourceInfo info)
	{
	}

	private void CheckDragCanPurchaseInPreStart(HippoCrisisDragOperationResult dragOperationResult, HippoCrisisDragSourceInfo info)
	{
	}

	public void OnInventoryDragDropItemDragSuccess(HippoCrisisDragOperationResult dragOperationResult, HippoCrisisDragSourceInfo dragSourceInfo)
	{
	}

	public void OnUIHippoCrisisCanDragItemDragRelease(HippoCrisisDragOperationResult dragOperationResult, HippoCrisisDragSourceInfo info)
	{
	}

	public void OnUIHippoCrisisCanDragItemDragSuccess(HippoCrisisDragOperationResult dragOperationResult, HippoCrisisDragSourceInfo dragSourceInfo)
	{
	}

	public HippoCrisisDragOperationResult EquipCB(HippoCrisisDragSourceInfo hippoCrisisDragSourceInfo)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public HippoCrisisDragOperationResult DragToEquipmentContainerCB(HippoCrisisDragSourceInfo hippoCrisisDragSourceInfo, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public HippoCrisisDragOperationResult DragToInventoryCB(HippoCrisisDragSourceInfo hippoCrisisDragSourceInfo, EDragReleaseResponseAreaType areaType, bool onlyCheckResult = false)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public HippoCrisisDragOperationResult DragToBackpackCB(HippoCrisisDragSourceInfo dragSourceInfo, EDragReleaseResponseAreaType areaType, bool onlyCheckResult = false)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public HippoCrisisDragOperationResult DragToEquipmentBaseCB(HippoCrisisDragSourceInfo sourceInfo, EDragReleaseResponseAreaType areaType, IHippoCrisisBackPackItemUIData exchangeData, EHippoCrisisEquipmentSlot slot, proto.EHippoInventory.EquipType equipType, bool onlyCheckResult = false)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public void BuyItem(uint storeID)
	{
	}

	public bool CanBuySelectItem(uint price, uint weight, proto.EHippoInventory.EquipType dest = proto.EHippoInventory.EquipType.EquipTypeWarehouse)
	{
		return false;
	}

	public List<uint> CheckAndGetNotSatisfiedStartCondition()
	{
		return null;
	}

	public bool CheckAndGetTotalValueLimit(ref uint limitNum)
	{
		return false;
	}

	public bool CheckHasItemInBagByType(uint type)
	{
		return false;
	}

	public uint GetCarryAmmoNumByWeaponData(IHippoCrisisBackPackItemUIData weaponData)
	{
		return 0u;
	}

	public uint GetItemNumInInventory(uint itemID)
	{
		return 0u;
	}

	public uint GetItemNumInBagAndSafeBox(uint itemID)
	{
		return 0u;
	}

	public void OnMainWeaponAmmoLimit()
	{
	}

	public void TryBuyMainWeaponAmmo(uint weaponAmmoID)
	{
	}

	public uint GetCurSelectDifficulty()
	{
		return 0u;
	}

	private void UpdateInventoryInfo(CSGetHippoInventoryAccountInfoRes info)
	{
	}

	public void UpdateInventoryInfoByModifyInfos(CSHippoInventoryModifyEquipRes modifyEquipRes)
	{
	}

	public void SyncInventoryUIData()
	{
	}

	private void UpdateInventoryTotalCapacity()
	{
	}

	public void UpdateInventoryUsageCapacity(uint weight)
	{
	}

	private bool IsInventoryTabValid(HippoCrisisInventoryTab tab)
	{
		return false;
	}

	private bool IsInventoryTabValid(HippoCrisisInventorySubTab tab)
	{
		return false;
	}

	public string MoneyFormat(uint money)
	{
		return null;
	}

	public HippoWarehouseLevelDesc GetInventoryInfoByLevel(uint level)
	{
		return null;
	}

	public bool CheckIsEquipmentBackpackInteral(proto.EHippoInventory.EquipType equipType)
	{
		return false;
	}

	public List<uint> GetSubTabs(HippoCrisisInventoryTab parentTab)
	{
		return null;
	}

	public string GetNameByTab(HippoCrisisInventoryTab tab)
	{
		return null;
	}

	public string GetIconNameBySubTab(HippoCrisisInventorySubTab tab)
	{
		return null;
	}

	public HippoCrisisInventoryTab GetTabByItemType(PIJKGPDBNJC type)
	{
		return HippoCrisisInventoryTab.None;
	}

	public HippoCrisisInventorySubTab GetSubTabByItemType(PIJKGPDBNJC type, uint itemId = 0u)
	{
		return HippoCrisisInventorySubTab.None;
	}

	public HippoCrisisInventorySubTab GetWeaponSubTabByItemId(uint itemId)
	{
		return HippoCrisisInventorySubTab.None;
	}

	public HippoCrisisInventorySubTab GetAttachmentSubTabByItemId(uint itemId)
	{
		return HippoCrisisInventorySubTab.None;
	}

	public HippoCrisisInventorySubTab GetConsumableSubTabByItemId(uint itemId)
	{
		return HippoCrisisInventorySubTab.None;
	}

	public bool IsSubTabAll(HippoCrisisInventorySubTab tab)
	{
		return false;
	}

	public bool IsSubTabAllOrNone(HippoCrisisInventorySubTab tab)
	{
		return false;
	}

	public int InventoryItemSort(IHippoCrisisBackPackItemUIData a, IHippoCrisisBackPackItemUIData b)
	{
		return 0;
	}

	public int InventoryItemSortByLevel(IHippoCrisisBackPackItemUIData a, IHippoCrisisBackPackItemUIData b)
	{
		return 0;
	}

	public int InventoryItemSortByValue(IHippoCrisisBackPackItemUIData a, IHippoCrisisBackPackItemUIData b)
	{
		return 0;
	}

	private uint GetPriortyByItemType(PIJKGPDBNJC type)
	{
		return 0u;
	}

	public string GetWeightStringByGram(uint gram)
	{
		return null;
	}

	public string GetCapacityStringByGram(uint gram)
	{
		return null;
	}

	public string GetStackAmmountString(uint count)
	{
		return null;
	}

	public List<HippoCrisisOutGameItemUIData> GetInventoryCanSelectMaterialData()
	{
		return null;
	}

	public uint GetInventoryItemCnt(uint itemId)
	{
		return 0u;
	}

	public bool CheckAndMergeInventoryItem(HippoCrisisOutGameItemUIData newData, uint selectNum, out HippoCrisisOutGameItemUIData brandNewData)
	{
		brandNewData = null;
		return false;
	}

	public float GetHippoCrisisWeaponProperty(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments, EWeaponScoreID scoreId)
	{
		return 0f;
	}

	public float GetWeaponDamage(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	public float HippoCrisisDamageFormulaNew(int damage, int oneAmmo)
	{
		return 0f;
	}

	public float GetWeaponRateOfFire(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	public float GetWeaponRange(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	public float GetWeaponReloadSpeed(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	public float GetWeaponAmmoClipSize(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	public float GetWeaponAccuracy(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	public float GetWeaponBiteAmmor(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	public float GetWeaponMovementSpeed(uint itemID, List<IHippoCrisisBackPackItemUIData> attachments)
	{
		return 0f;
	}

	private void ProcessDifficultyValueLimit(List<HippoValueLimitDesc> limitList)
	{
	}

	public void ProcessStoreItem(List<HippoStoreDesc> storeDescs)
	{
	}

	public HippoCrisisStoreItemData GetStoreItemDataByStoreId(uint storeId)
	{
		return null;
	}

	public HippoCrisisStoreItemData GetStoreItemDataByItemId(uint itemId)
	{
		return null;
	}

	public bool IsItemReachMaxPurchase(HippoCrisisStoreItemData item)
	{
		return false;
	}

	public IHippoCrisisBackPackItemUIData CheckOwnedItemByItemId(uint itemId, out uint ownedNum)
	{
		ownedNum = default(uint);
		return null;
	}

	public void RemoveAllEquipmentsToInventory()
	{
	}

	public void PurchaseAndEquipAllItems(List<HippoCrisisPreSetData> list, bool freeBuy = false)
	{
	}

	public void AddRecommendPreset(int id)
	{
	}

	public uint GetFreeBuyAllowValue()
	{
		return 0u;
	}

	public void GetOwnedBestItems(out IHippoCrisisBackPackItemUIData bestWeapon, out IHippoCrisisBackPackItemUIData bestBackPack, out IHippoCrisisBackPackItemUIData bestArmor, out IHippoCrisisBackPackItemUIData bestHelmet, out List<IHippoCrisisBackPackItemUIData> bestAttachments, out IHippoCrisisBackPackItemUIData bestBullet)
	{
		bestWeapon = null;
		bestBackPack = null;
		bestArmor = null;
		bestHelmet = null;
		bestAttachments = null;
		bestBullet = null;
	}

	public List<IHippoCrisisBackPackItemUIData> FindBestAttachmentsForWeapon(IHippoCrisisBackPackItemUIData weapon, List<IHippoCrisisBackPackItemUIData> items)
	{
		return null;
	}

	public IHippoCrisisBackPackItemUIData FindBestBulletForWeapon(IHippoCrisisBackPackItemUIData weapon, List<IHippoCrisisBackPackItemUIData> items)
	{
		return null;
	}

	private uint CalculateAttachmentValue(IHippoCrisisBackPackItemUIData weapon)
	{
		return 0u;
	}

	public void AddBestAttachmentToWeapon(HippoCrisisOutGameItemUIData weapon)
	{
	}

	public void ChangeLobbyStartGameBtn(bool showPreStart)
	{
	}

	public void SendPreStartEventlog()
	{
	}

	public IHippoCrisisEquipmentBackpackData GetCurrentHippoCrisisEquipmentData()
	{
		return null;
	}

	public uint GetCurrentBackpackTotalCapacity()
	{
		return 0u;
	}

	public uint GetCurrentSafeBoxTotalCapacity()
	{
		return 0u;
	}

	public uint GetCurrentBackpackRemainCapacity()
	{
		return 0u;
	}

	public uint GetCurrentSafeBoxRemainCapacity()
	{
		return 0u;
	}

	public ulong GetEquipmentTotalValue(IHippoCrisisEquipmentBackpackData data)
	{
		return 0uL;
	}

	public ulong GetBackpackItemsTotalValue(IHippoCrisisEquipmentBackpackData data)
	{
		return 0uL;
	}

	public ulong GetSafeBoxItemsTotalValue(IHippoCrisisEquipmentBackpackData data)
	{
		return 0uL;
	}

	public uint GetLobbyEquipTotalValue()
	{
		return 0u;
	}

	public uint GetLobbyMemberSelfEquipValue()
	{
		return 0u;
	}

	public uint GetCurTotalValue()
	{
		return 0u;
	}

	public void SortItemListByType(List<IHippoCrisisBackPackItemUIData> list, HippoCrisisPopMenuSort sortType)
	{
	}

	public bool IsBagInteralDrag(proto.EHippoInventory.EquipType fromEquipType)
	{
		return false;
	}

	public EDragOperationResultType CheckCanPutInBagBox(IHippoCrisisBackPackItemUIData data, EDragReleaseResponseAreaType areaType, bool isPurchaseEquipImmediately = false)
	{
		return EDragOperationResultType.None;
	}

	public HippoCrisisDragOperationResult CheckCanEquipItemFromContainer(IHippoCrisisBackPackItemUIData data, int? sourceRemainCap, proto.EHippoInventory.EquipType fromEquipType, proto.EHippoInventory.EquipType equipType, EHippoCrisisEquipmentSlot targetSlot, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public bool IsAreaTypeSameRegion(EDragReleaseResponseAreaType areaType1, EDragReleaseResponseAreaType areaType2)
	{
		return false;
	}

	public bool IsEquipmentRegionByAreaType(EDragReleaseResponseAreaType areaType)
	{
		return false;
	}

	private EDragReleaseResponseAreaType GetAreaTypeByEquipSlot(EHippoCrisisEquipmentSlot slot)
	{
		return EDragReleaseResponseAreaType.None;
	}

	private HippoCrisisDragOperationResult TryEquipItemToTargetSlot(IHippoCrisisBackPackItemUIData currentEquip, int? sourceRemainCap, IHippoCrisisBackPackItemUIData dragData, proto.EHippoInventory.EquipType equipType, EHippoCrisisEquipmentSlot targetSlot, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	private HippoCrisisDragOperationResult CheckCanEquipWeaponAttachFromBag(IHippoCrisisBackPackItemUIData weaponData, int? sourceRemainCap, EJNFNOJNCPE attachData, proto.EHippoInventory.EquipType fromEquipType, proto.EHippoInventory.EquipType equipType, EHippoCrisisEquipmentSlot slot, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	private HippoCrisisDragOperationResult CheckCanEquipEquipmentAttachFromBag(IHippoCrisisBackPackItemUIData equipment, int? sourceRemainCap, DFBPGIINGFN attachData, proto.EHippoInventory.EquipType fromEquipType, proto.EHippoInventory.EquipType equipType, EHippoCrisisEquipmentSlot slot, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public bool CheckWeaponAttachCanAdapt(uint weaponId, uint attachId)
	{
		return false;
	}

	private bool CheckEquipmentItemAttachCanAdapt(KIDBEABFENA equipmentData, DFBPGIINGFN attachData)
	{
		return false;
	}

	public IHippoCrisisBackPackItemUIData GetCurrentEquipAttachItemBySlot(EHippoCrisisEquipmentSlot slot, IHippoCrisisEquipmentBackpackData data, GIANNEDDMLL attachmentType = GIANNEDDMLL.None)
	{
		return null;
	}

	public IHippoCrisisBackPackItemUIData GetWeaponAttachItemByType(IHippoCrisisBackPackItemUIData weaponData, GIANNEDDMLL attachmentType)
	{
		return null;
	}

	public IHippoCrisisBackPackItemUIData GetCurrentEquipItemByAreaType(EDragReleaseResponseAreaType areaType)
	{
		return null;
	}

	public IHippoCrisisBackPackItemUIData GetCurrentEquipItemBySlot(EHippoCrisisEquipmentSlot slot, IHippoCrisisEquipmentBackpackData data)
	{
		return null;
	}

	public bool TryDelBackpackEquipmentByUniqueId(ulong uniqueId, HippoCrisisOutGameEquipmentData data)
	{
		return false;
	}

	public bool IsCanSplitItem(IHippoCrisisBackPackItemUIData data)
	{
		return false;
	}

	public uint GetDefaultBagCapacity()
	{
		return 0u;
	}

	public uint GetDefaultSafeBoxCapacity()
	{
		return 0u;
	}

	public uint GetCurrentSafeBoxId()
	{
		return 0u;
	}

	public void ChangeSafeBoxId(uint id)
	{
	}

	public uint GetRepairCost(IHippoCrisisBackPackItemUIData item)
	{
		return 0u;
	}

	public void OnTcpUpdateNtf(HippoInventoryUpdateNtf ntf, HippoInventoryChangeList changeList)
	{
	}

	private void UpdateBackpackDataTcp(HippoInventoryChangeList list)
	{
	}

	public int GetAttachmentSlot(IHippoCrisisBackPackItemUIData item)
	{
		return 0;
	}

	public bool IsCanOperateBackpackEquipment()
	{
		return false;
	}

	public void BackpackSafeBoxStoreToInventory()
	{
	}

	public uint GetAllItemNumInBackpackBoxById(uint itemId)
	{
		return 0u;
	}

	public string WeightFormat(int weight, bool isShowDecimal = true)
	{
		return null;
	}

	public bool CheckEquipingBagCanMove()
	{
		return false;
	}

	public void AfterMatch(MatchStats stats)
	{
	}

	private void _003CRequestHippoCrisisDescs_003Eb__65_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestHippoCrisisGetInfo_003Eb__67_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestHippoCrisisInventorySell_003Eb__76_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestHippoCrisisInventoryWarehouseUpgrade_003Eb__77_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestHippoCrisisInventoryRepair_003Eb__78_0(HttpErrorCode errorCode, object res)
	{
	}

	private int _003CCheckCanEquipItemFromContainer_003Eb__186_0(int a, int b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
