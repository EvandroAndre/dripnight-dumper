using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameChatContainerView : UIBaseView
{
	public UIScrollView MessageList;

	public UITable2 MessageListTable2;

	public UIWidget Widget;

	public GameObject LiftTopMessage;

	public UIPanel LiftTopMessageClipPanel;

	public GameObject EmptyNode;

	public GameObject ContentNode;

	public Transform LiftTopMessageContent;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
