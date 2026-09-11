using GCommon;
using UnityEngine;

namespace COW;

public class UIHudObGlobalEventPanelView : UIBaseView
{
	public TweenPosition tweenPos;

	public UILabel description;

	public UIScrollView Scrollview;

	public UITable table;

	public UIGrid eventsGrid;

	public UICheckBoxButtonGroup checkBoxButtonGroup;

	public GameObject eventItem;

	public UICheckboxButton eventBtn;

	public UICheckboxButton eventBtn2;

	public UICheckboxButton pollcheckBox;

	public UIButton tipsBtn;

	public UITable poll;

	public GameObject pollToggles;

	public UIToggleButton singleToggle;

	public UIToggleButton multipleToggle;

	public GameObject a2multipleOptionsContainer;

	public UIToggleButton multiOption1;

	public UILabel multiOption1Label;

	public UIToggleButton multiOption2;

	public UILabel multiOption2Label;

	public UILabel countdown;

	public UIToggleButton time1;

	public UILabel time1Label;

	public UIToggleButton time2;

	public UILabel time2Label;

	public UILabel noPollDescription;

	public UIButton btnConfirm;

	public UIButton btnClose;

	public UIButton btnClosePC;

	public UILabel executeCD;

	public UIToggleButtonGroup JumpToggles;

	public UIToggleButtonGroup MoveToggles;

	public UIToggleButton TwoToggle;

	public UILabel TwoLabel;

	public UIToggleButton FourToggle;

	public UILabel FourLabel;

	public UIToggleButton MoveOneToggle;

	public UILabel MoveOneLabel;

	public UIToggleButton MoveTwoToggle;

	public UILabel MoveTwoLabel;

	public UIToggleButton MoveThreeToggle;

	public UILabel MoveThreeLabel;

	public UILabel JumpLabel;

	public UILabel MoveLabel;

	public UICheckboxButton JumpCheckBox;

	public UICheckboxButton MoveCheckBox;

	public GameObject JumpContainer2;

	public GameObject MoveContainer2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
