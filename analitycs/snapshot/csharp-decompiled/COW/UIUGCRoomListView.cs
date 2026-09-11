using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCRoomListView : UIBaseView
{
	public GameObject Content;

	public UIWidget Listbg;

	public UIScrollView ListScrollView;

	public UIEasyList ListGrid;

	public UILabel Result;

	public GameObject Arrow;

	public UIButton RoomCreate;

	public GameObject SearchBar;

	public UIButton RefreshBtn;

	public GameObject SpriteRefresh;

	public UILabel UILabelRefreshTxt;

	public UICountDownLabel UICountDownLabelRefreshTxt;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UISprite icon;

	public UIButton ClearBtn;

	public Transform ModeDropList;

	public Transform GroupDropList;

	public UIButton QuickJoinBtn;

	public GameObject Back;

	public UIButton BackBtn;

	public UIWidget BackBtnWidget;

	public UILabel LabelCode;

	public GameObject InfoResult;

	public GameObject ItemInfo;

	public UIButton RoomJoinBtn;

	public UIButton SpectateJoinBtn;

	public UILabel MapName;

	public UILabel RoundLabel;

	public UILabel TeamLabel;

	public UIButton BtnFullPreview;

	public UITable TagTable;

	public UILabel DescLabel;

	public Transform HotTrans;

	public UISprite MapWidget;

	public UIPanel MapExtarInfo;

	public Transform MapContainer;

	public UITable InfoListTable;

	public GameObject DescArrow;

	public UIPanel MapComment;

	public UIScrollView ScrollDesc;

	public UIPanel UIPanelUGCRoomList;

	public GameObject MapDotTrans;

	public GameObject UIFX_RiseEffect;

	public UILabel QuickJoinLabel;

	public UILabel QuickJoinRefreshLabel;

	public UICountDownLabel QuickJoinCDLabel;

	public TweenAlpha RoomJoinBtnTween;

	public TweenAlpha SpectateJoinBtnTween;

	public UIButton PasteEnableBtn;

	public Transform Like;

	public UIButton BtnDetails;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
