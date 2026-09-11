using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICSPeakTournamentLevelRewardItemController : UIBaseController
{
	private UICSPeakTournamentLevelRewardItemView m_View;

	private UICSPeakTournamentRankIconController m_RankIconCtrl;

	private uint m_Points;

	private int m_Index;

	private GameObject m_AvatarFrameEffect;

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

	public void SetViewData(CSPeakTournamentAwardDesc awardDesc, int index, uint count)
	{
	}

	public void SetHighLight(bool isHighLight)
	{
	}

	private void SetClaimedState(bool hasClaimed, bool isFirst, bool isLast)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
