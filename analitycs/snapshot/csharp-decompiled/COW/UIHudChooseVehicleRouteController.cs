using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudChooseVehicleRouteController : UIPopupWindowController
{
	private UIHudChooseVehicleRouteView m_View;

	private List<UIHudChooseVehicleRouteItemController> m_ItemCtrls;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void TrySetChooseEnable()
	{
	}

	private void OnVehicleSeatChanged(object[] args)
	{
	}

	private void Update()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
