using System;
using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

internal class UIRoomListSettingPreviewController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<UIRoomBaseController.RoomGameSettingData, bool> _003C_003E9__12_0;

		internal bool _003CSortSettingData_003Eb__12_0(UIRoomBaseController.RoomGameSettingData x)
		{
			return false;
		}
	}

	private UIRoomListSettingPreviewView m_View;

	private RoomBasicInfo m_RoomInfo;

	private UIModelCustomRoom m_ModelRoom;

	private List<UIRoomListSettingPreviewItemController> m_SettingItemList;

	private bool m_CanJoin;

	private bool m_CanOBJoin;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(RoomBasicInfo roomInfo)
	{
	}

	public void UpdatePanelDepth(int depth)
	{
	}

	private void RefreshJoinStatus()
	{
	}

	private void RefreshRoomDataToggles(List<UIRoomBaseController.RoomGameSettingData> gameSettingDataList)
	{
	}

	private List<UIRoomBaseController.RoomGameSettingData> SortSettingData(List<UIRoomBaseController.RoomGameSettingData> gameSettingDataList)
	{
		return null;
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnOBJoinRoomClick()
	{
	}

	private void OnPlayJoinRoomClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
