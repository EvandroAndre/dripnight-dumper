using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditCustomAttributeEditView : UIBaseView
{
	public UIEasyList EasyGrid;

	public UIScrollView ScrollView;

	public GameObject Empty;

	public UISprite BG;

	public UIButton EditBtn;

	public UILabel EmptyLabel;

	public UILabel EditBtnLabel;

	public Transform ScrollMenuRoot;

	public UITable TabContainer;

	public GameObject SubTab;

	public GameObject MainTab;

	public UIButton Addbutton;

	public UIButton CloseBtn;

	public UIInput SearchInput;

	public GameObject SearchDefaultLabel;

	public UIButton BtnSearch;

	public GameObject DeleteIcon;

	public GameObject LowestValueTipsData;

	public UIButton HelpBtn;

	public UIButton Tip1;

	public UIButton DatabaseBtn;

	public UIButton ShowTypeBtn;

	public GameObject ShowTypeContainer;

	public UIScrollView TypeScrollView;

	public UILabel ShowTypeLabel;

	public GameObject ShowTypeNext;

	public Transform AutoSaveSwitchLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
