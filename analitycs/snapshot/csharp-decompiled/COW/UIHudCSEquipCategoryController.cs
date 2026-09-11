using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCSEquipCategoryController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__65_0;

		internal int _003CSetMysteryBoxUI_003Eb__65_0(uint a, uint b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public List<uint> qualityList;

		public int i;

		public Predicate<CSShopItemData> _003C_003E9__1;

		internal bool _003CSetMysteryBoxUI_003Eb__1(CSShopItemData item)
		{
			return false;
		}
	}

	protected UIHudInGameShopCategoryView m_View;

	protected UIHudCSEquipItemController m_FirstItem;

	protected uint m_Filter;

	protected string m_FilterKey;

	private List<CSShopItemData> m_MysteryBoxItemDataList;

	private List<UIHudCSEquipItemController> m_ChildMysteryBoxController;

	private List<UIToggleButton> m_ToggleList;

	private bool m_UIDirty;

	private uint m_TopQuality;

	protected Dictionary<uint, UIHudCSEquipItemController> m_itemMap;

	protected Dictionary<byte, UIHudCSEquipItemController> m_refreshShopSlotMap;

	protected Dictionary<uint, UIHudCSAbilityPointNodeController> m_csAbilityPointNodeMap;

	private List<UIHudCSAbilityPointNodeController> m_csAbilityPointNodeList;

	private uint m_CurSelectedAbilityPointLevel;

	private List<CSShopItemData> m_CSAbilityPointSourceItemList;

	private List<UIHudCSEquipItemController> m_CSAbilityPointRecycleItems;

	private List<GameObject> m_ConnectLineList;

	private bool m_ConnectLineActiveVFXMaskStartXInited;

	private float m_ConnectLineActiveVFXMaskStartX;

	private GameObject m_BgSkinObject;

	private UISprite m_BgSkinSprite;

	private Color m_CategoryIconColorDefault;

	private int m_CategoryIconWidthDefault;

	private string m_CategoryIconDefault;

	private string m_CategoryBgDefault;

	private string m_LineFinishDefault;

	private ResourceID m_PowerUpAbilityBgFXDefault;

	private bool m_AddCallback;

	private UIScrollView m_targetScrollView;

	public UIHudCSEquipItemController FirstItem => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspended()
	{
		return false;
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void RecordDefaultSkin()
	{
	}

	private static ResourceID GetVFXHelperDefaultResId(VFXCreateHelper vfxHelper)
	{
		return default(ResourceID);
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnInitCSAbilityPointInfo()
	{
	}

	private void OnCSAbilityPointCurChoosedLevelChanged()
	{
	}

	private void RefreshConnectLineActiveVFXMask()
	{
	}

	public void SetCurSelectedCSAbilityPointLevel(uint level)
	{
	}

	private void OnRefreshClick()
	{
	}

	public bool IsQuickBuyItem(CSShopItemData item)
	{
		return false;
	}

	public void SetRefreshShopUI(bool forceInit = false)
	{
	}

	public void RefreshShopOnRefresh(uint filter)
	{
	}

	public virtual void SetUIData(uint filter, List<CSShopItemData> itemList)
	{
	}

	public virtual void RefreshUIData(uint filter, List<CSShopItemData> itemList, bool isPurchaseRefresh = false)
	{
	}

	private bool UseCSAbilityPointItemRecycleOpt()
	{
		return false;
	}

	private bool UseCSAbilityPointItemRecycleOpt(uint filter)
	{
		return false;
	}

	private List<CSShopItemData> GetCSAbilityPointSourceItemList()
	{
		return null;
	}

	private int RefreshCSAbilityPointRecycleItems(List<CSShopItemData> itemList, bool isPurchaseRefresh = false)
	{
		return 0;
	}

	private UIHudCSEquipItemController GetCSAbilityPointRecycleItem(int index)
	{
		return null;
	}

	private void HideUnusedCSAbilityPointRecycleItems(int startIndex)
	{
	}

	private CSShopItemData GetRealShopItemData(CSShopItemData item, IHFFDJIDIAA financialMgr)
	{
		return null;
	}

	private uint GetRoundShopBuffId(uint itemId)
	{
		return 0u;
	}

	private void SetItemControllerData(UIHudCSEquipItemController itemCtrl, CSShopItemData item, IHFFDJIDIAA financialMgr, bool isPurchaseRefresh = false, bool forceInit = false)
	{
	}

	private void ResizeWidget(int activeItemCnt)
	{
	}

	protected virtual UIHudCSEquipItemController CreateItem(Transform container)
	{
		return null;
	}

	public void SetFilterTitle(string itemTitle)
	{
	}

	protected void SetFilterLabel(uint filter)
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	private bool CreateBgSkinObject(ResourceID bgSkinResID)
	{
		return false;
	}

	private void ClearBgSkinObject()
	{
	}

	public void SetBombUIData(uint filter, List<TDMLikeShopConfigData> dataList)
	{
	}

	private bool SetMysteryBoxUI()
	{
		return false;
	}

	public bool UpdateMysteryBoxUI()
	{
		return false;
	}

	public Dictionary<uint, UIHudCSEquipItemController> GetItemCtrlMap()
	{
		return null;
	}

	public void SetRefreshCount()
	{
	}

	public void SetRefreshCount(uint count)
	{
	}

	protected override void OnDestroy()
	{
	}

	public void SetDragCallback(UIScrollView scrollView)
	{
	}

	private void CheckItemVisibleInScrollView()
	{
	}

	private bool IsItemVisibleInScrollView()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsSuspended()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
