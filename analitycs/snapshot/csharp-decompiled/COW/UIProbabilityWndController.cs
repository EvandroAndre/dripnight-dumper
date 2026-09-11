using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIProbabilityWndController : UIPopupWindowController
{
	private UIProbabilityWndView m_View;

	private UIModelMall m_ModelMall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint itemId)
	{
	}

	private void ShowProbabilty(List<RareProbability> rare_pr, List<ItemProbability> item_pr, List<AwardTypeProbability> award_type_pr, ESwitch.SwitchFunc switchDesc)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
