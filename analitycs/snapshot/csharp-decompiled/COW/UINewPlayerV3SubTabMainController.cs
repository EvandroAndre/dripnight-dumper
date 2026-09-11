using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UINewPlayerV3SubTabMainController : UIBaseController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public int day;

		public UINewPlayerV3SubTabMainController _003C_003E4__this;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UINewPlayerV3SubTabMainView m_View;

	private List<NewPlayerSubTabData> m_SubTabDataList;

	private Action<int> m_SubTabCallBack;

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

	public void SetViewData(Action<int> subTabCallBack)
	{
	}

	private void OnSubTabItemClick(int day)
	{
	}

	public void SelectTabItemByIndex(int index)
	{
	}

	public void ScrollToSpecific(int curday)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
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
