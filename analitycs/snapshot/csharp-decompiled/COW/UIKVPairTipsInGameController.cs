using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIKVPairTipsInGameController : UIPopupWindowController
{
	private UIKVPairTipsInGameView m_View;

	private Action m_CloseCallBack;

	private UIRoot m_UIRoot;

	private int m_ItemHeight;

	private float m_Padding;

	private int m_ItemCnt;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void AddData(string key, string value)
	{
	}

	public void SetCloseCallBack(Action action)
	{
	}

	public void SetItemPosAndShow(Vector3 pos)
	{
	}

	private void OnMaskClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
