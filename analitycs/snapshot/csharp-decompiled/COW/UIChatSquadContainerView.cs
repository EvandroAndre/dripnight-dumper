using GCommon;
using UnityEngine;

namespace COW;

public class UIChatSquadContainerView : UIBaseView
{
	public UIWidget Widget;

	public GameObject MessageNode;

	public UIScrollView SquadMessageList;

	public GameObject EmptyNode;

	public GameObject NoMessageHint;

	public GameObject NoSquadObjcetHint;

	public Transform SquadList;

	public UIScrollView ScrollView;

	public UIEasyList EasyList;

	public UITable2 MessageListTable2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
