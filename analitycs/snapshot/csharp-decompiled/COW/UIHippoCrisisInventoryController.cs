using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisInventoryController : UINavigationController, IEasyList, IUIModelDataChangeObserver, IUIHippoCrisisDragResponseController
{
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UIHippoCrisisInventoryController _003C_003E4__this;

		public ulong guideItemUniqueId;

		public bool init;

		public int itemId;

		public int index;

		internal bool _003CScrowAndGuideItem_003Eb__0(HippoCrisisOutGameItemUIData x)
		{
			return false;
		}

		internal void _003CScrowAndGuideItem_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public HippoCrisisOutGameItemUIData removeData;

		internal bool _003COnDragToOtherAreaSuccess_003Eb__0(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public HippoCrisisOutGameItemUIData item;

		internal bool _003COnSplitItemInInventory_003Eb__0(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}

		internal bool _003COnSplitItemInInventory_003Eb__1(HippoCrisisOutGameItemUIData a)
		{
			return false;
		}
	}

	private UIHippoCrisisInventoryView m_View;

	private List<HippoCrisisInventoryTabData> m_TabDataList;

	private List<HippoCrisisInventorySubTabData> m_SubTabDataList;

	private HippoCrisisInventoryTab m_CurrentTab;

	private HippoCrisisInventorySubTab m_CurrentSubTab;

	private UIPopMenuSmallControler m_InventoryPopMenuCtrl;

	private UIHippoCrisisItemBriefBoxController m_ItemBriefBoxCtrl;

	private HippoCrisisPopMenuSort m_CurrentPopMenuSort;

	private Transform m_EquipmentBriefBoxTransform;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private List<HippoCrisisOutGameItemUIData> m_CurrentInventoryShowItems;

	private UIHippoCrisisDragResponseContainer m_DragResponseContainer;

	private IHippoCrisisBackPackItemUIData m_CurrentDragingItem;

	private UIHippoCrisisCommonTopCurrencyController m_CurrencyCtrl;

	public static Color NORMAL_COLOR;

	public static Color HILIGHT_COLOR;

	public static Color HILIGHT_COLOR_RED;

	public static Color PROGRESS_COLOR_RED;

	public static Color PROGRESS_COLOR_YELOW;

	public static Color PROGRESS_INVENTORY_WHITE;

	private bool m_IsSelling;

	private bool m_IsDecending;

	private uint m_SelectedSellingValue;

	private bool m_IsSelectAll;

	private uint m_CurrentDragItemWeight;

	private uint m_CurrentDragItemValue;

	private UIHudHippoCrisisEquipmentContainerController m_EquipmentContainerCtrl;

	private Dictionary<uint, string> m_PopMenuToKey;

	private int m_NextGuideStep;

	private uint m_GuideDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void CheckGuideState()
	{
	}

	private void StartGuideByEvent()
	{
	}

	private void StartGuide(bool init = false)
	{
	}

	private void ScrowAndGuideItem(NewbieGuideId guideId, bool init)
	{
	}

	private void InitRightTabAndInventoryItems()
	{
	}

	private void OnTabClick(HippoCrisisInventoryTab tab)
	{
	}

	private void SetSubTabView(HippoCrisisInventoryTab tab)
	{
	}

	private void ShowSubTab(HippoCrisisInventoryTab parentTab)
	{
	}

	private void OnSubTabClick(HippoCrisisInventorySubTab tab)
	{
	}

	private void InitTopRightBar()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void UpdateInventoryShow()
	{
	}

	private void ShowInventoryItemsFilterByCurrentSubTab()
	{
	}

	private void ShowInventoryItemsFilterByCurrentTab()
	{
	}

	private void UpdateInventoryItems(bool autoResetScroll = true)
	{
	}

	private void InitSortPopMenu()
	{
	}

	private void RefreshCapacity()
	{
	}

	private void GeneratePopMenuData()
	{
	}

	private void OnPopMenuSelect(object data)
	{
	}

	private void SortByPopMenu()
	{
	}

	private void OnSortFilterBtnClick()
	{
	}

	private void OnAddCapacityBtnClick()
	{
	}

	private void OnClickEquipment(object[] param)
	{
	}

	private void OnClickCostItem(bool isEmpty)
	{
	}

	private void OnClickAttach(object[] param)
	{
	}

	private void InitDragContainerInfo()
	{
	}

	public HippoCrisisDragOperationResult HippoCrisisDragResponseCB(HippoCrisisDragSourceInfo hippoCrisisDragSourceInfo, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	private void UpdateCurrentShowItems(HippoCrisisOutGameItemUIData data, bool isAdd)
	{
	}

	private void OnDragStart(object[] param)
	{
	}

	private void OnDragEnd()
	{
	}

	private void OnDragOver(object[] param)
	{
	}

	private void OnDragOut(object[] param)
	{
	}

	private void OnDragToOtherAreaSuccess(object[] param)
	{
	}

	private void OnDragToInventorySuccess(object[] param)
	{
	}

	private void OnSplitItemInInventory(object[] param)
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void OnSellBtnClick()
	{
	}

	private void EnterSelling()
	{
	}

	private void ExitSelling()
	{
	}

	private void RefreshSelectAll()
	{
	}

	private void OnSellAllBtnClick()
	{
	}

	private void OnBatchSellBtnClick()
	{
	}

	private void OnSellMaterialBtnClick()
	{
	}

	private void RefreshDataOnly()
	{
	}

	private void RefreshCloseButtonSprite()
	{
	}

	private void OnItemSelectedSell(object[] param)
	{
	}

	private void OnSellMaskClick()
	{
	}

	private void ShowItemBriefBox(object[] param)
	{
	}

	private void OnMarketBtnClick()
	{
	}

	private void OnPurchaseSuccess(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void HPInventoryHandDragBackpackGuide(Transform item, int width, int height)
	{
	}

	private void OnDragSuccess()
	{
	}

	private void _003CStartGuide_003Eb__39_0()
	{
	}

	private void _003CStartGuide_003Eb__39_1()
	{
	}

	private void _003CStartGuide_003Eb__39_2()
	{
	}

	private void _003CStartGuide_003Eb__39_3()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
