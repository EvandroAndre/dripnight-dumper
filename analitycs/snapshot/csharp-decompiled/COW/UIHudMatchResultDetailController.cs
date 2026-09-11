using GCommon;
using proto;

namespace COW;

public class UIHudMatchResultDetailController : UIBaseController
{
	private UIHudMatchResultDetailView m_View;

	private const string m_ClanBuffKey = "T_44_L_MATCHRESULT_REWARDTIP_GUILDBUFF";

	private const string m_CardBuffKey = "T_45_L_MATCHRESULT_REWARDTIP_CARDBUFF";

	private const string m_EventBuffKey = "T_45_L_MATCHRESULT_REWARDTIP_EVENTBUFF";

	private const int m_HasRewardGoldBgHeight = 55;

	private const int m_HasRewardGoldContainerHeight = 60;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshDetailView(MatchIncome income, MatchStats stats, ulong timeStamp)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
