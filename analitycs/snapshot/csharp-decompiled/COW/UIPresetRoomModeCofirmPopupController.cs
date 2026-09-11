using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIPresetRoomModeCofirmPopupController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIPresetRoomModeCofirmPopupView m_View;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelOptionalDownload m_ModelDownload;

	private MapModeData m_MapModeData;

	private PresetRoomCreateRuleInfo m_RuleInfo;

	private DropListConfigInfo m_DropInfo;

	private ERoom.TabType m_RoomTabType;

	private List<UIPresetRoomModeCofirmTagController> m_TagControllers;

	private List<RoomBasicInfo> m_RoomList;

	private List<ulong> m_LocalFailRoomIds;

	private RoomBasicInfo m_CurrentQuickJoinRoomInfo;

	private uint m_MaxRefreshTime;

	private uint m_CurrentRefreshTime;

	private bool m_HaveQuickJoinRequest;

	private bool m_IsQuickJoinCountDown;

	private UICountDownLabel m_CreateCountDownLabel;

	private UICountDownLabel m_QuickJoinCountDownLabel;

	private CountDownConfig m_QuickJoinCountDownConfig;

	private const string CreateRoomLabelKey = "TXT_ROOM_LOBBY_CREATE";

	private const string QuickJoinLabelKey = "T_35_ZF_ROOM_QUICKJOIN";

	private uint QuickJoinCoolDownSeconds => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(MapModeData mapModeData, PresetRoomCreateRuleInfo ruleInfo, DropListConfigInfo dropInfo)
	{
	}

	private void RefreshCDN()
	{
	}

	private void RefreshTags()
	{
	}

	private ERoom.TabType ChangeRoomType2TabType(ERoom.Type roomType)
	{
		return ERoom.TabType.TabType_NONE;
	}

	private void RequestPresetRoomList()
	{
	}

	private void RefreshRoomListCache()
	{
	}

	private void AddPresetRooms(List<RoomBasicInfo> rooms)
	{
	}

	private bool IsRoomMatchPreset(RoomBasicInfo roomInfo)
	{
		return false;
	}

	private bool CanDoRoomAction()
	{
		return false;
	}

	private UICountDownLabel GetOrAddCountDownLabel(UILabel label)
	{
		return null;
	}

	private void RefreshButtonLabels()
	{
	}

	private void RefreshCreateRoomLabel()
	{
	}

	private bool TryGetPresetCreateRoomCoolDownEndTime(out ulong coolDownEndTime)
	{
		coolDownEndTime = default(ulong);
		return false;
	}

	private void RefreshQuickJoinLabel()
	{
	}

	private void OnQuickJoinCountDownStarted()
	{
	}

	private void OnQuickJoinCountDownEnded()
	{
	}

	private void OnBtnCreateRoom()
	{
	}

	private bool NeedDownloadMap()
	{
		return false;
	}

	private void OnBtnQuickJoin()
	{
	}

	private void LogPresetRoomClick(string clickName)
	{
	}

	private string GetPresetSlotLogValue()
	{
		return null;
	}

	private void QuickJoinRoom()
	{
	}

	private bool CanQuickJoinRoom(RoomBasicInfo roomInfo, List<ulong> failRoomList)
	{
		return false;
	}

	private void RecordJoinFailRoom(object[] param)
	{
	}

	private uint GetRoomSettingValue(uint roomSetting, ECustomRoomSetting3 start, ECustomRoomSetting3 end)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
