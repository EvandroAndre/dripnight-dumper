using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditShopItemView : UIBaseView
{
	public GameObject ItemContent;

	public GameObject EmptyContent;

	public UILabel ItemName;

	public UIButton SwitchBtn;

	public UIButton DelBtn;

	public UILabel ItemCost;

	public UISprite ItemSprite;

	public GameObject SelectedBg;

	public UIButton UIHudSceneEditShopItem;

	public TweenScale TS;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
