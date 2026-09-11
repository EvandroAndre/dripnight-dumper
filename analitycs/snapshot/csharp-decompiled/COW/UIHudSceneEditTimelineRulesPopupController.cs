using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudSceneEditTimelineRulesPopupController : UICommonRulesPopupController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override List<RuleMapping>[] GetSelfRules()
	{
		return null;
	}

	protected override void RuleSelectedCallback(RuleMapping rule)
	{
	}

	private List<RuleMapping> LoadRulesFromCSV()
	{
		return null;
	}

	public List<RuleMapping>[] _003C_003EiFixBaseProxy_GetSelfRules()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RuleSelectedCallback(RuleMapping P0)
	{
	}
}
