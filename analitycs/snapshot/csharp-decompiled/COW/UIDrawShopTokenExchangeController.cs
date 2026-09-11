using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopTokenExchangeController : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public UISprite target;

		public int savedLeftAbs;

		public int savedRightAbs;

		internal void _003CRefreshMaterialView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UIDrawShopTokenExchangeController _003C_003E4__this;

		public string redeemLocKey;

		internal void _003CRefreshNotEnoughMaterialWithDiamondState_003Eb__0(bool downloadSuccess, string spriteName, bool hasPending)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public uint itemId;

		internal bool _003CNavigationToItem_003Eb__0(DrawShopWheelExchangeDesc item)
		{
			return false;
		}
	}

	private UIDrawShopTokenExchangeView m_View;

	private UINavigationData m_LastNavigationData;

	private uint m_DrawShopId;

	private uint m_DrawShopSubId;

	private uint m_NavItemId;

	private CSSharedItemData m_ItemData;

	private List<DrawShopWheelExchangeDesc> m_CurrentDataList;

	private bool m_ExchangeDataInitialized;

	private List<UISprite> m_NotEnoughMaterial;

	private uint m_SelectedId;

	private uint m_SelectedItemId;

	private bool m_HaveEnoughMaterial;

	private bool m_CanExchangeByDiamond;

	private const uint EXCHANGE_LABEL_GREY = 2139062271u;

	private bool m_ItemCanExchange;

	private bool m_HasEnoughDiamond;

	private uint m_RequiredDiamonds;

	private uint m_TokenId;

	private Color RED_COLOR;

	private Color Normal_COLOR;

	private UIModelDrawShop.DrawShopContentDataBase m_ContentData;

	private UIModelDrawShop m_ModelDrawShop;

	private UIModelInventory m_ModelInventory;

	private UIModelMall m_ModelMall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public uint GetDrawShopId()
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	private void InitMaterialDict()
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private DrawShopWheelExchangeDesc FindExchangeShowData(uint id)
	{
		return null;
	}

	private void OnMaterial1BtnClick(object[] data)
	{
	}

	private void OnMaterial2BtnClick(object[] data)
	{
	}

	private void ShowMaterialDesc(Vector3 pos, int index)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void RefreshItemView(uint id)
	{
	}

	private void OnRefreshExchangeItem(object[] data)
	{
	}

	private DrawShopWheelExchangeDesc FindExchangeShowDataByItemId(uint itemId)
	{
		return null;
	}

	private void RefreshTopBtn()
	{
	}

	private void OnMainCurrencyClick()
	{
	}

	private void RefreshMaterialView(DrawShopWheelExchangeDesc desc)
	{
	}

	private void RefreshNotEnoughMaterialWithDiamondState(uint each_token_diamonds)
	{
	}

	private string GetNotEnoughMaterialWithCurrencyLocKey()
	{
		return null;
	}

	private void SetMainCurrencyIcon(UISprite sprite)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void InitNavigationData(UINavigationData navigationData)
	{
	}

	private void RefreshCDNBG()
	{
	}

	protected override void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void HighlightCurrent()
	{
	}

	protected override bool NeedWaitDataReady()
	{
		return false;
	}

	private void RefreshView()
	{
	}

	private void InitSymbol()
	{
	}

	private void RefreshViewData(List<DrawShopWheelExchangeDesc> dataList, bool needSort = true)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void NavigationToItem(uint itemId)
	{
	}

	private int SortItem(DrawShopWheelExchangeDesc x, DrawShopWheelExchangeDesc y)
	{
		return 0;
	}

	private bool CheckItemCanPurchase(uint limited_purchase_times, uint purchase_times)
	{
		return false;
	}

	private uint GetExchangePurchasedTimes(uint exchangeId)
	{
		return 0u;
	}

	private bool CheckCanExchange(DrawShopWheelExchangeDesc desc)
	{
		return false;
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	private bool _003CHighlightCurrent_003Eb__50_0(DrawShopWheelExchangeDesc item)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSendShowTimeEvent(ref string P0, ref EventLogger.EventPageDetentionTime P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return false;
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}
}
