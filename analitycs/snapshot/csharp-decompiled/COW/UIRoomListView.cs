using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomListView : UIBaseView
{
	public Transform RoomTypeTab;

	public GameObject Content;

	public UIWidget Listbg;

	public UIScrollView ListScrollView;

	public UIEasyList ListGrid;

	public UILabel Result;

	public GameObject Arrow;

	public UIButton RoomCreate;

	public GameObject newModeGuide;

	public UILabel LabelDailyTask;

	public GameObject SearchBarContainer;

	public UIButton RefreshBtn;

	public GameObject SpriteRefresh;

	public UILabel RefreshTxt;

	public UICountDownLabel CountDownTxt;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UISprite SearchBtnSprite;

	public UIButton ClearBtn;

	public GameObject FreeRoomCreate;

	public GameObject NormalRoomCreate;

	public Transform ModeDropList;

	public Transform GroupDropList;

	public UIButton QuickJoinBtn;

	public UIButton UGCRoomListBtn;

	public UILabel QuickJoinRefresh;

	public UICountDownLabel QuickJoinCountDown;

	public UILabel QuickJoinLabel;

	public UIButton PasteEnableBtn;

	public UIButton BatchRoomCreate;

	public UISprite UGCRoomListIcon;

	public UILabel UGCRoomListText;

	public GameObject UGCRoomListEffect;

	public UISprite UGCRoomListSprite;

	public UIButton QRSCanBtn;

	public GameObject UGCRoomListBtnMask;

	public GameObject UGCRoomListBtnLock;

	public UILabel UGCRoomListBtnLockLabel;

	public Transform PreviewSettingPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
