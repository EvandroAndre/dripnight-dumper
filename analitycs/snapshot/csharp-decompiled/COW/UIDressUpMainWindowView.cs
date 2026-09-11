using GCommon;
using UnityEngine;

namespace COW;

public class UIDressUpMainWindowView : UIBaseView
{
	public Transform LeftTabContainer;

	public GameObject LeftAnimContainer;

	public GameObject FirstTabContainer;

	public Transform CollectionContainer;

	public UISprite collectionBg;

	public UISprite collectionbg;

	public GameObject CollectionContainerNode;

	public UIScrollView DressUpScrollView;

	public Animation DressUpScrollViewAni;

	public UIEasyList DressUpEasyList;

	public Transform RightTabContainer;

	public GameObject GameObjectDressUpSlotContainer;

	public UIDressUpSLotComp UIDressUpSLotCompDressUpSlotContainer;

	public GameObject DressUpExchangeContainer;

	public UIGrid DressUpExchangeGrid;

	public UIButton EquipBtn;

	public GameObject EquipCommonState;

	public UILabel EquipBtnLabel1;

	public GameObject EquipDisableState;

	public UILabel EquipBtnLabel2;

	public GameObject AlreadyEquipState;

	public UILabel EquipBtnLabel3;

	public UIButton SaveBtn;

	public GameObject GoLegendColor;

	public UIButton UIButtonBtnColorPanel;

	public UISprite UISpriteBtnColorPanel;

	public UIPanel PanelShowColor;

	public UISprite SpritePanelColorBg;

	public UIGrid GridColorPanel;

	public UIButton BagShowBtn;

	public GameObject check;

	public UIWidget PreviewBorder;

	public GameObject TailorColorContainer;

	public GameObject GroupBtn;

	public GameObject MultiSelectOpenLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
