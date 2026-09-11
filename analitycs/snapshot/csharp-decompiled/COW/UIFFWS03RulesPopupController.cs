using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIFFWS03RulesPopupController : UICommonRulesPopupController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	public override UICommonRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	public List<RuleMapping>[] _003C_003EiFixBaseProxy_GetSelfRules()
	{
		return null;
	}

	public UICommonRulesTabItemController _003C_003EiFixBaseProxy_GetTabItemContrller()
	{
		return null;
	}
}
