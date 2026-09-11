using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTrainingShootAreaSetController : UIBaseController
{
	private UIHudTrainingShootAreaSetView m_View;

	private bool m_IsShowConfig;

	private float m_CurHPValue;

	private float m_MinHPValue;

	private float m_HPIntervalValue;

	private int m_ConfigBGHeightDiff;

	private int m_ConfigBGHeight;

	private bool m_ClickPlusOrMinus;

	private bool m_SliderExcuteOnStart;

	private string[] DistanceDescs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnCloseAreaSet()
	{
	}

	private void OnGodValueChange()
	{
	}

	private void OnDistanceValueChange()
	{
	}

	private void OnTargetCountValueChange()
	{
	}

	private void OnMoveValueChange()
	{
	}

	private void OnDamageInfoValueChange()
	{
	}

	private void SetDefaultValue()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnExitTrigger()
	{
	}

	private void OnLocalPlayerZoneChanged(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnSwitchClick()
	{
	}

	private void RepositionConfig()
	{
	}

	private void OnDetailPressed(GameObject go, bool pressed)
	{
	}

	private void OnClickResetBtn()
	{
	}

	private void ResetHPAromr()
	{
	}

	private void OnClickPulsBtn()
	{
	}

	private void OnClickMinusBtn()
	{
	}

	private void OnSliderChanged()
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
