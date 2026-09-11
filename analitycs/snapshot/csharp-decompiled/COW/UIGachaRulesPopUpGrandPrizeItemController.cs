using GCommon;

namespace COW;

public class UIGachaRulesPopUpGrandPrizeItemController : UIBaseController
{
	private UIGachaRulesPopUpGrandPrizeItemView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private uint m_GachaID;

	private BaseItemInfo m_ItemInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint chestID, uint id, BaseItemInfo itemInfo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
