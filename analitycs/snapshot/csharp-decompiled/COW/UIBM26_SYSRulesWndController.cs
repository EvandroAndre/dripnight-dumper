using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIBM26_SYSRulesWndController : UIBigEventRulesWndController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	public override UIBigEventRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	public override UIBigEventRulesItemController OpenChildItemContrller()
	{
		return null;
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public List<RuleMapping>[] _003C_003EiFixBaseProxy_GetSelfRules()
	{
		return null;
	}

	public UIBigEventRulesTabItemController _003C_003EiFixBaseProxy_GetTabItemContrller()
	{
		return null;
	}

	public UIBigEventRulesItemController _003C_003EiFixBaseProxy_OpenChildItemContrller()
	{
		return null;
	}
}
