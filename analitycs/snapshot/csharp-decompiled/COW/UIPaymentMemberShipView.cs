using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentMemberShipView : UIBaseView
{
	public GameObject UIPaymentMemberShip;

	public GameObject LoadingContainer;

	public GameObject LeftContainer;

	public UIGrid RightContainer;

	public GameObject BottomContainer;

	public UIScrollView CheckInTableScrollView;

	public UIEasyList CheckInItemEasyList;

	public GameObject RebateCardTab_MiniWeekCard;

	public GameObject RebateCardTab_WeekCard;

	public GameObject RebateCardTab_MonthCard;

	public GameObject NoBuyMask;

	public UIPanel AdPopupWindowContainer;

	public UILabel LabelTime;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
