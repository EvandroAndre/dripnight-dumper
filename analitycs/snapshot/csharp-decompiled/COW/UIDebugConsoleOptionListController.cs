using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleOptionListController : UIBaseController, IEasyList
{
	private UIDebugConsoleOptionListView m_View;

	private Action<string> m_OptionHandler;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void InitData(List<string> options, Action<string> handler)
	{
	}

	public void OnOptionSelect(string option)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
