using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTokenCustomReviveController : UIBaseController
{
	private UIHudTokenCustomReviveView m_View;

	private bool m_IsCountdownActive;

	private UIColor[] m_TeammateColors;

	private bool m_UpdateProtectingState;

	private UIClickMask m_TipsMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void RefreshProtectingState()
	{
	}

	public void SetView(GEvent evt)
	{
	}

	private void OnBtnClick(GameObject go)
	{
	}

	private void RefreshTipsPanel(bool isShow)
	{
	}

	private void DestroyTipsMask()
	{
	}

	private void RefreshCountdownState(GEvent evt)
	{
	}

	private void _003CRefreshTipsPanel_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
