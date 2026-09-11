using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILadderMatchExchangeMallWndController : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList
{
	public enum EMallDisplayType
	{
		HIDESEASONTOGGLE,
		CURRENTSEASON,
		PERVIOUSSEASON
	}

	public enum EExchangeItemState
	{
		OWNITEM_CAN_PURCHASE,
		OWNITEM_NO_PURCHASE,
		NO_OWNITEM_NO_PURCHASE,
		NO_REACH_CS_RANKLIMIT,
		NO_REACH_BR_RANKLIMIT,
		NO_REACH_BR_CS_RANKLIMIT,
		NO_OWNITEM_CAN_PURCHASE,
		NO_ITEM_SELECT
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public uint itemID;

		internal bool _003COnNavigationShowed_003Eb__0(ExchangeStoreItemDesc item)
		{
			return false;
		}

		internal bool _003COnNavigationShowed_003Eb__1(ExchangeStoreItemDesc item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
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

	private UILadderMatchExchangeMallView m_View;

	private UIModelMall m_ModelMall;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelLadderMatch m_ModelLadderMatchBR;

	private UIModelCSLadderMatch m_ModelLadderMatchCS;

	private UIModelInventory m_ModelInventory;

	private int m_DisplayListColumnCnt;

	private uint m_CurrentItemCSRankLimit;

	private uint m_CurrentItemBRRankLimit;

	private List<ExchangeStoreItemDesc> m_CurrentSeasonItemList;

	private List<ExchangeStoreItemDesc> m_PreviousSeasonItemList;

	private ExchangeStoreItemDesc m_CurrentSelectItemDesc;

	private ExchangeStoreItemDesc m_NullStoreItem;

	private RankExchangeDisplayDesc m_ExchangeStoreDisplayItem;

	private const string RANK_PREFIX = "Rank_";

	private EMallDisplayType m_CurrentDisplayMode;

	private EExchangeItemState m_CurrentSelectItemState;

	private bool m_HasSelectItemBefore;

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

	private void RefreshStoreItemEasyList(List<ExchangeStoreItemDesc> dataList, EMallDisplayType displayType)
	{
	}

	private void RefreshCurrencyCount()
	{
	}

	public void InitDataAndUI()
	{
	}

	public void InitSeasonBGCDN()
	{
	}

	public void UpdateLatestExchangeItemData()
	{
	}

	public void InitNullStoreItem()
	{
	}

	public void AddNullDataToRankExchangeStoreList(int num, List<ExchangeStoreItemDesc> list)
	{
	}

	private void InitStoreDisplayMode()
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
