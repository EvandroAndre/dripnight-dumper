using GCommon;

namespace COW;

internal class UIHudHGTweenTipsController : UIBaseController
{
	private UIHudHGTweenTipsView m_View;

	private uint m_DelayCallID;

	private const float AnimDuration = 2f;

	private float m_TimePlayed;

	private bool m_PauseFinished;

	private uint m_PauseDelay;

	private float m_NeedPauseSecs;

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

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void PauseFinished()
	{
	}

	public void SetMessage(string message, float duration)
	{
	}

	private void SetData(string message, float duration)
	{
	}

	private void AutoHide()
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
