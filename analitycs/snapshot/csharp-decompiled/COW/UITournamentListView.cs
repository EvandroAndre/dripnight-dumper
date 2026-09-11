using GCommon;
using UnityEngine;

namespace COW;

public class UITournamentListView : UIBaseView
{
	public Transform RoomTypeTab;

	public GameObject Content;

	public UIWidget Listbg;

	public UIScrollView ListScrollView;

	public UIEasyList ListGrid;

	public UILabel Result;

	public GameObject Arrow;

	public GameObject SearchBarContainer;

	public UIButton RefreshBtn;

	public GameObject SpriteRefresh;

	public UILabel RefreshTxt;

	public UICountDownLabel CountDownTxt;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UISprite SearchBtnSprite;

	public UIButton ClearBtn;

	public Transform StateDropList;

	public UIButton PasteEnableBtn;

	public UIButton QRSCanBtn;

	public Transform PreviewSettingPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
