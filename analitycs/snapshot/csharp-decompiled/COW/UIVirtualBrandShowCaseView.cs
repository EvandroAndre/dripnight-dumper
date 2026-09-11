using GCommon;
using UnityEngine;

namespace COW;

public class UIVirtualBrandShowCaseView : UIBaseView
{
	public UIEasyList SetList;

	public UISprite PoseCdn;

	public UIButton BtnObtain;

	public GameObject Idle;

	public UIScrollView ScrollView;

	public UIWidget PreviewBorder;

	public Transform ObtainSet;

	public UIPanel GuideMaskPanel;

	public UIButton GuideMaskBtn;

	public Transform EntranceEffect;

	public UIButton BtnDisableObtain;

	public Transform FrontEffect;

	public UILabel LabelDisableObtain;

	public GameObject Main;

	public UIButton BtnSkip;

	public UIScrollView WideScrollView;

	public UIEasyList WideSetList;

	public UIGrid TabSwitchGrid;

	public Transform BrandSwitchRoot;

	public Transform CollectionValueRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
