using GCommon;

namespace COW;

internal class UIHudQuitController : UIBaseController
{
	private UIHudQuitView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnBtnDrop()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
