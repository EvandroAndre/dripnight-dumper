using GCommon;
using UnityEngine;

namespace COW;

public class UIClanView : UIBaseView
{
	public TweenScale TweenScale;

	public GameObject Content;

	public GameObject BG;

	public Transform CountdownTime;

	public Transform Left;

	public GameObject MainPageContent;

	public GameObject MemberContent;

	public GameObject ClanWarV2Content;

	public UITable BottomLeftTable;

	public UIButton BtnRedPacket;

	public UIGrid BottomLeftBtnGrid;

	public GameObject ActiveContent;

	public UIButton BtnCreateRoom;

	public GameObject ClanTrendTrans;

	public Transform ClanChatContainer;

	public GameObject ClanWarChampionshipContent;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
