using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCBlockTemplateWndView : UIBaseView
{
	public UIPanel UIHudUGCBlockTemplateWnd;

	public UISprite TipBg;

	public UITable TipContent;

	public UILabel TipName;

	public UILabel TipDescription;

	public UIButton TipEditBtn;

	public UIButton TipDeleteBtn;

	public UIToggleButtonGroup ToggleGroup;

	public UIToggleButton LibraryToggle;

	public UIToggleButton CustomToggle;

	public GameObject Content;

	public UIScrollView ContentSV;

	public UIPanel ContentPanel;

	public UIButton CloseBtn;

	public UIEasyList ContentEasyList;

	public GameObject TipContainer;

	public UIButton WebViewBtn;

	public UIWidget DragGuide;

	public UISprite Bg;

	public UISprite TipDescBg;

	public GameObject CustomEmpty;

	public GameObject LibraryEmpty;

	public UIWidget TemplateGuide;

	public GameObject TipsBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
