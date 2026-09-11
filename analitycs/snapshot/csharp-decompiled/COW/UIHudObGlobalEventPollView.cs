using GCommon;
using UnityEngine;

namespace COW;

public class UIHudObGlobalEventPollView : UIBaseView
{
	public TweenPosition tweenPos;

	public GameObject PollContainer;

	public UILabel descMaxCount;

	public UILabel descEffectTime;

	public UIScrollView pollScrollview;

	public UIGrid checkBoxGrid;

	public UICheckBoxButtonGroup checkBoxGroup;

	public UICheckboxButton eventCheckBoxBtn;

	public UIGrid toggleGrid;

	public UIToggleButtonGroup pollToggleGroup;

	public UIToggleButton eventToggleBtn;

	public UIButton btnConfirm;

	public GameObject ResultContainer;

	public UIScrollView resultScrollview;

	public UIGrid resultGrid;

	public GameObject resultItem;

	public UIButton btnClose;

	public UIButton btnClosePC;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
