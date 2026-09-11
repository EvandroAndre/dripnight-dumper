using GCommon;

namespace COW;

public class UIMailRewardItemController : UIBaseController
{
	private UIMailRewardItemView m_View;

	private UIStandardItemMiniController m_UIStandardItemMiniController;

	private BaseItemInfo m_Item;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(BaseItemInfo item, bool claimed)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
