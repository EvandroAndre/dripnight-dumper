using GCommon;

namespace COW;

public class UIHudDGGScoreInfoController : UIBaseController
{
	private UIHudDGGScoreInfoView m_View;

	private int CurrentScore => 0;

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

	private void OnScoreChange(object[] data)
	{
	}

	private void OnLeadingScoreChange(object[] data)
	{
	}

	private void UpdateScore(int score)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
