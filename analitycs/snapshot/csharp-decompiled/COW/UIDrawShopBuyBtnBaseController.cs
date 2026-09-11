using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIDrawShopBuyBtnBaseController : UIBaseController
{
	protected UIDrawShopBuyBtnBaseViewSetting m_ViewSetting;

	protected UIModelDrawShop m_ModelDrawShop;

	protected uint m_CurrentChestId;

	protected bool m_IsInPurchaseFlow;

	protected UIModelDrawShop.DrawShopUniversalData m_CachedUniversalData;

	protected UIModelDrawShop.DrawShopContentDataBase m_CachedContentData;

	private Vector3 m_OriginalSingleBtnPos;

	private Vector3 m_OriginalMultiBtnPos;

	private Vector3 m_OriginalSingleDiscountTagPos;

	private Vector3 m_OriginalMultiDiscountTagPos;

	private GameObject m_SingleBuyBtnVFX;

	private GameObject m_MultiBuyBtnVFX;

	protected abstract void InitViewSetting();

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RegisterButtonEvents()
	{
	}

	private void CacheOriginalUIInfo()
	{
	}

	public void RefreshBtnState(uint chestId)
	{
	}

	protected virtual bool LoadAndCacheData()
	{
		return false;
	}

	protected UIModelDrawShop.DrawShopUniversalData GetCachedUniversalData()
	{
		return null;
	}

	protected UIModelDrawShop.DrawShopContentDataBase GetCachedContentData()
	{
		return null;
	}

	public void SetExitPurchaseState()
	{
	}

	public bool IsInPurchaseFlow()
	{
		return false;
	}

	protected void OnSingleBuyClick()
	{
	}

	protected void OnMultiBuyClick()
	{
	}

	public virtual void OnSingleBuy(bool isRepurchase)
	{
	}

	public virtual void OnMultiBuy(bool isRepurchase)
	{
	}

	protected virtual UIModelDrawShop.EDrawShopBuyBtnState CalcBuyBtnState(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return UIModelDrawShop.EDrawShopBuyBtnState.Normal;
	}

	protected bool IsStateFree(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected bool IsStateCouponOnly(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected bool IsStateMixed(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected bool IsStateDiscount(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected bool IsStateNeedCurrency(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected virtual bool CheckCurrencyEnough(UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected virtual bool CheckCouponEnough(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return false;
	}

	protected virtual bool CalcMixedPurchaseInfo(UIModelDrawShop.EDrawShopDrawType drawType, int exchangeIndex, out uint couponDrawCount, out uint couponCost, out uint currencyCost)
	{
		couponDrawCount = default(uint);
		couponCost = default(uint);
		currencyCost = default(uint);
		return false;
	}

	private void RefreshSingleBuyBtn(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	private void ResetSingleBtnState()
	{
	}

	private void ShowSingleFreeBuyUI()
	{
	}

	private void ShowSingleCouponBuyUI(UIModelDrawShop.DrawShopUniversalData universalData, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected virtual void ShowSingleNormalBuyUI(UIModelDrawShop.DrawShopUniversalData universalData)
	{
	}

	protected virtual void ShowSingleDiscountBuyUI(UIModelDrawShop.DrawShopUniversalData universalData)
	{
	}

	private void ShowSingleLimitInfo(uint totalCount, int usedCount, UIModelDrawShop.EDrawShopDiscountType discountType)
	{
	}

	protected virtual void RefreshMultiBuyBtn(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected virtual void UpdateSingleBuyLabel()
	{
	}

	protected virtual void UpdateMultiBuyLabel()
	{
	}

	public void ResetMultiBtnState()
	{
	}

	private void ShowMultiCouponBuyUI(UIModelDrawShop.DrawShopUniversalData universalData, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected virtual void ShowMultiNormalBuyUI(UIModelDrawShop.DrawShopUniversalData universalData)
	{
	}

	protected virtual void ShowMultiMixedBuyUI(UIModelDrawShop.DrawShopUniversalData universalData)
	{
	}

	protected virtual void ShowMultiDiscountBuyUI(UIModelDrawShop.DrawShopUniversalData universalData)
	{
	}

	private void ShowMultiLimitInfo(uint totalCount, int usedCount, UIModelDrawShop.EDrawShopDiscountType discountType)
	{
	}

	private void UpdateFreeCountdownLabel(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	private bool WillShowSingleLimitContainer(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected virtual void ApplySingleBtnSkin()
	{
	}

	protected virtual void ApplyMultiBtnSkin()
	{
	}

	protected virtual void ApplySingleBtnSkinByState(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected virtual void ApplyMultiBtnSkinByState(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected virtual void ResetSingleBtnSkin()
	{
	}

	protected virtual void ResetMultiBtnSkin()
	{
	}

	private void ResetSingleDiscountTagAnim()
	{
	}

	private void ResetMultiDiscountTagAnim()
	{
	}

	private void ApplySingleDiscountTagAnim(UIModelDrawShop.DrawShopChangeSkinDesc skinDesc)
	{
	}

	private void ApplyMultiDiscountTagAnim(UIModelDrawShop.DrawShopChangeSkinDesc skinDesc)
	{
	}

	private void ApplySingleBtnVFX(UIModelDrawShop.DrawShopChangeSkinDesc skinDesc)
	{
	}

	private void ApplyMultiBtnVFX(UIModelDrawShop.DrawShopChangeSkinDesc skinDesc)
	{
	}

	private void DestroySingleBtnVFX()
	{
	}

	private void DestroyMultiBtnVFX()
	{
	}

	private void DestroyVFX()
	{
	}

	protected virtual void PurchaseSingle(bool isRepurchase)
	{
	}

	protected virtual void PurchaseMulti(bool isRepurchase)
	{
	}

	protected virtual void OnPurchaseSuccess(bool isRepurchase)
	{
	}

	protected virtual void OnPurchaseFailed()
	{
	}

	protected virtual void ShowInsufficientCurrencyHint(UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected virtual uint GetRequiredCurrency(UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return 0u;
	}

	protected virtual void OnCouponInsufficient(UIModelDrawShop.EDrawShopDrawType drawType)
	{
	}

	protected string GetCurrencyIconName(UIModelDrawShop.EDrawShopCoinType coinType)
	{
		return null;
	}

	protected virtual string GetCouponIconName(uint itemId)
	{
		return null;
	}

	protected virtual ResourceID GetCouponIconResourceId(uint itemId)
	{
		return default(ResourceID);
	}

	protected virtual void OnRefreshBuyBtn()
	{
	}

	private void _003CUpdateFreeCountdownLabel_003Eb__52_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
