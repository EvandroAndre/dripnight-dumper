using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditCategoryView : UIBaseView
{
	public UIScrollView CenterSV;

	public UIWidget VScrollable;

	public UIWidget ContentContainer;

	public UIGrid TabGrid;

	public GameObject TabItem;

	public UIInput SearchInput;

	public UIButton BtnSearch;

	public GameObject Empty;

	public UIEasyList MapEasyList;

	public Transform SortDropDown;

	public UIButton BtnTurnToSearchMap;

	public UILabel SearchInputText;

	public UIScrollView TabScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
