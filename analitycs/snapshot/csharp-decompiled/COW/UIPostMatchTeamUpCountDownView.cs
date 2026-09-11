using GCommon;
using UnityEngine;

namespace COW;

public class UIPostMatchTeamUpCountDownView : UIBaseView
{
	public UILabel LeftTimeLabel;

	public UILabel QuickMatchLabel;

	public GameObject Icon_Drag;

	public UIButton OtherCancelBtn;

	public UITable TeammatesList;

	public GameObject MatchMakingContainer;

	public UIAnchor MatchMakingAnchor;

	public UIWidget ContainerWidget;

	public UIGroupWaitingDropItem DragDropItem;

	public UIButton OpenDetailButton;

	public GameObject OpenDetailIcon;

	public GameObject CloseDetailIcon;

	public Transform OpenDetailTrans;

	public UIButton ReturnBtn;

	public GameObject CountdownContainer;

	public UILabel CountDownLabel;

	public UISprite CountdownIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
