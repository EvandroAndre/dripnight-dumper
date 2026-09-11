using GCommon;
using UnityEngine;

namespace COW;

public class UIChatMessageItemTipsView : UIBaseView
{
	public GameObject ChatTips;

	public GameObject PrivateWarning;

	public GameObject AddFriendTip;

	public UILabel QuickAddFriendLabel;

	public UIButton QuickAddFriendBtn;

	public GameObject InteractionTip;

	public UILabel VeteranInteractionLabel;

	public UIButton VeteranInteractionBtn;

	public GameObject VeteranInteraction;

	public GameObject InteractionBtnContainer;

	public GameObject OfflineMsgTip;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
