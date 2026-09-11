using System;
using GCommon;

namespace COW;

internal class UIHudSceneEditMessageController : UIBaseController
{
	private UIHudSceneEditMessageView m_View;

	private UIClickMask m_ClickMask;

	private UIHudSceneEditMessageReservationContentController m_ReservationController;

	public Action<bool> onVisibleChanged;

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

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void RefreshReservationContent()
	{
	}

	public void AddClickMaskRange(UIWidget widget)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
