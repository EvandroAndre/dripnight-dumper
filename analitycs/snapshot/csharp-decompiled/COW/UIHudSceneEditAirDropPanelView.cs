using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditAirDropPanelView : UIBaseView
{
	public UIButton CreateNewShelf;

	public UILabel ShopName;

	public UIScrollView ContentSV;

	public UITable SortTable;

	public UILabel ItemName;

	public GameObject TagTemplate;

	public UILabel ItemDesc;

	public UISprite ItemSprite;

	public GameObject CountSliderGo;

	public Transform BottomLeftPanelAnchor;

	public UIButton CloseBtn;

	public GameObject Container;

	public UITable SettingSortTable;

	public UIButton CountBtn;

	public UILabel CountValue;

	public Transform RightPanelAnchor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
