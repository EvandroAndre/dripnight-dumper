using GCommon;

namespace COW;

public class UIMemberShipRulesPopupWindowController : UIPopupWindowController
{
	private UIMemberShipRulesPopupWindowView m_View;

	private UIModelMemberShip m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string rule1, string rule2, string rule3, string rule4, string rule5)
	{
	}

	public void SetTips(string rule1, string rule2, string rule3, string rule4, string rule5)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
