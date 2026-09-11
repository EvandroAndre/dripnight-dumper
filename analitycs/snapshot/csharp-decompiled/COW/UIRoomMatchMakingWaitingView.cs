using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomMatchMakingWaitingView : UIBaseView
{
	public GameObject OtherViewContent;

	public UILabel OtherTime;

	public UISprite MatchWatingBG;

	public UIButton OtherCancelBtn;

	public UISprite OtherCancelBtnIcon;

	public UISprite OtherCancelBtnBG;

	public GameObject OtherEstimateContent;

	public UILabel EstimateNumber;

	public UIButton BackRoomBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
