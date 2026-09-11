using GCommon;

namespace COW;

internal class UIHudGamePauseController : UIBaseController
{
	private UIHudGamePauseView m_View;

	private float m_CountDownTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnRequestGameResumeConfirm(object[] param)
	{
	}

	private void OnPauseCheck(object[] param)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void CSTutorialPause()
	{
	}

	public void Pause()
	{
	}

	public void PreResume(byte time)
	{
	}

	protected void FixedUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
