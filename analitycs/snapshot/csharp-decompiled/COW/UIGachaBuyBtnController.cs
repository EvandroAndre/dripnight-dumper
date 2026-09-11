using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public abstract class UIGachaBuyBtnController : UIBaseController
{
	public enum BuyBtnState
	{
		STATE_NONE,
		STATE_BUY_VIA_LIMITFREE,
		STATE_BUY_VIA_COUPON,
		STATE_BUY_VIA_CURRENCY,
		STATE_BUY_VIA_MIXED,
		STATE_BUY_VIA_CURRENCY_FREE
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__55_0;

		internal void _003CUpdateFreeCDLabel_003Eb__55_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public UIGachaBuyBtnController _003C_003E4__this;

		public uint chestID;

		internal void _003CUpdateFreeCDLabel_003Eb__1()
		{
		}
	}

	protected UIGachaBuyBtnBaseView m_View;

	protected UIModelGacha m_ModelGacha;

	protected uint m_CurrentGachaID;

	protected bool m_OnEnterPurchase;

	private Vector3 m_OriginalOneBtnPos;

	private Vector3 m_OriginalTenBtnPos;

	private Vector3 m_OriginalOneDiscountTagPos;

	private Vector3 m_OriginalTenDiscountTagPos;

	private GameObject m_OneBuyBtnVFX;

	private GameObject m_TenBuyBtnVFX;

	protected abstract void InitBuyBtnBaseView();

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void CacheOriginalUIInfo()
	{
	}

	public void OnSingleBuy(bool isRepurchase)
	{
	}

	public void OnMultiBuy(bool isRepurchase)
	{
	}

	protected void OnOneBuyClick()
	{
	}

	protected void OnTenBuyClick()
	{
	}

	protected void OnSwitchClick()
	{
	}

	protected virtual BuyBtnState CalOneBuyBtnState(uint chestID)
	{
		return BuyBtnState.STATE_NONE;
	}

	protected virtual BuyBtnState CalTenBuyBtnState(uint chestID)
	{
		return BuyBtnState.STATE_NONE;
	}

	protected virtual void OnPopMenuBtnClick()
	{
	}

	protected void RefreshPopMenuArrow(bool isOpen)
	{
	}

	private void RefreshOneBuyBtn(BuyBtnState oneState, uint chestID)
	{
	}

	protected void SetOneBuyBtnBg()
	{
	}

	private void SetOneBuyDiscountTagBg()
	{
	}

	protected void SetOneBuyBtnPos()
	{
	}

	private void SetOneDiscountTagPos()
	{
	}

	private void ResetOneDiscountTagAnim()
	{
	}

	private void SetOneDiscountTagAnim()
	{
	}

	private void SetOneBuyBtnVFX()
	{
	}

	private void RefreshTenBuyBtn(BuyBtnState tenState, uint chestID)
	{
	}

	private void SetTenBuyBtnBg()
	{
	}

	private void SetTenBuyDiscountTagBg()
	{
	}

	private void SetTenBuyBtnPos()
	{
	}

	private void SetTenDiscountTagPos()
	{
	}

	private void ResetTenDiscountTagAnim()
	{
	}

	private void SetTenDiscountTagAnim()
	{
	}

	private void SetTenBuyBtnVFX()
	{
	}

	private void RefreshSwitchBtn(uint chestID)
	{
	}

	private void SetSwitchBtnBg()
	{
	}

	private void ResetBuyBtnStats(UIModelGacha.GachaDrawType type)
	{
	}

	private void DestroyOneBtnVFX()
	{
	}

	private void DestroyTenBtnVFX()
	{
	}

	private void ShowBuyViaLimitFreeUI()
	{
	}

	private void ShowBuyViaMixedUI(GachaDesc desc)
	{
	}

	private void ShowBuyViaCouponUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	private void ShowBuyViaCurrencyUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
	{
	}

	protected virtual void ShowNormalPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	protected virtual Color GetLimitLabelColor(uint chestID)
	{
		return default(Color);
	}

	protected virtual void ShowLimitPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
	{
	}

	protected virtual void ShowDiscountPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	protected virtual void ShowNormalMixedUI(GachaDesc desc)
	{
	}

	protected virtual void ShowDiscountMixedUI(GachaDesc desc)
	{
	}

	private void UpdateFreeCDLabel(BuyBtnState oneState, uint chestID)
	{
	}

	protected virtual void SetOneLimitPercentLabel(uint chestID)
	{
	}

	public void SetBuyBtnExitPurchaseState()
	{
	}

	public bool GetBuyBtnPurchaseState()
	{
		return false;
	}

	public void RefreshBtnState(uint chestID)
	{
	}

	protected virtual void OnRefreshBuyBtn()
	{
	}

	public virtual void PurchaseSingle(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	public virtual void PurchaseMulti(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	protected BuyBtnState GetBuyBtnStateByType(UIModelGacha.GachaDrawType type, uint chestID)
	{
		return BuyBtnState.STATE_NONE;
	}

	private void _003CSetOneBuyBtnBg_003Eb__25_0()
	{
	}

	private void _003CSetOneBuyDiscountTagBg_003Eb__26_0()
	{
	}

	private void _003CSetTenBuyBtnBg_003Eb__33_0()
	{
	}

	private void _003CSetTenBuyDiscountTagBg_003Eb__34_0()
	{
	}

	private void _003CSetSwitchBtnBg_003Eb__41_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
