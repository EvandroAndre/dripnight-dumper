using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_MatchMakingWaitingView : UIBaseView
{
	public GameObject MMContainer;

	public UIAnchor MatchMakingAnchor;

	public UIWidget ContainWidget;

	public UIGroupWaitingDropItem DragDropItem;

	public UILabel OtherTime;

	public UISprite MatchWatingBG;

	public UIButton OtherCancelBtn;

	public UISprite OtherCancelBtnIcon;

	public UISprite OtherCancelBtnBG;

	public GameObject OtherEstimateContent;

	public UILabel EstimateNumber;

	public UIButton BackRoomBtn;

	public UIPanel UIHUDUGC_MatchMakingWaiting;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
