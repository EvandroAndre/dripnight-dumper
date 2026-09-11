using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UISeasonStatsDetailInfoItemController : UIBaseController, UITable2.IUITable2Item
{
	private UISeasonStatsDetailInfoItemView m_View;

	private float FormContanerBrRatingPosY;

	private int m_Index;

	private SeasonStatsData m_SeasonStatsData;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

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

	public void SetViewData(SeasonStatsData ladderMatchdata)
	{
	}

	private void RefreshRating(double rating, uint raingEnableGames, NIKKALKPIBO gameMode, uint goldMedalCnt = 0u, uint silverMedalCnt = 0u)
	{
	}

	private void RefreshMedalGoldLabel(UILabel goldLabel, uint goldCnt)
	{
	}

	private void RefreshCSData(bool isCurrentSeason, uint seasonId)
	{
	}

	private void RefreshPeriodicData()
	{
	}

	private void RefreshBRData(bool isCurrentSeason, uint seasonId)
	{
	}

	private void RefreshCSPeakData(bool isCurrentSeason, uint seasonId)
	{
	}

	private void OnCSRankRatingTipClick()
	{
	}

	private void OnBRRankRatingTipClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	public void SetShareBtnState(bool show)
	{
	}

	public void SetAnimState(bool show)
	{
	}

	public void PlayAnim()
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
