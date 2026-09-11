using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEventFriendCallbackView : UIBaseView
{
	public GameObject Title;

	public UIScrollView FriendListScrollView;

	public UIEasyList FriendList;

	public UILabel FriendListEmptyHint;

	public GameObject RequestContainer;

	public UIButton BtnInviteFriends;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
