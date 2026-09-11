using GCommon;
using UnityEngine;

namespace COW;

public class UIChatWorldContainerView : UIBaseView
{
	public UIWidget Widget;

	public GameObject LiftTopMessage;

	public UIPanel LiftTopMessageClipPanel;

	public GameObject EmptyNode;

	public GameObject NoMessageHint;

	public Transform LiftTopMessageContent;

	public GameObject ContentNode;

	public UIScrollView MessageList;

	public UITable2 MessageListTable2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
