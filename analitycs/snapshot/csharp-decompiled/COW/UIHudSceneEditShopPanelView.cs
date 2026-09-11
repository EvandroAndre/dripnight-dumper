using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditShopPanelView : UIBaseView
{
	public UIButton CreateNewShelf;

	public UILabel ShopName;

	public UIButton RenameBtn;

	public UIInput InputField;

	public UIScrollView ContentSV;

	public UITable SortTable;

	public UILabel ItemName;

	public GameObject TagTemplate;

	public UILabel ItemDesc;

	public UISprite ItemSprite;

	public GameObject TotalLimitSliderGo;

	public GameObject TotalLimitToggleGo;

	public GameObject PriceSliderGo;

	public UILabel TotalLimitValue;

	public UIToggleButtonGroup TotalLimitToggle;

	public Transform BottomLeftPanelAnchor;

	public UIButton CloseBtn;

	public GameObject Container;

	public UITable SettingSortTable;

	public UIButton PriceBtn;

	public UILabel PriceValue;

	public UIButton TotalLimitBtn;

	public Transform RightPanelAnchor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
