using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDChatAIContainerView : UIBaseView
{
	public UIWidget Widget;

	public UIPanel ContentNode;

	public UIScrollView MessageList;

	public UIPanel MessageListPanel;

	public UITable2 MessageListTable2;

	public UIPanel EmptyNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
