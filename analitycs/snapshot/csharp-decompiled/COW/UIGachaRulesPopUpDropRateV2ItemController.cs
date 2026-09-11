using GCommon;

namespace COW;

public class UIGachaRulesPopUpDropRateV2ItemController : UIBaseController
{
	private UIGachaRulesPopUpDropRateV2ItemView m_View;

	private UIStandardItemMiniController m_MiniItem;

	private BaseItemInfo m_ItemInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIGachaRulesPopUpRateItemData itemData, bool isDoubleWheelGrandPrize = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
