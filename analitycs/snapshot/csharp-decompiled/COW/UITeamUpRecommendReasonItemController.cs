using GCommon;

namespace COW;

public class UITeamUpRecommendReasonItemController : UIBaseController
{
	public enum TeamUpRecommendReason
	{
		None,
		KD,
		HeadShotRate,
		WinRate
	}

	private UITeamUpRecommendReasonItemView m_View;

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

	public void SetViewData(TeamUpRecommendReason reason, float value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
