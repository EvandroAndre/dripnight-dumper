using GCommon;

namespace COW;

public class UIHUDUGC_TimeTweenTipsController : UIHUDUGC_InternalHudController
{
	private UGCTimeTweenTipsHudRepItem m_ViewData;

	private string m_Description;

	private int lastLeftTimeS;

	private int EndTimeS;

	private bool m_ShowCD;

	private UIHUDUGC_TimeTweenTipsView m_View;

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

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void Update()
	{
	}

	private void OnDescriptionChanged(string cur)
	{
	}

	private void OnBaseTimeSChanged(int cur)
	{
	}

	private void OnDurationtimeSChanged(int cur)
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
