using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendRequestView : UIBaseView
{
	public UIScrollView FriendListScrollView;

	public UIEasyList FirendList;

	public UILabel FriendListEmptyHint;

	public GameObject RequestContainer;

	public UIButton BtnRefuseAll;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
