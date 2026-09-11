using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudSFRoleplaySelectPopupWndController : UIPopupWindowController
{
	private UIHudSFRoleplaySelectPopupWndView m_View;

	private UIClickMask m_ClickMask;

	private Action m_ClickMaskTriggerHandler;

	private readonly List<UIHudSFRoleplaySelectItemController> m_ItemCtrls;

	private readonly List<UIHudSFRoleCabinRoleInfoItem> m_CabinItemCtrls;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void SetupClickMask()
	{
	}

	private void TryDestroyClickMask()
	{
	}

	private void OnClickMaskTriggered()
	{
	}

	public void SetViewData()
	{
	}

	public void SetCabinViewData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
