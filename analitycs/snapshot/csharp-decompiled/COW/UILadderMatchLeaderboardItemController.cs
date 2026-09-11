using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UILadderMatchLeaderboardItemController : UIEasyListItemController
{
	private enum ScoreType
	{
		Score,
		Star,
		CSPeakTournament
	}

	private LadderMatchLeaderboardItemView m_View;

	private LeaderBoardInfo m_Info;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private const int m_TopRankThreshold = 3;

	private GameObject[] m_TopCupArray;

	private GameObject[] m_TopBgArray;

	private DLBMPCCFKKM m_LadderMatchType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetScoreType(ScoreType scoreType)
	{
	}

	public void SetSelfUI(bool isRegion, bool showClosedUI = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
