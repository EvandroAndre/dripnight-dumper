using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipLeaderBoardItemView : UIBaseView
{
	public UIButton ItemBtn;

	public UILabel Score;

	public UILabel Kills;

	public UISprite BG;

	public GameObject Profile;

	public GameObject FirstCupIcon;

	public GameObject FirstBg;

	public GameObject SecondCupIcon;

	public GameObject SecondBg;

	public GameObject ThirdCupIcon;

	public GameObject ThirdBg;

	public GameObject SelfBg;

	public GameObject OtherRank;

	public UILabel rank;

	public Transform HideKillScorePos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
