using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameShopCategoryView : UIBaseView
{
	public UIWidget widget;

	public UIGrid ItemsGrid;

	public UIToggleButtonGroup toggleGroup;

	public UILabel CategoryName;

	public UIButton RefreshBtn;

	public UILabel RefreshCount;

	public UIWidget RefreshTutorialWeight;

	public UISprite Side;

	public UITable CategoryTable;

	public UIWidget AbilityPointWidget;

	public UIWidget TitleWidget;

	public GameObject ConnectLineContainer;

	public UITable AbilityPointTable;

	public UIWidget ItemGridWidget;

	public UISprite Bg;

	public GameObject Line;

	public VFXCreateHelper CSAbilityPointRefreshVFX;

	public UISprite LoadoutIcon;

	public UIPanel ActiveLineVFXMask;

	public VFXCreateHelper ActiveLineVFX;

	public UISprite Line_Finish;

	public GameObject BGSkin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
