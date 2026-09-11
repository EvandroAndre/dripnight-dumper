using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultRatingBoardView : UIBaseView
{
	public GameObject RatingMedalContainer;

	public UILabel ExpNum;

	public UILabel RatingContent;

	public UILabel StreakNum;

	public UILabel StreakDesc;

	public GameObject StreakIcon;

	public UILabel RatingNum;

	public UISprite RatingBG;

	public UISprite BG;

	public GameObject UIFX_Rating_GoldBg;

	public GameObject UIFX_Rating_SilveryBg;

	public UILabel StreakNumRed;

	public UILabel RatingNum_Silvery;

	public Animation WholeContainer;

	public UIButton WholeContainerBtn;

	public GameObject UIFX_Rating_Gold;

	public GameObject UIFX_Rating_Silvery;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
