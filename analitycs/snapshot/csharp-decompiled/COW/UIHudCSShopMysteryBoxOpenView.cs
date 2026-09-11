using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSShopMysteryBoxOpenView : UIBaseView
{
	public UILabel title;

	public UIButton bgBtn;

	public UIButton helpBtn;

	public UILabel countdown;

	public UIGrid grid;

	public UIToggleButtonGroup gridToggleGroup;

	public UIHudCSMysteryBoxOptionItemView optionItem;

	public GameObject HL;

	public UIButton confirmBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
