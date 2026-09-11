using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2InviteGroupBoxView : UIBaseView
{
	public GameObject RecentTitle;

	public UIScrollView ScrollView;

	public UIEasyList List;

	public UIGrid RightGrid;

	public UIToggleButtonGroup RightGroup;

	public UIToggleButton FriendTab;

	public UIToggleButton ClanTab;

	public UIToggleButton RecentTab;

	public GameObject BottomGrid;

	public Transform TableRoot;

	public UITable BottomGridTable;

	public UIButton QuickEnter;

	public UIButton Community;

	public UIButton AddFriend;

	public UIButton CloseBtn;

	public UIInput SearchInput;

	public TweenAlpha SearchTweenLabel;

	public UIButton SearchBtn;

	public UISprite SearchBtnSprite;

	public GameObject SearchClearSprite;

	public UIButton RefreshBtn;

	public GameObject RefreshNormalObj;

	public GameObject RefreshGreyObj;

	public UICountDownLabel RefreshCDLabel;

	public UIButton AddClan;

	public GameObject EmptyClanObj;

	public GameObject EmptyRecentObj;

	public GameObject FloatingWindows;

	public GameObject FloatingWindows2;

	public Transform BriefBoxPos;

	public UIButton ChangeBtn;

	public Transform LeaderBoardPos;

	public GameObject SearchObj;

	public TweenPosition Tween;

	public UIWidget ScrollViewWidget;

	public UIWidget AnchorContainer;

	public UIButton SearchMini;

	public UIButton CommunityFull;

	public UIButton Return;

	public GameObject StatusList;

	public UIToggleButton BtnInviteMe;

	public UIToggleButton BtnOnline;

	public UIToggleButton BtnDontDisturb;

	public GameObject Arrowdown;

	public GameObject Arrowup;

	public UIButton StatusBtn;

	public GameObject Status;

	public Transform RefreshBtnRightPos;

	public Transform RefreshBtnLeftPos;

	public UISprite CurrentStatusIcon;

	public UILabel CurrentStatusLabel;

	public UIWidget StatusMask;

	public GameObject AddFriendContainer;

	public UIWidget AddFriendContainerWidget;

	public UIButton AddFriendBtn;

	public UIWidget AddFriendWidget;

	public UILabel EmptyFriendSearchObj;

	public UISprite TabLine;

	public UILabel StrangerSearchTitleObj;

	public GameObject SearchResultHintContainer;

	public UIToggleButton RoomTab;

	public GameObject RoomTitle;

	public GameObject NewBeeRecPanel;

	public UITable NewBeeRecTable;

	public UIButton RefreshNewBeeRecBtn;

	public GameObject NewBeeRecTopGO;

	public UILabel RefreshNewBeeRecCountDownLabel;

	public UIButton RefreshNewBeeRecCountDownLabelBtn;

	public UISprite NewBeeRecBG;

	public GameObject Light;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
