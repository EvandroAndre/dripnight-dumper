using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDUGC_CountDownReminderController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_CountDownReminderView m_View;

	private UGCCountdownReminderHudRepItem m_ViewData;

	private UITimeLabelHelper m_TimeHelper;

	private int m_LastSeconds;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnDurationTimeSChanged(int cur)
	{
	}

	private void OnDescriptionChanged(string cur)
	{
	}

	private void OnDescriptionParamsChanged(List<object> cur)
	{
	}

	private string GetText(string key, object[] param)
	{
		return null;
	}

	private void OnBaseTimeChanged(int cur)
	{
	}

	private void InitTimer()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
