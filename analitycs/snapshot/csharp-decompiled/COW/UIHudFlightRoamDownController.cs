using GCommon;

namespace COW;

internal class UIHudFlightRoamDownController : UIHudButtonBaseController
{
	private UIHudFlightRoamDownView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
