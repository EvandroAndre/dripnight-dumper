using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchReviewRewardWndView : UIBaseView
{
	public Transform Left;

	public GameObject LeftReward1;

	public GameObject LeftReward2;

	public GameObject LeftReward3;

	public GameObject LeftReward4;

	public Transform Right;

	public GameObject RightReward1;

	public GameObject RightReward2;

	public GameObject RightReward3;

	public GameObject RightReward4;

	public GameObject Ticket;

	public UILabel UseLabel;

	public UIToggle Toggle;

	public GameObject UseTicket;

	public GameObject UnUseTicket;

	public Transform Center;

	public GameObject CenterReward1;

	public GameObject CenterReward2;

	public GameObject CenterReward3;

	public GameObject CenterReward4;

	public UINetworkTexture NetworkTexture;

	public UIButton BtnClose;

	public GameObject LeftSelectEffect;

	public GameObject RightSelectEffect;

	public GameObject RightMask;

	public GameObject LeftMask;

	public UINetworkTexture LeftBg;

	public UINetworkTexture RightBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
