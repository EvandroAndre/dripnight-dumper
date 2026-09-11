using GCommon;
using UnityEngine;

namespace COW;

public class UICommonSettingItemView : UIBaseView
{
	public UIWidget Widget;

	public GameObject Mask;

	public UILabel LeftLabel;

	public UIButton TipBtn;

	public UISprite BtnBG;

	public UIGrid Grid;

	public CommonSettingToggleItem ToggleContainer;

	public GameObject RedTips;

	public UITipsButton RedTipsButton;

	public UIWidget AsChildWidget;

	public UILabel ChildLabel;

	public UISprite NewLabel;

	public Transform DownLoadContainer;

	public GameObject SelectedSprite;

	public GameObject SelectedSpriteChild;

	public UIButton SelectedBtn;

	public UIToggleButtonGroup ToggleGroup;

	public UISprite ChildNewLabel;

	public Transform RedTipContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
