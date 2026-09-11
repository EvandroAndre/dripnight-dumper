using GCommon;
using UnityEngine;

namespace COW;

public class UIGroupWaitingView : UIBaseView
{
	public UIWidget ContainerWidget;

	public UIButton WholeBtn;

	public UIGroupWaitingDropItem DropItem;

	public UIAnchor GroupWaitAnchor;

	public UILabel MatchingWaitingLabel;

	public UIButton ReturnBtn;

	public UIButton QuickBtn;

	public UILabel QuickLabel;

	public Transform QuickBottomTrans;

	public Transform QuickTopTrans;

	public UIButton NoticeBtn;

	public UIGrid GroupGrid;

	public Transform GroupTrans;

	public GameObject AllReadyBG;

	public GameObject NotAllReadyBG;

	public GameObject OnlyInLobby;

	public GameObject NoticeAble;

	public GameObject NoticeDisable;

	public UILabel NoticeCD;

	public UIPanel UIGroupWaiting;

	public Transform NoticeBottomTrans;

	public Transform NoticeTopTrans;

	public UILabel RemindLabel;

	public UILabel RemindingLabel;

	public GameObject IconDrag;

	public GameObject HippoCrisisContainer;

	public GameObject SingleInHippoCrisisLabel;

	public GameObject GroupReadyInfo;

	public GameObject GoDownload;

	public Transform TrRootDownload;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
