using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultPosterView : UIBaseView
{
	public UITable InfoTable;

	public GameObject BRRankContainer;

	public UILabel BRRankLabel;

	public UILabel TotalTeamCountLabel;

	public GameObject CSRankRatingContainer;

	public UILabel CSRankRatingLabel;

	public GameObject CSRankRatingDescContainer;

	public UILabel CSRankRatingDescLabel;

	public GameObject CSRankRatingGameAnalysisContainer;

	public GameObject CSRankRatingGameAnalysisIconContainer;

	public UILabel CSRankRatingGameAnalysisLabel;

	public GameObject GameAnalysisContainer;

	public UILabel GameAnalysisLabel;

	public GameObject BadgeOneLineContainer;

	public UIGrid BadgeOneLineGrid;

	public GameObject BadgeTwoLineContainer;

	public UIGrid BadgeTwoLineGrid;

	public GameObject GameInfoContainer;

	public UIGrid GameInfoGrid;

	public UILabel GameName;

	public UIWidget PreviewBorder;

	public UINetworkTexture BGTexture;

	public UITable CSRankRatingGameAnalysisTable;

	public GameObject CSRankRatingGameAnalysisLossMVp;

	public GameObject CSRankRatingGameAnalysisWinMVp;

	public UITable GameAnalysisTable;

	public GameObject GameAnalysisWinMvp;

	public GameObject GameAnalysisLossMvp;

	public UITable RightTopTable;

	public UILabel ClanName;

	public UISprite ClanInfoFrameIcon;

	public UISprite ClanInfoIcon;

	public UIAnchor LeftAnchor;

	public UIAnchor RightTopAnchor;

	public UISprite CSRankRatingGameAnalysisIcon;

	public GameObject CSSmallRankRatingContainer;

	public UILabel CSSmallRankRatingLabel;

	public GameObject GameAnalysisIconContainer;

	public UISprite GameAnalysisIcon;

	public Camera ExtralCamera;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
