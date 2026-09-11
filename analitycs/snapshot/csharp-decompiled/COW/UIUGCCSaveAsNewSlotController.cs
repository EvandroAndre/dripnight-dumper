using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCCSaveAsNewSlotController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIUGCCSaveAsNewSlotView m_View;

	private List<UIUGCSaveAsNewSlotItemController> m_CachedList;

	private SceneEditSlotInfo m_SelectedSlotInfo;

	private bool m_ReopenModeSetting;

	private Action<uint> m_CallBack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetCallBack(Action<uint> callback)
	{
	}

	public void SetUIData(SceneEditSlotInfo selected, bool reopenModeSetting = true)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetUIData_003Eb__8_0(uint slotID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
