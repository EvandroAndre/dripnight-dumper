using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPOIMissionInfoView : UIBaseView
{
	public UILabel MissionLabel;

	public UIButton BtnAccept;

	public GameObject Available;

	public UILabel AvailableLabel;

	public GameObject Unavailable;

	public UILabel UnavailableLabel;

	public UIButton BtnClose;

	public UIButton BtnCloseMask;

	public GameObject Countdown;

	public UILabel CountdownLabel;

	public UILabel DescLabel;

	public Animation Main;

	public GameObject RewardTagLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
