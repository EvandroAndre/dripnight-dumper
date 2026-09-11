using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarFrameSelectWndController : UIPopupWindowController, IEasyList
{
	private UIAvatarFrameSelectWndView m_View;

	private Action m_CloseCallback;

	private UIClickMask m_ClickMask;

	private UIModelCollection m_ModelCollection;

	private int m_DataCount;

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

	public int GetDataCount()
	{
		return 0;
	}

	public void SetCloseCallback(Action callback)
	{
	}

	protected override void OnUIDestory()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
