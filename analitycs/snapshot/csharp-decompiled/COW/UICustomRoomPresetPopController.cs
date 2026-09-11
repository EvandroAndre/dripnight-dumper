using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

internal class UICustomRoomPresetPopController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UICustomRoomPresetPopView m_View;

	private RoomCreateReq m_PresetData;

	private UIModelCustomRoom m_ModelRoom;

	private UICustomRoomPresetItemController m_ItemCtrl;

	private List<UIRoomGameSettingItemController> m_CustomRoomDropListItemList;

	private bool m_IsWaitingRoomCard;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(uint gameMode)
	{
	}

	private void RefreshRoomDataToggles(List<UIRoomBaseController.RoomGameSettingData> gameSettingDataList)
	{
	}

	private void OnCreateRoomClick()
	{
	}

	private void ShowNormalConfirmPop()
	{
	}

	private void ConfirmCreateRoom()
	{
	}

	protected proto.EInventory.ItemSubType GetCurrentRoomCardType()
	{
		return proto.EInventory.ItemSubType.ItemSubType_NONE;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnCreateRoomClick_003Eb__13_0(string s)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
