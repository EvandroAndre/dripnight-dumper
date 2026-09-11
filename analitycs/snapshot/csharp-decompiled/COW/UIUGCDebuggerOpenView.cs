using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCDebuggerOpenView : UIBaseView
{
	public UIToggle FastTestToggle;

	public UIToggle NormalTestToggle;

	public UIToggle ToggleFillFullBot;

	public UIButton CloseBtn;

	public GameObject Expand;

	public UISprite bg;

	public UIToggle ToggleStrictMode;

	public GameObject DownloadContainer;

	public UILabel LookModeLabel;

	public UISprite LookModeBG;

	public UIToggle LookModeToggle;

	public UIToggle DebuggerModeToggle;

	public GameObject Premium;

	public UIToggleButtonGroup VipSwitch;

	public UIToggleButton VipOpen;

	public UIToggleButton VipClose;

	public UIInput DiamondValue;

	public UISlider DiamondSlider;

	public UITable Panel;

	public UILabel PlayerName;

	public Transform PlayerDropDown;

	public UIEasyList EasyGrid;

	public UIToggleButtonGroup SetUpTabToggleGroup;

	public UIWidget DataBaseScrollRoot;

	public GameObject Empty;

	public GameObject DataBasePanel;

	public UIButton GoCreatBtn;

	public UIButton Reset;

	public UISprite SavedDataBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
