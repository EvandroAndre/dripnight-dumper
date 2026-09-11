using GCommon;

namespace COW;

public class UIHUDPlayerGodBarController : UIBaseController
{
	private UIHUDPlayerGodBarView m_View;

	private bool m_IsGoding;

	private float m_GodBeginTime;

	private float m_GodEndTime;

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

	private void OnShowGod(object[] data)
	{
	}

	public void OnGodBegin(float godEndTime)
	{
	}

	private void Update()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
