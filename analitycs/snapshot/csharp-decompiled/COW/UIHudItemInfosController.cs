using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudItemInfosController : UIBaseController
{
	private class ItemEntry
	{
		public uint UniqueId;

		public uint Count;

		public int CoolDownTimeMs;

		public int CoolDownRemainTimeMs;

		public float CDSyncedServerTimeSec;

		public int RemainCount;
	}

	private class SlotInventory
	{
		public Dictionary<uint, ItemEntry> Entries;

		public List<uint> OrderedDataIDs;

		public uint CurrentDataID;

		public void Clear()
		{
		}
	}

	private class MedkitIconPriority
	{
		public readonly List<int> ShowTypes;
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public UISprite sprite;

		internal void _003CSetIconClamped_003Eb__0()
		{
		}
	}

	private const int SlotCount = 4;

	private readonly SlotInventory[] m_Slots;

	private readonly Dictionary<uint, MedkitIconPriority> m_MedkitPriorityDict;

	private const int EMedkitType_Medkit = 0;

	private const int EMedkitType_Inhaler = 1;

	private const int EMedkitType_SuperMedkit = 2;

	private const int EMedkitType_PED = 3;

	private bool m_TrackedIsFastRunning;

	private bool m_TrackedIsInhalering;

	private bool m_TrackedIsUsingPED;

	private uint m_LastSyncPid;

	private UIHudItemInfosView m_View;

	private Player m_CurrentTrackingPlayer;

	private List<CureGearSettingData> m_CureGearSettingData;

	private const string DefaultGrenadeSpriteName = "UI_icon_Grenade";

	private const string DefaultIceWallSpriteName = "UI_icon_GlooShield";

	private const string InfiniteCountText = "∞";

	private const int MaxIconSize = 46;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	private void InitTrackingItemStateFromModel()
	{
	}

	private void InitMedkitPriorityDict()
	{
	}

	private bool IsValidObserverTypeForShow()
	{
		return false;
	}

	private void RefreshVisibleByObserverType()
	{
	}

	private void SyncTrackingPlayerFromObserver()
	{
	}

	private void Update()
	{
	}

	private void PollTrackedPlayerStateForMedkit()
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnAddObserver(uint data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void DiscardSlotsIfStale()
	{
	}

	private void OnTrackingItemStateChanged(object[] data)
	{
	}

	private void OnTrackingItemStateUpdate(object[] data)
	{
	}

	private void OnNewItemOnHand(object[] data)
	{
	}

	private void OnTrackedPlayerHPChanged(GEvent data)
	{
	}

	private void OnTrackedPlayerEPChanged(GEvent data)
	{
	}

	private void OnInhalerOrPEDUseFinished(object[] data)
	{
	}

	private void ClearAllSlots()
	{
	}

	private void ApplySingleItemState(PPCMIEPMLNN item, float nowSec, bool isFromUpdate)
	{
	}

	private void RecomputeCurrentDataID(OBBFMHDPJNC slotKind)
	{
	}

	private static bool IsEntryUsable(uint dataID, ItemEntry entry, bool isTechDeviceSlot)
	{
		return false;
	}

	private void RecomputeMedkitCurrentDataID()
	{
	}

	private uint GetMedkitDataIDForType(int medkitType)
	{
		return 0u;
	}

	private static bool TryStockedMedkitID(SlotInventory slot, uint dataID)
	{
		return false;
	}

	private uint TryPromoteToSuperMedkit(Player p, SlotInventory slot, uint medkitDataID)
	{
		return 0u;
	}

	private void RecomputeMedkitAndRefresh()
	{
	}

	private void ApplyHandToCurrent()
	{
	}

	private void RefreshAll()
	{
	}

	private void RefreshSlot(OBBFMHDPJNC slot)
	{
	}

	private uint CurrentDataIDOf(OBBFMHDPJNC slot)
	{
		return 0u;
	}

	private uint CurrentCountOf(OBBFMHDPJNC slot)
	{
		return 0u;
	}

	private ItemEntry CurrentEntryOf(OBBFMHDPJNC slot)
	{
		return null;
	}

	private static bool ShouldHideGrenadeCount(uint dataID)
	{
		return false;
	}

	private static void SetCountLabelVisible(UILabel label, bool visible)
	{
	}

	private static UIHudGrenadeBtnController.ButtonType GetButtonTypeFromDataID(uint dataID)
	{
		return UIHudGrenadeBtnController.ButtonType.None;
	}

	private static void ClampIconSize(UISprite sprite)
	{
	}

	private static void SetIconClamped(UISprite sprite, ResourceID resourceID)
	{
	}

	private static void SetIconClampedByName(UISprite sprite, string spriteName)
	{
	}

	private static ResourceID ResolveItemIcon(uint dataID)
	{
		return default(ResourceID);
	}

	private void RefreshGrenade()
	{
	}

	private static string ResolveGrenadeSpriteName(uint dataID)
	{
		return null;
	}

	private static bool IsIceWallFamily(UIHudGrenadeBtnController.ButtonType bt)
	{
		return false;
	}

	private void RefreshIceWall()
	{
	}

	private static string ResolveIceWallSpriteName(uint dataID)
	{
		return null;
	}

	private void RefreshMedkit()
	{
	}

	private ResourceID ResolveMedkitIcon(uint dataID, out string iconSource)
	{
		iconSource = null;
		return default(ResourceID);
	}

	private void RefreshTechDevice()
	{
	}

	private static string ResolveDroneSpriteName(uint dataID)
	{
		return null;
	}

	private static ResourceID ResolveTechDeviceIcon(HENEHAGJCLI itemData)
	{
		return default(ResourceID);
	}

	private void RefreshTechDeviceCD()
	{
	}

	private void SetTechDeviceVisible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
