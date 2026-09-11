using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIModelDressUp : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__42_0;

		internal void _003COnRequestDressUpChooseSlotsSuccess_003Eb__42_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public List<uint> temp2;

		public UIModelDressUp _003C_003E4__this;

		public bool uselog;

		public bool refresh;

		public bool playvfx;

		public uint backpackid;

		public uint slotid;

		public Action _003C_003E9__2;

		internal void _003CEquipInfoFromList_003Eb__0()
		{
		}

		internal void _003CEquipInfoFromList_003Eb__2()
		{
		}

		internal void _003CEquipInfoFromList_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public UIModelDressUp _003C_003E4__this;

		public bool playvfx;

		internal void _003CSendCardInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public UIModelDressUp _003C_003E4__this;

		public bool newEvoPass;

		internal void _003CUnLockCardInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public UIModelDressUp _003C_003E4__this;

		public bool newEvoPass;

		internal void _003CGetCardInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const int DressUpMaxNum = 12;

	public int DressupMaxSlotCount;

	private Dictionary<uint, List<uint>> m_DressupIndexToDressList;

	private List<uint> m_DressupCacheList;

	private List<uint> m_SlotIds;

	private Dictionary<uint, int> m_LegendItemLevelCache;

	private bool m_IsCacheValid;

	private uint m_CurrentDressUpIndex;

	private bool m_HasUnlockedIndex;

	private bool m_HasEvogunVipIndex;

	private bool _003CRequestedGetUnlockedFittingSlots_003Ek__BackingField;

	public bool ForceRefreshSlot;

	public const uint PropID_GetUnlockedFittingSlots = 1u;

	public const uint PropID_UnlockSlotAfterGetEvoPass = 2u;

	public List<uint> DressUpCollectionTypeList;

	public bool RequestedGetUnlockedFittingSlots
	{
		get
		{
			return _003CRequestedGetUnlockedFittingSlots_003Ek__BackingField;
		}
		set
		{
			_003CRequestedGetUnlockedFittingSlots_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool CheckCacheCanEquip()
	{
		return false;
	}

	public void EquipCacheItemid(uint id)
	{
	}

	public List<uint> GetCurrentEquipInfo()
	{
		return null;
	}

	public bool CheckCacheHasInvaildFemale()
	{
		return false;
	}

	public bool CheckHasDiffBetweenEquip()
	{
		return false;
	}

	public void ClearDressCache()
	{
	}

	public void EnterFirst()
	{
	}

	private void RefreshCollectionListByMultiSelect(List<uint> collection)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public uint GetCurrentIndexValById(uint id)
	{
		return 0u;
	}

	public uint GetReallyCurrentIndexById(UIModelNewVault.eSecondTab tab)
	{
		return 0u;
	}

	public uint ExchangeTabToIndex(UIModelNewVault.eSecondTab tab)
	{
		return 0u;
	}

	public UIModelNewVault.eSecondTab ExchangeIndexToTab(int index)
	{
		return UIModelNewVault.eSecondTab.None;
	}

	private uint GetDefaultClothByIndex(int index)
	{
		return 0u;
	}

	public uint ExchangeIdToIndex(uint id)
	{
		return 0u;
	}

	public uint GetCurrentDressupIndex()
	{
		return 0u;
	}

	public void ExchangeSlotIndex(uint index)
	{
	}

	public void ExchangeSlot(uint index)
	{
	}

	public bool IsFirstCard()
	{
		return false;
	}

	public bool JudgeCardIsEmpty(uint index)
	{
		return false;
	}

	private bool JudgeListIsEmpty(List<uint> temp)
	{
		return false;
	}

	public List<ResourceID> GetDressUpNeedDownloadResList(uint slotID)
	{
		return null;
	}

	public void EquipInfoFromList(List<uint> temp, bool playvfx = false, bool refresh = true, bool uselog = false, uint slotid = 0u)
	{
	}

	private void OnRequestDressUpChooseSlotsSuccess(bool uselog, bool refresh, bool playvfx, uint backpackId, uint slotid)
	{
	}

	private UIModelAvatarBase.EClothGenderType GetGenderType(uint index)
	{
		return UIModelAvatarBase.EClothGenderType.GENDERTYPENONE;
	}

	public DressUpCardState GetDressUpStateByIndex(uint index)
	{
		return DressUpCardState.None;
	}

	private void UpdateAvatarClothData(uint itemID)
	{
	}

	public void SaveCurrentCacheToReally(uint saveSlotId)
	{
	}

	public void SaveReallyToCurrentCache(uint index)
	{
	}

	public void LegendCacheExpire()
	{
	}

	public void CacheLegendLevel(uint id, int level)
	{
	}

	public uint FindEmptyCard()
	{
		return 0u;
	}

	public bool CheckNotHasDiff()
	{
		return false;
	}

	public void SaveByIndex(uint index, List<uint> temp)
	{
	}

	public override void Init()
	{
	}

	private void InitDressUpListData()
	{
	}

	private void InitList(List<uint> temp)
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<uint> GetDressUpListByIndex(uint index)
	{
		return null;
	}

	public void ModifyItem(uint id)
	{
	}

	public List<uint> GetDressUpCacheList()
	{
		return null;
	}

	public uint GetDressUpCacheIdByIndex(int index)
	{
		return 0u;
	}

	public List<uint> GetSlotIds()
	{
		return null;
	}

	public void SendCardInfo(uint index, bool playvfx = false, bool getItemIdsFromCache = false)
	{
	}

	public void UnLockCardInfo(bool newEvoPass = false)
	{
	}

	public void GetCardInfo(uint http_option = 4u, LoadingType loadingType = LoadingType.CircleLoading, bool newEvoPass = false, bool sendImmediately = false)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
