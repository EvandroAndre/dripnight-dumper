using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditSubscriptionV2View : UIBaseView
{
	public UIToggleButtonGroup Toggle;

	public UIToggleButton PlaysToggle;

	public UIToggleButton SubTimeToggle;

	public UIToggleButton UpdateTimeToggle;

	public UIToggleButtonGroup SortFilterBtnGroup;

	public UIToggleButton AscendingBtn;

	public UIToggleButton DescendingBtn;

	public UIScrollView CenterSV;

	public UIGrid Grid;

	public UIDragScrollView CenterScrollable;

	public GameObject Selected;

	public UIButton BtnOverwrite;

	public UIButton BtnCannel;

	public GameObject Enable;

	public GameObject Disable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
