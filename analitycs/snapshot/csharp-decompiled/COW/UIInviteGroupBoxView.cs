using GCommon;
using UnityEngine;

namespace COW;

public class UIInviteGroupBoxView : UIBaseView
{
	public GameObject Mask;

	public GameObject ClickFilter;

	public Transform CenterParent;

	public TweenPosition Pivot;

	public GameObject RecentTitle;

	public UIScrollView ScrollView;

	public UIEasyList List;

	public UIGrid RightGrid;

	public UIToggleButtonGroup RightGroup;

	public UIToggleButton FriendTab;

	public UIToggleButton ClanTab;

	public UIToggleButton RecentTab;

	public GameObject BottomBG;

	public GameObject BottomGrid;

	public UIButton QuickEnter;

	public UIButton Community;

	public UILabel CommunityLabel;

	public UIButton AddFriend;

	public UIButton CloseBtn;

	public GameObject SearchObj;

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

	public GameObject PublicRoot;

	public UILabel publicLabel;

	public UIButton PublicBtn;

	public GameObject PublicToggleOn;

	public GameObject PublicToggleOff;

	public GameObject PublicMember;

	public UIWidget OriginWidget;

	public UIWidget SmallWidget;

	public GameObject FloatingWindows;

	public GameObject FloatingWindows2;

	public Transform BriefBoxPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
