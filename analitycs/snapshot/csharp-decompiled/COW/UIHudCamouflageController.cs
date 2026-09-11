using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCamouflageController : UIHudButtonBaseController
{
	private UIHudCamouflageView m_View;

	private bool m_GetOn;

	private float m_CdTime;

	private float m_LeftTime;

	private Color m_NormalColor;

	private Color m_SelectedColor;

	public const uint VISIBILITY_STATE_CARRY = 134217728u;

	private bool m_HideOnOffForced;

	private readonly ResourceID m_CanUseHintVfxRes;

	private VisualInstanceHolder m_CanUseHintVfxHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnBtnClick()
	{
	}

	private void OnEquipChange(GEvent data)
	{
	}

	private void OnSwitchObserver(object[] param)
	{
	}

	private void OnPlayerStateChange(GEvent data)
	{
	}

	private void OnPlayerSnowSlideChange()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void OnFlightRoamInfoChanged(object[] param)
	{
	}

	private void UpdateFlightRoamIcon(object[] param)
	{
	}

	private void UpdateShowHide()
	{
	}

	private void UpdateOnOff(Player localPlayer)
	{
	}

	private void SetGetOn(bool getOn, bool foceHideOnOff)
	{
	}

	private void UpdateCdBar(Player localPlayer, PIJKGPDBNJC type)
	{
	}

	private void HideCdBar()
	{
	}

	private void Update()
	{
	}

	private void ShowCdBar(float cd, float remain)
	{
	}

	private void OnShow(object[] data)
	{
	}

	private void CheckShowSnowSlideEquipmentUseHint()
	{
	}

	private void ShowCanUseHintVfx(bool show)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}
}
