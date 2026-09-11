using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSingleFightMatchResultView : UIBaseView
{
	public Animator HudSingleFightAni;

	public GameObject RankInfo;

	public UILabel RankNum;

	public UILabel TotalNum;

	public GameObject WinnerInfo;

	public UILabel WinnerTxt;

	public UILabel GameMapTxt;

	public UILabel GameModeTxt;

	public GameObject WorkShopGo;

	public UILabel ResultDesc;

	public UILabel TitleInfo1Txt;

	public UILabel TitleInfo2Txt;

	public UILabel TitleInfo3Txt;

	public UILabel TitleInfo4Txt;

	public UIEasyList PlayerList;

	public Transform LocalPlayerInfo;

	public UIButton DetailsBtn;

	public GameObject DetailBtnShowIcon;

	public GameObject DetailBtnHideIcon;

	public UIButton ShareBtn;

	public UIButton NextBtn;

	public UILabel NextBtnTime;

	public UILabel NextBtnLable;

	public UIButton ReplayBtn;

	public UIGrid RewardBtnGrid;

	public UIButton VideoGiftBtn;

	public UIButton FastSendGiftBtn;

	public Transform CallSignContainer;

	public GameObject ShareInfoContainer;

	public UILabel ShareGameModeTxt;

	public UITable BottomLeftTable;

	public UIScrollView PlayerScrollView;

	public UITexture BGInFrontEndScene;

	public GameObject MaskBG;

	public GameObject PlayerInfoTitle;

	public UILabel TitlePlayerTxt;

	public UIGrid BattleTagGrid;

	public GameObject MatchFeedbackContainer;

	public UIButton MatchFeedbackBtn;

	public UILabel MatchIdAndAccountId;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
