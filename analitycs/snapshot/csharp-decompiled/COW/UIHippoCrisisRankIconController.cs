using GCommon;

namespace COW;

public class UIHippoCrisisRankIconController : UIBaseController
{
	private UIHippoCrisisRankIconView m_View;

	private UIModelHippoCrisisLadderMatch m_ModelHippoCrisisLadderMatch;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetHippoCrisisRankIconView(uint rank, uint iconDisplayType, uint ladderRankIconType, uint rankPoint = 0u)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
