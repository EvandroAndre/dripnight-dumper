using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHGExchangeMallController : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList
{
	public enum EMallDisplayType
	{
		CURRENTSEASON,
		PREVIOUSSEASON,
		HIDESEASONTOGGLE
	}

	public enum EExchangeItemState
	{
		OWNITEM_CAN_PURCHASE,
		OWNITEM_NO_PURCHASE,
		NO_OWNITEM_NO_PURCHASE,
		NO_OWNITEM_CAN_PURCHASE,
		NO_ITEM_SELECT
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public uint selectItemID;

		internal bool _003COnDataChanged_003Eb__0(ExchangeStoreItemDesc t)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__1(ExchangeStoreItemDesc t)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__2(ExchangeStoreItemDesc t)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__3(ExchangeStoreItemDesc t)
		{
			return false;
		}
	}

	private UIHGExchangeMallView m_View;

	private UIModelMall m_ModelMall;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelInventory m_ModelInventory;

	private List<ExchangeStoreItemDesc> m_CurrentSeasonItemList;

	private List<ExchangeStoreItemDesc> m_PreviousSeasonItemList;

	private ExchangeStoreItemDesc m_CurrentSelectItemDesc;

	private bool m_HasProcessData;

	private const uint PVE_RANK_STORE_ID = 113u;

	private EMallDisplayType m_CurrentDisplayMode;

	private EExchangeItemState m_CurrentSelectItemState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	private void RefreshStoreItemEasyList(EMallDisplayType displayType)
	{
	}

	private int CompareStoreItems(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	private void RefreshCurrencyCount()
	{
	}

	public void SetViewData()
	{
	}

	private void RefreshToggleView()
	{
	}

	private void OnSelectNormalToggle()
	{
	}

	private void OnSelectPreviousSeasonToggle()
	{
	}

	private void OnExchangeItemClickEventReceive(object[] data)
	{
	}

	private void RefreshCurrentItemView(ExchangeStoreItemDesc desc)
	{
	}

	private bool IsUniqueItem(uint itemID)
	{
		return false;
	}

	private bool IsItemOwn(uint itemID)
	{
		return false;
	}

	private void UpdateCurrentSelectItemState(ExchangeStoreItemDesc desc)
	{
	}

	private void ShowNormalPurchaseBG(bool value)
	{
	}

	private void UpdateLimitedCountLabel(ExchangeStoreItemDesc exchangeItemDesc)
	{
	}

	private void UpdateExchangeBtnView(EExchangeItemState state)
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void ShowExchangePurchasePopupWnd(ExchangeStoreItemDesc itemDesc)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
