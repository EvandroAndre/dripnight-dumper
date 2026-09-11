using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class AutoPickUpHelper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<string, uint> _003C_003E9__23_0;

		internal uint _003C_002Ector_003Eb__23_0(string s)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public int type;

		internal void _003CFreezeAutoPickup_003Eb__0()
		{
		}
	}

	private Queue<ICLMFONIIKB> m_AutoPickupQueue;

	private bool m_PickupQueueSorted;

	private List<ICLMFONIIKB> m_PickupInContainer;

	private uint m_AutoPickupDelayCall;

	private uint[] PickupListNewModes;

	private static bool pauseAutoPickup;

	private static bool m_AutoPickupSwitch;

	private Player m_LocalPlayer;

	public BountyPickupStatus m_BountyStatus;

	private static List<AutoPickupConfigData> m_AutoPickConfigList;

	private static Dictionary<int, Dictionary<uint, AutoPickupConfigData>> m_ItemIDToDataDict;

	private static Dictionary<int, int> m_ChildTypeToParentTypeID;

	private static Dictionary<uint, int> m_GameModeToTypeDic;

	private static bool hasInit;

	private static Dictionary<uint, int> m_TemporaryCloseIDToTypeDict;

	private static Dictionary<int, bool> m_TemporaryCloseTypeOpenStateDict;

	private static Dictionary<int, uint> m_TemporaryCloseTypeDelayCallDict;

	private static HashSet<int> m_TemporaryCloseIDToAttachmentEquipment;

	private static readonly Dictionary<int, AutoPickupConfigData> m_AutoPickupDataDict;

	private static readonly Dictionary<int, int> m_AutoPickupIDToType;

	private static readonly Dictionary<int, List<AutoPickupConfigData>> m_TypeToPrioritySortedList;

	private List<ResourceID> weaponRids;

	private OMELKCOGCBK m_InventoryManager => null;

	public Dictionary<int, Dictionary<uint, AutoPickupConfigData>> ItemIDToDataDict => null;

	public void StartAutoPickup()
	{
	}

	private void DoPickupCache()
	{
	}

	public static void SetAutoPickupSwitch(bool isOn)
	{
	}

	public static void SetAutoPickupPaused(bool isPaused)
	{
	}

	public void StopAutoPickup(bool changedBySetting = false)
	{
	}

	public static void ResetAutoPickUpTemporaryTypeOpenState()
	{
	}

	private void DoAutoPickUp()
	{
	}

	private void SortAutoPickQueue()
	{
	}

	private int SortAutoPickByCapcity(ICLMFONIIKB pickUp)
	{
		return 0;
	}

	public void SetPickUpList(List<ICLMFONIIKB> pickupList)
	{
	}

	public void RefreshAutoPickUpList()
	{
	}

	public bool GetAutoPickupState(ICLMFONIIKB pickup)
	{
		return false;
	}

	public static void LoadAutopickupTemporaryCloseData()
	{
	}

	private void TryAddAutopickupTemporaryCloseData(int type)
	{
	}

	public void FreezeAutoPickup(uint itemID)
	{
	}

	public void FreezeAutoPickupAttachmentEquipment(uint itemID)
	{
	}

	private bool IsAttachmentEquipFreeze(uint itemID)
	{
		return false;
	}

	public static bool EnableAutoPickupFunction()
	{
		return false;
	}

	public static bool CSPhaseForbidAutoPickup()
	{
		return false;
	}

	public void SortPickupList(List<ICLMFONIIKB> pickUps)
	{
	}

	public int AutoPickupSort(ICLMFONIIKB x, ICLMFONIIKB y)
	{
		return 0;
	}

	public int AutoPickupSortHippoCrisis(ICLMFONIIKB x, ICLMFONIIKB y)
	{
		return 0;
	}

	public void SortNotAutoPickupList(List<ICLMFONIIKB> pickUps)
	{
	}

	public int AutoNotAutoPickupSort(ICLMFONIIKB x, ICLMFONIIKB y)
	{
		return 0;
	}

	public static List<AutoPickupConfigData> GetAutoPickUpConfigDataList()
	{
		return null;
	}

	public static List<AutoPickupConfigData> GetSettingTypeAutoPickupItemList(int type, bool filter = false, bool available = true)
	{
		return null;
	}

	public static List<AutoPickupConfigData> GetAllAutoPickupItemListBySettingType(int type)
	{
		return null;
	}

	public static AutoPickupConfigData GetPickupSpeedConfig()
	{
		return null;
	}

	public static List<AutoPickupConfigData> GetPrioritySortedItemListWithSettingType(int type)
	{
		return null;
	}

	public static AutoPickupConfigData GetAutoPickupItemWithID(int id)
	{
		return null;
	}

	public static void ResetAllAutoPickupItemPreferenceWithType(int type)
	{
	}

	public static void CreateAutoPickupItemDictAndOrderList()
	{
	}

	public static void CreateAutoPickupTypeMapping()
	{
	}

	public static void SetAutoPickupItemActive(AutoPickupConfigData configData, bool active)
	{
	}

	private static void InsertParentAutoPickupItemPriority(AutoPickupConfigData sourceConfig, AutoPickupConfigData targetConfig, bool up)
	{
	}

	private static void InsertChildAutoPickupItemPriority(AutoPickupConfigData sourceConfig, AutoPickupConfigData targetConfig, bool up)
	{
	}

	private static int InsertPriorityUpOrDown(int targetOrder, int sourceOrder, List<AutoPickupConfigData> sortedList, bool up)
	{
		return 0;
	}

	public static void InsertActiveAutoPickupItemPriority(int sourceId, int targetId, bool up)
	{
	}

	public static int GetAutoPickupSettingTypeWithGameMode(uint gameMode)
	{
		return 0;
	}

	public static AutoPickupConfigData GetAutoPickupSettingByType(int itemType, int itemSubType, uint itemID = 0u)
	{
		return null;
	}

	public static bool InitAutoPickUpKeyMap(bool forceRefresh = false)
	{
		return false;
	}

	public static void UploadUserSetting(SettingDetail request)
	{
	}

	private static void DownloadUserSettingV0(SettingDetail result)
	{
	}

	private static void DownloadUserSettingV1(SettingDetail result)
	{
	}

	public static void DownloadUserSetting(SettingDetail result)
	{
	}

	public static EAutoPickup GetTransferAutoPickupSystemStatus(int statusFromCloud)
	{
		return EAutoPickup.On;
	}

	private int _003CSortAutoPickQueue_003Eb__34_0(ICLMFONIIKB a, ICLMFONIIKB b)
	{
		return 0;
	}
}
