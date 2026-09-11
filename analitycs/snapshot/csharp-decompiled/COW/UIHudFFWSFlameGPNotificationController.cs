using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudFFWSFlameGPNotificationController : UIBaseController, IScheduledNotification
{
	private UIHudFFWSFlameGPNotificationView m_View;

	private Coroutine m_Coroutine;

	private int m_OriginalLayer;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData()
	{
	}

	public void Play(object viewData)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void Finish(bool interrupted)
	{
	}

	private void ResetUI()
	{
	}

	private void OnAnimationEvent(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
