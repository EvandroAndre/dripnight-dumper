using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudBanknoteLeaderboardItemController : UIBaseController
{
	private UIHudControlLeaderboardItemView m_View;

	private Dictionary<int, UILabel> m_Type2Label;

	private LeaderboardData m_DataInfo;

	public LeaderboardData DataInfo => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetTypes(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
	{
	}

	public void SetDetailData(EMatchResultPlayerInfoType type, string text)
	{
	}

	public void SetRankInfo(int rankLevel)
	{
	}

	public void SetDataInfo(LeaderboardData dataInfo)
	{
	}

	private void SetBackground(bool isLocalPlayer)
	{
	}

	public void SetKillCount(int k)
	{
	}

	public void SetDMG(int k)
	{
	}

	public void SetCapePointCount(int a)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
