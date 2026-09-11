using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UINinthSYSRulesWndController : UIBigEventRulesWndController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override UIBigEventRulesTabItemController GetTabItemContrller()
	{
		return null;
	}

	public override UIBigEventRulesItemController OpenChildItemContrller()
	{
		return null;
	}

	protected override void OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public List<RuleMapping>[] _003C_003EiFixBaseProxy_GetSelfRules()
	{
		return null;
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public UIBigEventRulesTabItemController _003C_003EiFixBaseProxy_GetTabItemContrller()
	{
		return null;
	}

	public UIBigEventRulesItemController _003C_003EiFixBaseProxy_OpenChildItemContrller()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
