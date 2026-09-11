using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeCSPeakTournamentInfoView : UIBaseView
{
	public UIButton HelperBtn;

	public UIWidget HelperBtnWidget;

	public GameObject helpSprite;

	public UILabel gameMode;

	public UICountDownLabel SeasonNoticeLabel;

	public Object SeasonBtn;

	public UITable SeasonBtnTable;

	public UILabel SeasonLabel;

	public GameObject NewSeasonTipsLabel;

	public GameObject PointsContainer;

	public UIButton MapBtn;

	public GameObject ReachPreRankContainer;

	public Transform StarIcon;

	public GameObject CountDownIcon;

	public GameObject NotInSeasonContainer;

	public UILabel NotInSeasonLabel;

	public UICountDownLabel NotInSeasonCountdownLabel;

	public GameObject SeasonNoticeContainer;

	public GameObject OpeningDaily;

	public GameObject ClosingDaily;

	public UILabel ClosingDailyTimeLabel;

	public UICountDownLabel OpeningDailyCountDownLabel;

	public GameObject OpensDailyContainer;

	public GameObject SeasonStartNoticeContainer;

	public UILabel SeasonStartNoticeLabel;

	public GameObject SquadOnly;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
