using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UISeasonStatsDetailItemController : UIBaseController, UITable2.IUITable2Item
{
	private UISeasonStatsDetailItemView m_View;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconController;

	private UIModelPeriodicLadderMatch m_ModelLadderMatchPeriodic;

	public bool IsArrowOpen;

	public int Index;

	public uint SeasonId;

	public DLBMPCCFKKM matchMode;

	private uint m_PreGroupMode;

	private Vector3 m_CSRankIconContainerOriPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBRExtendBtnClick()
	{
	}

	private void OnCSExtendBtnClick()
	{
	}

	public void RefreshBtnArrow()
	{
	}

	public void SetExtendBtnState(bool show)
	{
	}

	public void SetViewData(SeasonStatsData ladderMatchdata)
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

	private void RefreshCSPeakTournamentData(bool isCurrentSeason, uint seasonId)
	{
	}

	public void PlayAnim(float from)
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
}
