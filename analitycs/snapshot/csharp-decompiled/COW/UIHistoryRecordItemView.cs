using GCommon;
using UnityEngine;

namespace COW;

public class UIHistoryRecordItemView : UIBaseView
{
	public UISprite ColorBg;

	public UILabel GameModeLabel;

	public GameObject GroupHCN;

	public UILabel GroupNum;

	public UILabel Kill;

	public UILabel PassTime;

	public Transform DeltaTr1;

	public Transform DeltaTr2;

	public Transform DeltaTr3;

	public UILabel HistoryRating;

	public GameObject BRShow;

	public UILabel Rank;

	public GameObject WinSprite;

	public GameObject LoseSprite;

	public GameObject CSShow;

	public GameObject CS_V;

	public UILabel V;

	public GameObject CS_F;

	public UILabel F;

	public UISprite SpriteMvp;

	public UISprite SpriteSvp;

	public GameObject SelectedHL;

	public UIButton ItemBtn;

	public UIButton PlayBtn;

	public UIButton SaveBtn;

	public UILabel PassTimeHM;

	public UIButton BRScoreDetailBtn;

	public UISprite BRScoreDetailIcon;

	public UIGrid BRRankLabelGrid;

	public GameObject StreakContainer;

	public UILabel StreakLabel;

	public UISprite StreakIcon;

	public GameObject CS_Invalid;

	public GameObject CSStarChangeContainer;

	public UILabel StarChangeNum;

	public GameObject HCShow;

	public UILabel HCFail;

	public UILabel HCVictor;

	public GameObject HighlightLabelContainer;

	public GameObject StreakRatingContainer;

	public GameObject GoldBg;

	public GameObject SilveryBg;

	public UILabel RatingNum;

	public GameObject RatingContainer;

	public UILabel RatingNumStroke_Silvery;

	public UILabel RatingNumStroke_Gary;

	public UIWrapContent WrapContent;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
