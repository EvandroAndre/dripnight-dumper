using GCommon;
using UnityEngine;

namespace COW;

public class UIMallV2SelectPlayerPopupWndView : UIBaseView
{
	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UIToggleButton FriendBtn;

	public UIToggleButton ClanFriendBtn;

	public UIEasyList Grid;

	public UILabel Tips;

	public UIButton RefreshBtn;

	public UIButton CloseSelectFriendPanelBtn;

	public UIButton CancelSearchBtn;

	public UIWidget ScrollViewWidget;

	public UIScrollView ScrollView;

	public GameObject FriendBtnHighlight;

	public GameObject ClanBtnHighlight;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
