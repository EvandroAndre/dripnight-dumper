using GCommon;
using message;

namespace COW;

public class UIHudChooseVehicleRouteItemController : UIPopupWindowController
{
	private UIHudChooseVehicleRouteItemView m_View;

	private VehicleLevelDescribe m_RouteData;

	private const IJKKBEFIKBE DefaultRoute = IJKKBEFIKBE.EVehicleUpgradeRoute_Simple;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(VehicleLevelDescribe data)
	{
	}

	public void SetClickEnable(bool enable)
	{
	}

	private void OnBtnSelectClick()
	{
	}

	public void TrySetAutoSelectWarning()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
