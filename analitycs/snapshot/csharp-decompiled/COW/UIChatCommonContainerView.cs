using GCommon;
using UnityEngine;

namespace COW;

public class UIChatCommonContainerView : UIBaseView
{
	public UIWidget Widget;

	public GameObject ContentNode;

	public UIScrollView MessageList;

	public GameObject EmptyNode;

	public GameObject NoMessageHint;

	public UITable2 MessageListTable2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
