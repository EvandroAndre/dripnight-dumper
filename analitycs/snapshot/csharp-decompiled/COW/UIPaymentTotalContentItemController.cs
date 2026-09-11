using GCommon;
using proto;

namespace COW;

public class UIPaymentTotalContentItemController : UIBaseController
{
	private UIPaymentTotalContentItemView m_View;

	private UIStandardItemMiniController m_UIStandardItemMiniController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(AwardDesc award, bool claimed)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
