using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGachaRulesPopUpDropRateV1Controller : UIBaseController
{
	private UIGachaRulesPopUpDropRateV1View m_View;

	private List<UIGachaRulesPopUpRateItemData> m_InfoItems;

	private List<UIGachaRulesPopUpDropRateV1ItemController> m_ItemCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<UIGachaRulesPopUpRateItemData> infoItems, string dropRatetext, bool isDoubleWheelGrandPrize = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
