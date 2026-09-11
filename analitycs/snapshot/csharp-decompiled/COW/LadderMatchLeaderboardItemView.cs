using GCommon;
using UnityEngine;

namespace COW;

public class LadderMatchLeaderboardItemView : UIBaseView
{
	public UIButton ItemBtn;

	public GameObject FirstCupIcon;

	public GameObject SecondCupIcon;

	public GameObject ThirdCupIcon;

	public GameObject FirstBg;

	public GameObject SecondBg;

	public GameObject ThirdBg;

	public UISprite NormalBg;

	public UILabel LabelNormalCup;

	public Transform ProfileContainer;

	public UISprite SelfBg;

	public GameObject StarInfoContainer;

	public GameObject ScoreInfoContainer;

	public UILabel StarNum;

	public UILabel RankPoint;

	public UISprite RankScoreIcon;

	public UILabel CSPeakPointsLabel;

	public UISprite CSPeakIcon;

	public GameObject CSPeakInfoContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
