using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureTeamListBoxView : UIBaseView
{
	public TweenPosition Tween;

	public GameObject AnchorContainer;

	public GameObject BG;

	public GameObject Top;

	public UIToggleButtonGroup TopTabToggleGroup;

	public UIGrid TopTabGrid;

	public UIToggleButton TeamTabButton;

	public UIWidget TeamTabWidget;

	public UIToggleButton InviteTabButton;

	public UIWidget InviteTabWidget;

	public GameObject Center;

	public GameObject EmptyTeamObj;

	public GameObject ScrollViewWidget;

	public UIScrollView ScrollView;

	public UITable2 Grid;

	public GameObject Bottom;

	public UIButton RefreshBtn;

	public UIButton QRCodeBtn;

	public UIButton TeamCodeBtn;

	public UIButton QuickJoinBtn;

	public UIButton Mask;

	public UITable2Item ClanAndFriendTeamTitle;

	public UITable2Item AllTeamTitle;

	public UIScrollView InvitationScrollView;

	public UITable Table;

	public GameObject RefreshSprite;

	public UICountDownLabel RefreshCDLabel;

	public UIToggleButton HistoryTabButton;

	public UIWidget HistoryTabWidget;

	public UIWidget QucikJoinGuideWidget;

	public GameObject ActiveState;

	public GameObject GrayState;

	public UILabel QuickJoinLabel;

	public UICountDownLabel QuickJoinRefreshCDLabel;

	public GameObject TeamBottom;

	public GameObject HistoryBottom;

	public UIButton ShowMoreBtn;

	public UIScrollView HistoryScrollView;

	public UITable2 HistoryGrid;

	public UISprite TeamTabBg;

	public UISprite HistoryTabBg;

	public UISprite InviteTabBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
