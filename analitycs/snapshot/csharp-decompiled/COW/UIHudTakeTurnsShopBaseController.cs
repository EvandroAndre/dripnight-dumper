using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTakeTurnsShopBaseController : UIHudTakeTurnsShopGrandBaseController, IUIModelDataChangeObserver
{
	private List<uint> m_ChoosedItemList;

	private Dictionary<uint, UIHudTakeTurnsShopCategoryBaseController> m_CategroyMap;

	private uint MYSTERYBOX_FILTER;

	private uint m_FirstCategoryFilter;

	private UIHudAskPurchaseListController m_AskListCtrl;

	private List<UIPanel> m_Panels;

	private bool _003CIsInShowPhase_003Ek__BackingField;

	private bool m_MysteryBoxDataDirty;

	private TweenPosition m_ShopTweenPosition;

	private uint m_ItemIndex;

	private bool isRequestFilled;

	private bool m_IsResetToTop;

	private string m_RoundShopBuffKey;

	private UIHudTakeTurnsShopItemBaseController m_LongPressedItem;

	private bool m_HideByPanel;

	public bool IsInShowPhase
	{
		get
		{
			return _003CIsInShowPhase_003Ek__BackingField;
		}
		set
		{
			_003CIsInShowPhase_003Ek__BackingField = value;
		}
	}

	protected bool IsShowHideByPanelEnabled => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShowCSGuideSecondWeaponBuy(object[] data)
	{
	}

	private void OnShowCSGuideStoreGold(object[] data)
	{
	}

	private void OnShowCSGuideStoreArmorBuy(object[] data)
	{
	}

	private void OnAniFinishedShowGoldGuide()
	{
	}

	private void OnShowCSGuideStoreArmorItem(object[] data)
	{
	}

	private void OnShowCSGuideStoreWeaponClose(object[] data)
	{
	}

	private void OnShowCSGuideStoreWeaponBuy(object[] data)
	{
	}

	private void OnAniFinishedShowWeaponGuide()
	{
	}

	private void OnAniFinishedShowSecondWeaponGuide()
	{
	}

	private void OnShowCSGuideSecondWeaponItem(object[] data)
	{
	}

	private void OnShowCSGuideStoreWeaponItem(object[] data)
	{
	}

	protected override void OnInitSpecialUIElement()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected virtual void SetUIData()
	{
	}

	protected virtual void RefreshUIData(bool isPurchaseRefresh = false)
	{
	}

	protected virtual UIHudTakeTurnsShopCategoryBaseController CreateCategory(Transform container)
	{
		return null;
	}

	protected override void OnPurchaseBtnClick()
	{
	}

	protected override void OnCloseBtnClick()
	{
	}

	public override bool IsVisible()
	{
		return false;
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	private void OnAskPurchaseBtnClick()
	{
	}

	private void ClearUIData()
	{
	}

	protected override void OnItemSelected(object[] data)
	{
	}

	private void RefreshPrices(uint purchaseCnt = 0u)
	{
	}

	protected virtual bool CheckCanPurchase()
	{
		return false;
	}

	private void RefreshAskBtn(uint cost, bool isItemValid)
	{
	}

	private void OnMysteryBoxChanged(object[] data)
	{
	}

	private void UpdateMysteryBoxUI()
	{
	}

	private void OnFreeCardCountChanged(object[] data)
	{
	}

	private void OnMysteryBoxOpen(object[] data)
	{
	}

	private void OnMysteryBoxClose(object[] data)
	{
	}

	private void ResetAnim()
	{
	}

	private void OnTeammateCoinChange(object[] data)
	{
	}

	private void ClearData()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnItemCountChanged(GEvent data)
	{
	}

	private void OnPurchaseSuccess(object[] data)
	{
	}

	public void SetFreeShowView()
	{
	}

	private void RefreshCSShopTipsValue()
	{
	}

	private uint GetItemBuffId(int itemId)
	{
		return 0u;
	}

	private void OnRoundShopBuffChange(object[] data)
	{
	}

	private void OnLongPress(object[] param)
	{
	}

	public override void Hide()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
