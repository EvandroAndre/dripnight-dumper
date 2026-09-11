using GCommon;
using UnityEngine;

namespace COW;

public class UIClanSearchView : UIBaseView
{
	public GameObject Content;

	public UIScrollView ListScrollView;

	public UIEasyList ListGrid;

	public UILabel Result;

	public GameObject SearchBarContainer;

	public UIButton RefreshBtn;

	public GameObject CDBg;

	public UICountDownLabel CountDownTxt;

	public GameObject CDSprite;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UISprite SearchBtnSprite;

	public UIButton ClearBtn;

	public UIButton FilterBtn;

	public UILabel FilterCDLabel;

	public UISprite FilterBG;

	public UILabel FilterLabel;

	public GameObject FilterIcon;

	public UIButton ClanCreate;

	public GameObject ClanDetailContainer;

	public UICountDownLabel SearchCDLabel;

	public GameObject SearchCDBG;

	public GameObject TailArrSprite;

	public UIButton QRSCanBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
