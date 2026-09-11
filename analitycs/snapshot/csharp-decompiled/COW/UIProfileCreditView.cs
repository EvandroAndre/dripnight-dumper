using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCreditView : UIBaseView
{
	public UILabel LabelCreditScore;

	public UILabel LabelCreditEvaluation;

	public UIGrid RewardGrid;

	public UIWidget FairplayContainer;

	public UIButton BtnFairplay;

	public GameObject ComingSoonTips;

	public GameObject Star;

	public UILabel DayNumberLabel;

	public UISprite Face_Big;

	public UISprite Face_Small;

	public GameObject UIFX_Group_UIProfileCreditBG;

	public GameObject UIFX_UIProfileCredit_Green;

	public GameObject UIFX_UIProfileCredit_Red;

	public UIEasyList CreditHistoryList;

	public GameObject CreditHistoryEmpty;

	public GameObject CreditHistoryDetail;

	public UITable2 CreditBehaviorList;

	public UILabel CreditBehaviorStatusLabel;

	public GameObject NoSpeakIcon;

	public GameObject NoMicIcon;

	public UILabel StatusDetailLabel;

	public GameObject NoMessageIcon;

	public UITable StatusDetailTable;

	public GameObject CountDownContainer;

	public UICountDownLabel CountDownLabel;

	public UIButton CreditBehaviorStatusBtn;

	public GameObject CreditBehaviorStatusRed;

	public UIPanel CreditBehaviorScrollView;

	public GameObject CreditBehaviorStatusContainer;

	public GameObject CreditBehaviorDetailContainer;

	public UISprite CreditBehaviorStatusIcon;

	public GameObject StatusDetailLabelWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
