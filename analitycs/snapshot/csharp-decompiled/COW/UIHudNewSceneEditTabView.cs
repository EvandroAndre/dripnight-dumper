using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNewSceneEditTabView : UIBaseView
{
	public UIToggleButton UIHudNewSceneEditTab;

	public GameObject Selected;

	public UILabel SelectedLableDesc;

	public UISprite SelectedTabSprite;

	public GameObject UnSelected;

	public UISprite UnSelectedTabSprite;

	public UILabel UnselectedLableDesc;

	public UITable SubTabGrid;

	public UIToggleButtonGroup ToggleButtonGroup;

	public GameObject Fold;

	public GameObject UnFold;

	public GameObject NewTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
