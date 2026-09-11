using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIGachaIchis55BuyBtnController : UIGachaBuyBtnController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<KeyValuePair<int, uint>> _003C_003E9__20_0;

		internal int _003CBuildPopItems_003Eb__20_0(KeyValuePair<int, uint> a, KeyValuePair<int, uint> b)
		{
			return 0;
		}
	}

	private UIModelIchis m_ModelIchis;

	private UIGachaIchis55BuyBtnView m_IchisBuyBtnView;

	private List<UIGachaIchisNormalBuyBtnPopMenuItemController> m_PopItems;

	private bool m_PopOpen;

	private uint m_IchisChestId;

	private uint m_IchisChestSubId;

	private bool m_IchisChestBound;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBuyBtnBaseView()
	{
	}

	protected override void OnUIInit()
	{
	}

	public void SetChestIds(uint chestId, uint chestSubId)
	{
	}

	protected override BuyBtnState CalOneBuyBtnState(uint chestID)
	{
		return BuyBtnState.STATE_NONE;
	}

	protected override BuyBtnState CalTenBuyBtnState(uint chestID)
	{
		return BuyBtnState.STATE_NONE;
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnRefreshBuyBtn()
	{
	}

	protected override void OnPopMenuBtnClick()
	{
	}

	private void RefreshIchisPopMenuBtn()
	{
	}

	private void OpenPopMenu()
	{
	}

	private void ClosePopMenu()
	{
	}

	private void OnPopListClickMaskClick()
	{
	}

	private void BuildPopItems()
	{
	}

	private void RefreshPopMenuGridBG(int itemCount)
	{
	}

	private void OnPopItemClick(int level)
	{
	}

	protected override void ShowDiscountPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	protected override void ShowNormalMixedUI(GachaDesc desc)
	{
	}

	protected override void ShowDiscountMixedUI(GachaDesc desc)
	{
	}

	private string ResolveCurrencySprite(uint chestIdForLookup)
	{
		return null;
	}

	public override void PurchaseSingle(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	public override void PurchaseMulti(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	private ELottery.ExchangeItemGroupType ExchangeGroupFor(BuyBtnState state, uint chestID, UIModelGacha.GachaDrawType drawType)
	{
		return ELottery.ExchangeItemGroupType.EXCHANGE_ITEM_GROUP_1;
	}

	private bool ShouldShowConfirmWnd(BuyBtnState state)
	{
		return false;
	}

	private void ShowIchisConfirmWnd(uint chestId, uint chestSubId, UIModelGacha.GachaDrawType type, BuyBtnState state, bool isRepurchase)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public BuyBtnState _003C_003EiFixBaseProxy_CalOneBuyBtnState(uint P0)
	{
		return BuyBtnState.STATE_NONE;
	}

	public BuyBtnState _003C_003EiFixBaseProxy_CalTenBuyBtnState(uint P0)
	{
		return BuyBtnState.STATE_NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRefreshBuyBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopMenuBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowDiscountPurchaseUI(GachaDesc P0, UIModelGacha.GachaDrawType P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowNormalMixedUI(GachaDesc P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowDiscountMixedUI(GachaDesc P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PurchaseSingle(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_PurchaseMulti(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}
}
