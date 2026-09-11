using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAuxAimController : UIHudButtonBaseController
{
	private UIHudAuxAimView m_View;

	private bool m_HasRegistedButton;

	private const float m_BGRangeRadius = 0.08f;

	private const float m_DirectionVal = 0f;

	private string m_strButtonAction;

	private bool m_ShowByConfig;

	private bool m_ShowByPlayerState;

	private Vector3 m_StartPos;

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

	protected override void OnUIOpen()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	private void Update()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnUp()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void UpdateBtnPushStatus(bool down)
	{
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	private void OnPlayerFPPModeChange()
	{
	}

	private void OnHudSettingChange(object[] param)
	{
	}

	private void UpdateShowConfig()
	{
	}

	private void UpdateVisibility()
	{
	}

	private void OnShowSelf(bool param)
	{
	}

	private void OnAimingEnemy(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}
}
