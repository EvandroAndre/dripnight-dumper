using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCDebuggerConsoleItemController : UIEasyListItemController
{
	public Action<int> SelectCallback;

	public Action<int, Vector3> LongPressCallback;

	public Action<int> OnViewDetail;

	public Action<UIUGCDebuggerConsoleItemController, UIModelUGCDebugger.LogData> ShowDetailCallback;

	private UIUGCDebuggerConsoleItemView m_View;

	private BoxCollider m_clickCollider;

	private UIModelUGCDebugger.LogData m_data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshView()
	{
	}

	private void OnEditBtn()
	{
	}

	private void OnDetailBtn()
	{
	}

	private void SetLogLevel(UIModelUGCDebugger.LogDataType level)
	{
	}

	private void OnSelect(bool selected)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
