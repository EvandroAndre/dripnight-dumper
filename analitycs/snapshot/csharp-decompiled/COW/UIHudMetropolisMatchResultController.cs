using GCommon;
using proto;

namespace COW;

internal class UIHudMetropolisMatchResultController : UIHudNormalMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}
}
