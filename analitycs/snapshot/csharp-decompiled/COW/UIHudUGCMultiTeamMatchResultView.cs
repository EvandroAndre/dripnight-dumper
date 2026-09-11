using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCMultiTeamMatchResultView : UIBaseView
{
	public Animator HudNormalMatchResAni;

	public UILabel RankNum;

	public UILabel TotalNum;

	public UILabel ResultDesc;

	public UILabel GameModeTxt;

	public UILabel GameMapTxt;

	public GameObject WorkShopGo;

	public UIEasyList EasyListView;

	public UIButton ShareBtn;

	public UIButton NextBtn;

	public UILabel NextBtnTime;

	public UILabel NextBtnLable;

	public UIButton DetailsBtn;

	public GameObject DetailBtnShowIcon;

	public GameObject DetailBtnHideIcon;

	public UIButton ReplayBtn;

	public UIGrid RewardBtnGrid;

	public UIButton VideoGiftBtn;

	public UIButton FastSendGiftBtn;

	public Transform CallSignContainer;

	public GameObject ShareInfoContainer;

	public UILabel ShareGameModeTxt;

	public UITable BottomLeftTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
