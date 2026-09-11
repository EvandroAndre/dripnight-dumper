using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaELS_TT53ContentCustomizedBackgroundController : UIGachaContentCustomizedBackgroundBaseController
{
	private BackgroundVFX m_EnterVFX;

	private BackgroundVFX m_LoopVFX;

	private BackgroundVFX m_IdleVFX;

	private Animator m_IdleAnimator;

	private const double ENTER_VFX_LENGTH = 1.1;

	private const double ENTER_FINISHED_TIME = 3.0;

	private const double SWITCH_TIME_ONE = 4.8;

	private const double SWITCH_TIME_TWO = 13.4;

	public BackgroundVFX EnterVFX => null;

	public BackgroundVFX LoopVFX => null;

	protected override void OnUIInit()
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(uint gachaID = 0u)
	{
	}

	public override void ShowVFX(EGachaCustomizedBackgroundVFXType type, int index = 0, bool forceRefresh = false)
	{
	}

	private void HideConflictingVFXForIdle()
	{
	}

	protected override void OnMaskBtnClick()
	{
	}

	protected override void OnCGPlay()
	{
	}

	protected override void OnCGStop()
	{
	}

	protected override void OnVFXShow()
	{
	}

	protected override void OnVFXHide()
	{
	}

	private void OnAnimEvt(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowVFX(EGachaCustomizedBackgroundVFXType P0, int P1, bool P2)
	{
	}
}
