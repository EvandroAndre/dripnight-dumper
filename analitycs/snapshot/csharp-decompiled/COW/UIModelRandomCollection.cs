using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelRandomCollection : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<uint, string> _003C_003E9__96_0;

		internal string _003CSaveMultiSelectDataToPlayerPrefs_003Eb__96_0(uint id)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int weaponID;

		internal bool _003CGetSlotIndexByWeaponID_003Eb__0(uint a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public Dictionary<int, List<int>>.Enumerator itor;

		public Predicate<RandomSlotInfo> _003C_003E9__0;

		internal bool _003CGetEquipMutliSelectRandomInfos_003Eb__0(RandomSlotInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public UIModelRandomCollection _003C_003E4__this;

		public bool isChangeMultiState;

		public bool isShowFastEquip;

		public List<uint> autoEquipSkinIds;

		public uint weaponSkinLobbyWeaponID;

		public Action callback;

		internal void _003CRequestChooseRandomSlots_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_MultiSelectUpdate = 2u;

	public const uint propID_ShowFastEquipOK = 4u;

	public const string MUTLI_SELECT_MAX_LIMIT_TIPS = "BR_INVENTORY_RANDOM_SKIN_NUM_LIMITED";

	public static readonly int AUTO_MUTLI_SELECT_MAX_LIMIT;

	public static readonly int MUTLI_SELECT_MAX_LIMIT;

	public static readonly uint MUTLI_SELECT_CACHE_COMPOSITE_VALUE;

	private UIModelCollection m_ModelCollection;

	private readonly Dictionary<uint, List<uint>> m_MultiSelectTypeIDToSkinsCacheDic;

	private readonly Dictionary<uint, uint> m_InGameSkillIDToRandomSkinID;

	private List<RandomSlotInfo> m_CurRandomSlotInfo;

	private List<uint> m_CollectionSubTypeUseRandomSlot;

	private const string RANDOM_COLLECTION_PREFS_PREFIX = "RandomCollection_";

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public int GetSlotIndexBySkinID(int skinID)
	{
		return 0;
	}

	public int GetSlotIndexByWeaponID(int weaponID)
	{
		return 0;
	}

	public UIWeaponSkinLobbyMainController.ECollectionMultiSelectEquipBtnState GetEquipBtnState(int skinID, int weaponID)
	{
		return UIWeaponSkinLobbyMainController.ECollectionMultiSelectEquipBtnState.none;
	}

	public bool IsOpenMultiSelectByRandomSlotWeapon(uint weaponID)
	{
		return false;
	}

	public bool IsMultiSelectEquipedByRandomSlot(int skinID, int slotIndex)
	{
		return false;
	}

	public int GetMultiSelectNum(int weaponID)
	{
		return 0;
	}

	public uint MutliIds2SingleID(uint[] ids)
	{
		return 0u;
	}

	private ulong GetCurGroupID()
	{
		return 0uL;
	}

	private RandomSlotInfo CloneRandomSlotInfo(RandomSlotInfo temp)
	{
		return null;
	}

	private RandomSkinInfo CloneRandomSkinInfo(RandomSkinInfo temp)
	{
		return null;
	}

	private int GetWeaponIDBySkinID(int skinID)
	{
		return 0;
	}

	private uint CompareMutliID(uint cur, uint next)
	{
		return 0u;
	}

	private uint GetLowestPrioritySkinToRemove(uint subCollection, uint secondaryID)
	{
		return 0u;
	}

	private bool CheckSubCollectionHasRandomSlotInfo(uint slotIndex, uint subCollectionType)
	{
		return false;
	}

	private int GetSubCollectionBySlotID(int slotIndex)
	{
		return 0;
	}

	public bool GetWeaponIDBySlotIndex(int slotIndex, out uint weaponID)
	{
		weaponID = default(uint);
		return false;
	}

	public uint GetFirstCollectionIDCacheSelect(List<WeaponSkinBaseInfo> weapons)
	{
		return 0u;
	}

	public void ChangeMultiOrSelectStateInCustomForSingle(uint uniqueID)
	{
	}

	public void ChangeMultiOrSelectStateInCustomForRandom(uint uniqueID, List<uint> skinIDList)
	{
	}

	public List<uint> GetCollectionIDByWeaponSkinBaseInfo(List<WeaponSkinBaseInfo> weapons)
	{
		return null;
	}

	public bool IsRandomSelectOpenInCustomWeapon(uint weaponID)
	{
		return false;
	}

	public List<uint> GetRandomSkinIDsInCustomWeapon(uint weaponID)
	{
		return null;
	}

	public bool IsCustomWeaponMultiSelected(uint weaponID, uint skinID)
	{
		return false;
	}

	private List<uint> GetCollectionIDByNewVaultData(List<UINewVaultItemViewData> newVaultItemViewDatas)
	{
		return null;
	}

	public void ChangeMultiOrSelectStateInVaultForSingle(uint collectionType, uint uniqueID)
	{
	}

	public void ChangeMultiOrSelectStateInVaultForRandom(uint collectionType, uint uniqueID, List<UINewVaultItemViewData> dataList, uint equipSkinID)
	{
	}

	public bool UpdateMultiSelectCache(uint collectionType, uint uniqueID, uint skinID, bool isEquip = false, bool forceReplace = false)
	{
		return false;
	}

	public bool CheckCanMultiSelectInAutoEquip(uint collectionType, uint uniqueID)
	{
		return false;
	}

	public bool SetMultiSelectCacheDic(uint subCollection, uint secondaryID, uint skinID)
	{
		return false;
	}

	private void SetMultiSelectCacheDicBatch(uint subCollection, uint secondaryID, List<uint> skinIDs)
	{
	}

	public void RemoveMultiSelectCacheDic(uint subCollection, uint secondaryID, uint skinID)
	{
	}

	private bool IsMultiSelectCacheReachMaxLimit(uint subCollection, uint secondaryID)
	{
		return false;
	}

	public bool IsMultiSelectReachMaxLimitFromSource(uint subCollection, uint uniqueID)
	{
		return false;
	}

	private int GetWeaponMultiSelectCountFromSource(uint weaponID)
	{
		return 0;
	}

	private int GetSkillEffectMultiSelectCountFromSource(uint skillID)
	{
		return 0;
	}

	private int GetOtherCollectionMultiSelectCountFromSource(uint subCollection, uint uniqueID)
	{
		return 0;
	}

	private bool IsMultiSelectCacheReachMinLimit(uint subCollection, uint secondaryID)
	{
		return false;
	}

	public bool IsMultiSelectOpenInCache(uint subCollection, uint secondaryID)
	{
		return false;
	}

	public uint GetSlotIndexByCollectionSubType(uint collectionSubType)
	{
		return 0u;
	}

	public List<uint> GetMultiSelectCacheSkinIDs(uint subCollection, uint secondaryID)
	{
		return null;
	}

	public bool CheckMultiSelectCacheExist(uint subCollection, uint secondaryID, uint skinID)
	{
		return false;
	}

	public void ClearMultiSelectCache(uint subCollection, uint secondaryID)
	{
	}

	public bool NeedRequestMultiSelectInRandomSkin(uint collectionSubType, uint uniqueID)
	{
		return false;
	}

	public bool NeedRequestMultiSelectInRandomSlot(uint collectionSubType, uint uniqueID, uint slotID)
	{
		return false;
	}

	private bool MultiSelectSkinIDsInRandomSkinCompare(List<uint> listCache, List<uint> listServer)
	{
		return false;
	}

	public uint[] GetReqMultiSelectCacheSkinIDs(uint subCollection, uint secondaryID)
	{
		return null;
	}

	public RandomSkinInfo GetReqMultiSelectCacheSkinInfo(uint subCollection, uint uniqueID)
	{
		return null;
	}

	public List<RandomSkinInfo> GetReqMultiSelectCacheSkinInfos(uint subCollection, uint uniqueID)
	{
		return null;
	}

	private RandomSkinInfo ProcessRandomSkinInfo(uint subCollection, uint uniqueID, List<uint> skinIDs)
	{
		return null;
	}

	public List<RandomSkinInfo> GetReqRandomInfosSpecificFromCache(uint subCollection)
	{
		return null;
	}

	public List<RandomSkinInfo> GetRandomCollectionActions(out List<uint> toEquipActions)
	{
		toEquipActions = null;
		return null;
	}

	public void SetRandomSkillSkinOnJoinMatch()
	{
	}

	public uint GetInGameRandomSkinIDBySkillID(uint skillID)
	{
		return 0u;
	}

	public List<RandomSlotInfo> GetEquipMutliSelectRandomInfos(Dictionary<int, List<int>> dic, out bool isAllowEquip)
	{
		isAllowEquip = default(bool);
		return null;
	}

	public void UnequipMultiSelect(int skinID, int weaponID)
	{
	}

	public void EquipMultiSelect(int skinID, int weaponID)
	{
	}

	public void ChangeMultiOrSelectState(int weaponID, EInventory.SlotChooseType slotChooseType, List<WeaponSkinBaseInfo> weapons)
	{
	}

	public void RequestChooseRandomSlotsExceptWeapon(uint collectionType, uint uniqueID, bool isFastEquip = false, Action callback = null)
	{
	}

	private List<RandomSlotInfo> GetUpdateRandomSlotInfosExceptWeapon(uint collectionType, uint uniqueID)
	{
		return null;
	}

	public void RequestChooseRandomSlotsByRandomSlotInfos(List<RandomSlotInfo> randomSlotInfos, bool isFastEquip, List<uint> autoEquipSkinIds = null)
	{
	}

	private void UpdateRandomSlotInfo(List<RandomSlotInfo> tempRandomSlotInfos, uint collectionSubType, uint uniqueID, uint slotID, bool OnlyAdd = false)
	{
	}

	public List<RandomSlotInfo> GetReqAllRandomSlotInfos()
	{
		return null;
	}

	private void RequestChooseRandomSlots(List<RandomSlotInfo> randomSlotInfos, bool isChangeMultiState = false, bool isShowFastEquip = false, uint weaponSkinLobbyWeaponID = 0u, List<uint> autoEquipSkinIds = null, Action callback = null)
	{
	}

	public void RequestBatchRandomCustomWeaponsInAutoEquip(HashSet<uint> weaponIDs, List<uint> selectSkinIDs)
	{
	}

	public void SyncMultiSelectCacheFromRandomSlotInfoExceptWeapon(uint collectionSubType, uint secondaryID)
	{
	}

	public void SyncMultiSelectCacheFromRandomSkinInfo(uint collectionSubType, uint secondaryID)
	{
	}

	public void SyncMultiSelectCacheFromWeaponSkinCustom(uint weaponID)
	{
	}

	public void SyncAllMultiSelectRandomData()
	{
	}

	private List<uint> GetValidSkinIDs(uint[] randomSkinIDs)
	{
		return null;
	}

	public uint GetMultiSelectEquipFirstItemID(uint subCollection, uint uniqueID)
	{
		return 0u;
	}

	public bool IsMultiSelectOpen(uint subCollection, uint uniqueID)
	{
		return false;
	}

	public bool IsOpenMultiSelectByWeaponID(int weaponID)
	{
		return false;
	}

	public List<uint> GetMultiSelectSkinIDsInSlot(uint subType)
	{
		return null;
	}

	public bool IsMultiSelectEquipped(uint subCollection, uint uniqueID, uint skinID)
	{
		return false;
	}

	public void GetGotoParamsWithWeaponSkin(uint skinID, out uint gopos, out string subParam)
	{
		gopos = default(uint);
		subParam = null;
	}

	public bool UpdateCurSlotInfo()
	{
		return false;
	}

	public List<RandomSlotInfo> GetFixedCurRandomSlot()
	{
		return null;
	}

	public void RequestUpdateFixedRandomInfo()
	{
	}

	public bool IsSlotChanged()
	{
		return false;
	}

	public void RequestUpdateFixedSlots()
	{
	}

	private string GetRandomCollectionPrefsKey(uint collectionType, uint uniqueID)
	{
		return null;
	}

	public void SaveMultiSelectDataToPlayerPrefs(uint collectionType, uint uniqueID)
	{
	}

	public List<uint> LoadMultiSelectDataFromPlayerPrefs(uint collectionType, uint uniqueID)
	{
		return null;
	}

	private List<uint> ValidateOwnedSkinIDs(List<uint> skinIDs)
	{
		return null;
	}

	public void ChangeMultiOrSelectStateInVaultForSingleWithSave(uint collectionType, uint uniqueID)
	{
	}

	public void ChangeMultiOrSelectStateInVaultForRandomWithRestore(uint collectionType, uint uniqueID, List<UINewVaultItemViewData> dataList, uint equipSkinID)
	{
	}

	public void ChangeMultiOrSelectStateInCustomForSingleWithSave(uint uniqueID)
	{
	}

	public void ChangeMultiOrSelectStateInCustomForRandomWithRestore(uint uniqueID, List<uint> skinIDList)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
