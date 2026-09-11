using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudGB_GPKickBallBtnController : UIHudButtonBaseController
{
	private UIHudGB_GPKickBallBtnView m_View;

	private float m_ChargeRatio;

	private float m_ChargeStartTime;

	private const float MaxChargeRatio = 1f;

	private bool m_LastLineShown;

	private int m_ShowFrameCounter;

	private uint m_VFXHolder;

	private AudioResource m_ChargeLoopSound;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIClose()
	{
	}

	private void Update()
	{
	}

	private void ShowKickFootballLine(Player localPlayer, Player targetPlayer)
	{
	}

	private void HideKickFootballLine()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnClick()
	{
	}

	protected override void OnBtnUp()
	{
	}

	private void CancelBtn()
	{
	}

	private void CancelLine(int target)
	{
	}

	private void StartChargeLoopSound()
	{
	}

	private void StopChargeLoopSound()
	{
	}

	private void ResetButton()
	{
	}

	private bool CheckButtonCanShow()
	{
		return false;
	}

	public void OnTreasuryTriggerChanged(bool enter)
	{
	}

	public void OnVehiclTriggerChanged(bool enter)
	{
	}

	private void OnExitTrigger()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}
}
