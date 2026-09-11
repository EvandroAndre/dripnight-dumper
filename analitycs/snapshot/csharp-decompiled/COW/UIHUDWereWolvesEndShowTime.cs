using GCommon;

namespace COW;

public class UIHUDWereWolvesEndShowTime : UIBaseController
{
	private UIHUDWereWolvesEndShowTimeView m_View;

	private bool m_IsWolf;

	private bool m_IsRefreshOver;

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

	private void RefreshGameOverFlag(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
