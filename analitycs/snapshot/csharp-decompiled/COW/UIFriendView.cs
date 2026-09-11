using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendView : UIBaseView
{
	public UISprite BG;

	public GameObject FriendListEmpty;

	public Transform LeftContainer;

	public UITable InviteBtnGroup;

	public GameObject ShareLabel;

	public UIButton CopyLink;

	public UIButton LineInvite;

	public UIButton BindInvite;

	public UISprite BindInviteSprite;

	public UIButton OtherInvite;

	public UIButton BtnFriendsRequest;

	public UIInput SearchInput;

	public UIButton SearchButton;

	public GameObject SearchClearSprite;

	public GameObject SearchSprite;

	public UILabel FriendCountLabel;

	public GameObject MiddleContents;

	public UIScrollView FriendListScrollView;

	public UIEasyList FriendList;

	public UIScrollView FriendCallbackScrollView;

	public UITable TableContent;

	public Transform AddFriendRoot;

	public GameObject FriendListEmptyAction;

	public UILabel FriendListEmptyActionTitle;

	public UIButton FriendListEmptyActionBtn;

	public UILabel FriendListEmptyActionBtnLabel;

	public GameObject ApplyHint;

	public GameObject SplitLine;

	public UILabel SearchResult;

	public UIButton InstagramInvite;

	public UIButton WhatsAppInvite;

	public UITable SearchTable;

	public UIButton RemoveFriendsBtn;

	public UIButton BtnBlackList;

	public UIButton BtnNearbySearch;

	public UISprite BtnNearbySearchSprite;

	public Transform NearbyBtnRedPointPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
