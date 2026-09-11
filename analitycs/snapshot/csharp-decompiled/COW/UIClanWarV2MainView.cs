using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarV2MainView : UIBaseView
{
	public UIButton BtnMatchState;

	public Transform InfoRoot;

	public UIButton TipsBtn;

	public UIButton ShareBtn;

	public GameObject RedDot;

	public UILabel TitleTimeLabel;

	public UILabel SeasonLabel;

	public UILabel CurrentRound;

	public GameObject Main;

	public UILabel TotalRound;

	public UILabel RightLabel;

	public UILabel HistoryScore;

	public UILabel LeftLabel;

	public UICountDownLabel CountDown;

	public Animation CenterMain;

	public UIToggle ScheduleToggle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
