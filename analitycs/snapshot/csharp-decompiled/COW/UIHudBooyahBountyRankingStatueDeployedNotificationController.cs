using GCommon;

namespace COW;

public class UIHudBooyahBountyRankingStatueDeployedNotificationController : UIBaseController
{
	private const float m_InAnimationDurationSecs = 3f;

	private const string m_InAnimationClipName = "UIFX_Booyahday24_Sys_UIHudBooyahBountyRanking";

	private UIHudBooyahBountyRankingStatueDeployedNotificationView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetupDefaultState()
	{
	}

	public void SetViewData(string firstLineContent, string secondLineContent)
	{
	}

	public float PlayInAnimation()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
