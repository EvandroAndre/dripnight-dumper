using GCommon;
using UnityEngine;

namespace COW;

public class UIForgeView : UIBaseView
{
	public GameObject Container;

	public GameObject Toggles;

	public UIScrollView ToggleScrollView;

	public UIToggleButton Toggle;

	public UIGrid ToggleGrid;

	public UIToggleButtonGroup ToggleGroup;

	public UIScrollView ItemScrollView;

	public UIEasyList Grid;

	public UIButton ExchangeBtn;

	public UISprite BuyBtnBG;

	public UISprite ExchangeIcon;

	public UILabel ExchangeBtnLabel;

	public UILabel LabelLimitedCount;

	public UITable NotEnoughMaterial;

	public UISprite NotEnoughMaterial1;

	public UISprite NotEnoughMaterial2;

	public UIWidget PreviewBorder;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
