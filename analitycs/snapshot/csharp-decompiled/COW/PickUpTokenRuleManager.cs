using System.Collections.Generic;
using GCommon;

namespace COW;

public class PickUpTokenRuleManager : SingletonModule<PickUpTokenRuleManager>
{
	private List<PickUpTokenRule> m_PickUpTokenDataList;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private void InitPickUpTokenManager()
	{
	}

	public bool IsTokenUnShow(uint itemID, string lockRegion)
	{
		return false;
	}
}
