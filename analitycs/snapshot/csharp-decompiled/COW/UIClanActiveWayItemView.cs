using GCommon;
using UnityEngine;

namespace COW;

public class UIClanActiveWayItemView : UIBaseView
{
	public GameObject DailyMissionTips;

	public GameObject ClanWarTips;

	public GameObject TeamUpTips;

	public GameObject Goto;

	public UIButton GotoBtn;

	public UILabel GotoLabel;

	public UICountDownLabel ClanWarCountdownLabel;

	public UILabel ClanWarTimeLabel;

	public UICountDownLabel ClanWarOnGoingCountdownLabel;

	public UILabel Title;

	public GameObject Finished;

	public UILabel Desc;

	public UILabel ClanWarDescLabel;

	public GameObject LeftClanWarUnopened;

	public UILabel ClanWarUnopenedLabel;

	public GameObject LeftNormal;

	public UILabel ClanWarStayTunedLabel;

	public GameObject mask;

	public GameObject BGClanWarLightContainer;

	public GameObject BGContainer;

	public GameObject StoreTips;

	public UIButton StoreGotoBtn;

	public UILabel StoreGotoLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
