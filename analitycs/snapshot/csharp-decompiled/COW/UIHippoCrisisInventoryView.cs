using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisInventoryView : UIBaseView
{
	public GameObject RightTab;

	public UIEasyList TabEasyList;

	public UIEasyList InventoryEasyList;

	public GameObject TitleContainer;

	public UILabel InventoryCapacityLabel;

	public UIButton AddCapacityBtn;

	public Transform PopMenuPos;

	public GameObject EmptyContainer;

	public GameObject PutInMask;

	public UILabel InventoryDragCapacityLabel;

	public GameObject BottomBtns;

	public UIButton MarketBtn;

	public UIButton SellBtn;

	public UIEasyList SubTabEasyList;

	public GameObject SubTabScrollView;

	public UIButton AscendingBtn;

	public UIButton DescendingBtn;

	public GameObject CapacityContainer;

	public GameObject SellingContainer;

	public UIButton SelectAllBtn;

	public GameObject SelectedAll;

	public GameObject UnSelectedAll;

	public UILabel SelectAllLabel;

	public UIButton BatchSellBtn;

	public UILabel SelectedValueLabel;

	public UIPanel ScrollView;

	public UIHippoCrisisDragResponseContainer InventoryDragCancelArea;

	public UILabel DragRemindLabel;

	public UILabel DragCapacityChangeLabel;

	public GameObject SubTab_Container;

	public Transform ItemBriefBoxRoot;

	public UISprite PutInMaskBg;

	public UISprite PutInProgress;

	public UISprite PutInProgressAdd;

	public Transform TopCurrencyTrans;

	public UIWidget TopCurrencyTransWidget;

	public UIButton CloseBtn;

	public UILabel TitleLabel;

	public UIButton HelpBtn;

	public GameObject CloseBtnIcon;

	public UISprite ReturnIcon;

	public GameObject Inventory;

	public UISprite InventoryCapacityProgress;

	public UIButton SellMaskBtn;

	public GameObject SellMask;

	public UISprite SellBtnWidget;

	public UISprite BatchSellWidget;

	public UIWidget GuideWidget;

	public UIWidget DragGuideWidget;

	public GameObject GuideMask1;

	public GameObject GuideMask2;

	public GameObject GuideMask3;

	public UIButton SellMaterialBtn;

	public Animation MainAnim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
