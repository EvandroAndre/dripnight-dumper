using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSceneEditShopChosenPanelView : UIBaseView
{
	public UIPanel UIHudSceneEditShopChosenPanel;

	public UIWidget WidgetContainer;

	public UIWidget TabContainer;

	public UIScrollView TabScrollView;

	public UIGrid MainTabGrid;

	public UIToggleButtonGroup MainTabButtonGroup;

	public UIHudSceneEditItemPanelTabView PanelTabView;

	public UIScrollView SubTabScrollView;

	public UIGrid SubTabGrid;

	public UIToggleButtonGroup SubTabButtonGroup;

	public UIHudSceneEditItemPanelTabView PanelSubTabView;

	public UIScrollView ItemListScrollView;

	public UIEasyList ItemListGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
