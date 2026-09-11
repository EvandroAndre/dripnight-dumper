using GCommon;
using UnityEngine;

namespace COW;

public class UIChatClanContainerView : UIBaseView
{
	public UIWidget Widget;

	public GameObject ContentNode;

	public UIScrollView MessageList;

	public GameObject LuckyBagMessage;

	public UILabel LuckyBagLabel;

	public UIButton GoToLuckyBagBtn;

	public GameObject EmptyNode;

	public GameObject NoMessageHint;

	public GameObject NoClanHint;

	public UIButton GotoSearchClanBtn;

	public UITable2 MessageListTable2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
