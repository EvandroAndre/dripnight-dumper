using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPlotEditorDropdownItemView : UIBaseView
{
	public UILabel Label;

	public UIButton Button;

	public BoxCollider ButtonCollider;

	public UISprite Selected;

	public UISprite Border;

	public UISprite OptionNewIcon;

	public GameObject OptionNormal;

	public GameObject OptionNew;

	public UISprite OptionNewBorder;

	public UILabel OptionNewLabel;

	public UIColor OptionNewUnderline;

	public UIButton OptionNewButton;

	public BoxCollider OptionNewButtonCollider;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
