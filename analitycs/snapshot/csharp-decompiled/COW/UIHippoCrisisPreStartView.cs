using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisPreStartView : UIBaseView
{
	public GameObject InventoryContainer;

	public UITable2 Table2;

	public GameObject EmptyContainer;

	public GameObject PreStartBtns;

	public UIButton RecommendLoadoutBtn;

	public UIButton ConfirmBtn;

	public UILabel WarningDescLabel;

	public UIButton EquipBtn;

	public GameObject PreStartInventoryContainer;

	public Transform ItemBriefBoxRoot;

	public UIButton BuyBtn;

	public UIEasyList TabEasyList;

	public GameObject RightTab;

	public GameObject SubTabScrollView;

	public UIEasyList SubTabEasyList;

	public GameObject SubTab_Container;

	public UIHippoCrisisDragResponseContainer InventoryDragCancelArea;

	public UIWidget PutInMaskWidget;

	public GameObject PutInMask;

	public UILabel InventoryDragCapacityLabel;

	public UILabel DragCapacityChangeLabel;

	public UISprite PutInMaskBg;

	public UISprite PutInProgress;

	public UISprite PutInProgressAdd;

	public UILabel DragRemindLabel;

	public Transform TopCurrencyTrans;

	public UIButton CloseBtn;

	public UIButton HelpBtn;

	public UILabel TitleLabel;

	public UICustomParamUtil CustomParamUtil;

	public UIButton ConfirmBtn2;

	public UIWidget ConfirmBtn2Widget;

	public UIButton PutInBagBtn;

	public GameObject FreeTips;

	public UIButton RecommendLoadoutBtn2;

	public UIWidget RecommendLoadoutBtn2Widget;

	public UIPanel ScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
