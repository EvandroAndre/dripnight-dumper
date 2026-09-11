using GCommon;

namespace COW;

internal class UIOBHudInfoListController : UIBaseHudInfoListController
{
	private UIOBHudInfoListView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
