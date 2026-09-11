using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTeammatesInfoView : UIBaseView
{
	public Transform Grid;

	public UIHudTeammateItem teammateInfo1;

	public UIWidget TutorialWidget;

	public UIToggleButtonGroup PageToggleGroup;

	public UIToggleButton Page1Toggle;

	public UIToggleButton Page2Toggle;

	public UIToggleButton Page3Toggle;

	public UIScrollView RootScrollview;

	public UIWrapContent WrapContent;

	public Transform PageGridTemplate;

	public UIEventListener ScoreBoardBtn;

	public UIToggleButton Page4Toggle;

	public UIGrid ToggleGroupGrid;

	public UIHudTeammateItem teammateInfo2;

	public UIHudTeammateItem teammateInfo3;

	public UIHudTeammateItem teammateInfo4;

	public List<UIHudTeammateItem> TeammateItemList;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
