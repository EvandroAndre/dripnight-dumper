using GCommon;

namespace COW;

internal class UIHudBeMarkredTipsController : UIBaseController
{
	private UIHudBeMarkredTipsView m_View;

	private ResourceID m_DefaultIconResID;

	private ResourceID m_KingClownIconResID;

	private ResourceID m_ScanBuildingIconResID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(byte scanType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
