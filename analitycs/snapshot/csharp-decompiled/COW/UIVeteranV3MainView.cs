using GCommon;
using UnityEngine;

namespace COW;

public class UIVeteranV3MainView : UIBaseView
{
	public GameObject CountDown;

	public UILabel LabelDate;

	public GameObject PrivilegeCon;

	public UIButton PrivilegeBtn;

	public UILabel PrivilegeBubbleLabel;

	public UIButton CheckBtn;

	public GameObject DailyRewardItem;

	public Animation DailyRewardAnimation;

	public UILabel ProgressNum;

	public GameObject ProgressReward1;

	public GameObject ProgressReward2;

	public GameObject ProgressReward3;

	public GameObject ProgressReward4;

	public UIGrid MissionGrid;

	public UICountDownLabel RefreshLabel;

	public UIWidget PreviewWidget;

	public GameObject MaskPanel;

	public GameObject ProgressLine;

	public GameObject NextDayTips;

	public Transform MissionCon1;

	public Transform MissionCon2;

	public Transform MissionCon3;

	public UIProgressBar BarBack;

	public GameObject VFXThumb;

	public UIGrid ProgressGrid;

	public GameObject AllClaimed;

	public GameObject ProgressShiningVFX;

	public GameObject RewardCon;

	public UIButton RuleBtn;

	public Animation MainAni;

	public GameObject AllTaskDoneCon;

	public GameObject CenterCon;

	public GameObject RightCon;

	public Transform MissionRewardCon;

	public UIButton PurchaseSpecialRewardBtn;

	public UIGrid SpecialRewardGrid;

	public GameObject SpecialProgressReward1;

	public GameObject SpecialProgressReward2;

	public GameObject SpecialProgressReward3;

	public GameObject SpecialProgressReward4;

	public UILabel PriceLabel;

	public GameObject SpecialProgressLine;

	public GameObject DailyRewardLock;

	public Transform PrivilegePos;

	public GameObject DailyRewardCon;

	public GameObject PrivilegeIcon;

	public UISprite PrivilegeBigEventIcon;

	public GameObject VeteransDiscountStore;

	public VFXCreateHelper DailyRewardCanClaimVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
