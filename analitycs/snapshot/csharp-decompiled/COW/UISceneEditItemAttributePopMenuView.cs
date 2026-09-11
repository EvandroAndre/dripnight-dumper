using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditItemAttributePopMenuView : UIBaseView
{
	public UILabel ParamNameLabel;

	public UIPanel Container;

	public GameObject MainPart;

	public UISprite ArrUp;

	public UISprite ArrDown;

	public UILabel Title;

	public UISprite Icon;

	public GameObject ScrollViewUpContainer;

	public UIScrollView ScrollViewUp;

	public UIPanel ScrollViewUpPanel;

	public UIGrid UpGrid;

	public UISprite BGUp;

	public GameObject ScrollViewDownContainer;

	public UIScrollView ScrollViewDown;

	public UIPanel ScrollViewDownPanel;

	public UISprite BGDown;

	public UIGrid DownGrid;

	public Transform PopMenuUpContainer;

	public Transform PopMenuDownContainer;

	public UIButton FunctionButton;

	public UIButton Tip;

	public UISprite BtnIcon;

	public UIButton OpenBtn;

	public UISprite bg;

	public UIPanel BGPanelUp;

	public UIPanel BGPanelDown;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
