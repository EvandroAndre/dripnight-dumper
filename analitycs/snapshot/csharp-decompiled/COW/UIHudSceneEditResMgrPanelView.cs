using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditResMgrPanelView : UIBaseView
{
	public UIButton ToggleBtn;

	public UIButton ToggleBtnReverse;

	public TweenPosition TweenPos;

	public Transform RecycleBin;

	public UIScrollView ScrollView;

	public UISprite DragFrame;

	public Transform SelectedFrame;

	public UIToggleButton FilterBtn;

	public UIButton BtnClose;

	public Transform FliterPosition;

	public UIInput SearchInput;

	public UIButton BtnClear;

	public GameObject Empty;

	public UIButton SortBtn;

	public UIButton MultiSelectBtn;

	public UILabel MultiSelectBtnTxt;

	public UIToggleButton MultiSelectToggle;

	public UISprite SortSprite;

	public UIEasyList EasyList;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
