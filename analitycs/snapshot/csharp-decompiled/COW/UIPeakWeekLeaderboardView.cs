using GCommon;
using UnityEngine;

namespace COW;

public class UIPeakWeekLeaderboardView : UIBaseView
{
	public UILabel OpeningTime;

	public Transform Rank1Pos;

	public Transform Rank2Pos;

	public Transform Rank3Pos;

	public Transform Rank4Pos;

	public Transform Rank5Pos;

	public Transform Rank6Pos;

	public Transform Rank7Pos;

	public Transform Rank8Pos;

	public Transform Rank9Pos;

	public Transform Rank10Pos;

	public UIButton CloseBtn;

	public UIButton TipsBtn;

	public UIButton ShareBtn;

	public UIButton GoToLeaderboardBtn;

	public BoxCollider GoToLeaderboardBox;

	public UILabel GotoLeaderboardLabel;

	public GameObject FirstLoading;

	public GameObject SecondLoading;

	public GameObject ThirdLoading;

	public GameObject TopRight;

	public GameObject TopLeft;

	public UILabel Title;

	public GameObject Infos;

	public UICountDownLabel emptyTimeLabel;

	public GameObject Empty;

	public GameObject ShareTitle;

	public UILabel ShareOpeningTime;

	public GameObject Main;

	public UILabel SeasonFinalsettlementTip;

	public UIButton SeasonFinalSettlementTipBtn;

	public BoxCollider SeasonFinalSettlementTipBox;

	public UILabel ShareTitleLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
