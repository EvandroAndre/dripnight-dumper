using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNewSceneEditSubTabView : UIBaseView
{
	public UIToggleButton UIHudNewSceneEditSubTab;

	public GameObject Selected;

	public UILabel SelectedLableDesc;

	public GameObject UnSelected;

	public UILabel UnselectedLableDesc;

	public GameObject NewTips;

	public UISprite Icon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
