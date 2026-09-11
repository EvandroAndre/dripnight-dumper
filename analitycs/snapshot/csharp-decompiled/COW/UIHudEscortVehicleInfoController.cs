using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudEscortVehicleInfoController : UIBaseController
{
	private UIHudEscortVehicleInfoView m_View;

	private BPKGNCEDKAL mGame;

	private static readonly Color HP_COLOR_YELLOW;

	private static readonly Color HP_COLOR_GREEN;

	private static readonly Color HP_COLOR_RED;

	private UIGuideTipsController m_GuideTipsCtrl;

	private UIHudCommonlTipsController m_CurrentTips;

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

	private void OnBtnBodyTipClick()
	{
	}

	private void OnBtnWheelTipClick()
	{
	}

	private void OnBtnStatusTipClick()
	{
	}

	private void OnWheelHPChanged(object[] data)
	{
	}

	private void OnBodyHPChanged(object[] data)
	{
	}

	private void OnStatusChanged(object[] data)
	{
	}

	private void UpdateWheelHPUI()
	{
	}

	private void UpdateBodyHPUI()
	{
	}

	private void UpdateStatusUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
