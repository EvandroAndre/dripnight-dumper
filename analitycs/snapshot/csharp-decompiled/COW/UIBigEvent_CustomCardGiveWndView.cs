using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCardGiveWndView : UIBaseView
{
	public UINetworkTexture TextureTitle;

	public UIEasyList EasyList;

	public UILabel GiveLimitLabel;

	public GameObject FriendListEmptyAction;

	public UIButton FriendListEmptyActionBtn;

	public GameObject FriendListEmptyActionBtnGo;

	public GameObject DragView;

	public UILabel WishCardLabel;

	public UILabel FriendListEmptyActionTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
