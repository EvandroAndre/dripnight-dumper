using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSSOLeaderboardItemView : UIBaseView
{
	public UIHudCSSOTeamInfoView TeamInfoView;

	public TweenScale TweenScale;

	public UILabel TeamTitle;

	public UILabel LabelTeam;

	public GameObject HP;

	public UILabel LabelPlayer4Name;

	public UILabel LabelPlayer2Name;

	public UILabel LabelPlayer3Name;

	public UILabel LabelPlayer1Name;

	public UILabel LabelPlayer1Kills;

	public UILabel LabelPlayer2Kills;

	public UILabel LabelPlayer3Kills;

	public UILabel LabelPlayer4Kills;

	public GameObject Eliminate;

	public GameObject Up;

	public UILabel UpRank;

	public GameObject Win;

	public GameObject Lose;

	public GameObject Down;

	public UILabel DownRank;

	public UISprite BG;

	public UISprite IndexIcon1;

	public UILabel Index;

	public UISprite IndexIcon2;

	public UISprite IndexIcon3;

	public GameObject NormalMatch;

	public GameObject SpecialMatch;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
