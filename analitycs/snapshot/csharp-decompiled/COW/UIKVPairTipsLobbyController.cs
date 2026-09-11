using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIKVPairTipsLobbyController : UIPopupWindowController
{
	private UIKVPairTipsLobbyView m_View;

	private Action m_ClickCallback;

	private UIRoot m_UIRoot;

	private int m_ItemHeight;

	private float m_Padding;

	private float m_GotoBtnHeight;

	private int m_ItemCnt;

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

	public void AddData(string key, string value)
	{
	}

	public void SetGoToBtn(bool show, string key = "", Action callBack = null)
	{
	}

	private void RefreshBG()
	{
	}

	private void OnGoToClick()
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
