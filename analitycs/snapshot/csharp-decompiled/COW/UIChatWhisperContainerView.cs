using GCommon;
using UnityEngine;

namespace COW;

public class UIChatWhisperContainerView : UIBaseView
{
	public UIWidget Widget;

	public GameObject ContentNode;

	public UIScrollView WhisperMessageList;

	public GameObject EmptyNode;

	public GameObject NoMessageHint;

	public GameObject NoWhisperObjcetHint;

	public GameObject TopMessage;

	public UILabel ChatWith;

	public UIButton SendGift;

	public UIButton Profile;

	public UIDragScrollView WhisperNameListDrag;

	public UIScrollView WhisperNameListSV;

	public UIEasyList WhisperNameEasyList;

	public UIScrollView WhisperNameListRecentSV;

	public UIEasyList WhisperNameRecentEasyList;

	public UIButton AddFriendBtn;

	public GameObject NoRecentWhisperGO;

	public UIToggleButton FriendTabBtn;

	public UIToggleButton RecentTabBtn;

	public GameObject UnreadTip;

	public GameObject SearchGO;

	public UIButton RefreshBtn;

	public UIInput InputIDField;

	public TweenAlpha DefaultLabelWink;

	public UIButton SearchBtn;

	public GameObject SearchBtnSprite;

	public GameObject SearchClearSprite;

	public UITable2 MessageListTable2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
