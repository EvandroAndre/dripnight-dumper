using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopV2POIMissionView : UIBaseView
{
	public UILabel MissionLabel;

	public UIButton BtnAccept;

	public GameObject Available;

	public UILabel AvailableLabel;

	public GameObject Unavailable;

	public UILabel UnavailableLabel;

	public GameObject Countdown;

	public UILabel CountdownLabel;

	public UILabel ProgressLabel;

	public GameObject ProgressTag;

	public UITable Table;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
