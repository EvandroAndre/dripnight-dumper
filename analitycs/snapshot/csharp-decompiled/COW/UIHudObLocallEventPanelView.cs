using GCommon;
using UnityEngine;

namespace COW;

public class UIHudObLocallEventPanelView : UIBaseView
{
	public TweenAlpha tweenAlpha;

	public TweenPosition tweenPos;

	public GameObject eventContainer;

	public GameObject PCbg;

	public GameObject bg;

	public UILabel description;

	public UILabel countDownLabel;

	public UIScrollView Scrollview;

	public UIGrid eventsGrid;

	public UIToggleButtonGroup toggleBtnGroup;

	public UIToggleButton eToggle;

	public UIButton btnCloseRight;

	public UIButton btnCloseLeft;

	public GameObject bottomBtns;

	public GameObject PCbottomBtns;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
