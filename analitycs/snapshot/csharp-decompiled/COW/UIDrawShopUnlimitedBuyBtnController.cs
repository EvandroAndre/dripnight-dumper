using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopUnlimitedBuyBtnController : UIDrawShopBuyBtnBaseController
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UIDrawShopUnlimitedBuyBtnController _003C_003E4__this;

		public bool isRepurchase;

		internal void _003CExecuteDrawRequest_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UIDrawShopUnlimitedBuyBtnController _003C_003E4__this;

		public bool isRepurchase;

		internal void _003CShowPurchaseConfirmWindow_003Eb__0(bool success)
		{
		}
	}

	private GameObject m_LeftButtonVFX;

	private ResourceID m_LeftButtonVFXResId;

	private GameObject m_RightButtonVFX;

	private ResourceID m_RightButtonVFXResId;

	private uint m_SelectedPoolAwardIndex;

	private static readonly Color UNSELECTED_GRAY_COLOR;

	private static readonly Color SELECTED_NORMAL_COLOR;

	private GameObject m_LeftDiscountVFX;

	private ResourceID m_LeftDiscountVFXResId;

	private GameObject m_RightDiscountVFX;

	private ResourceID m_RightDiscountVFXResId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitViewSetting()
	{
	}

	public override void OnSingleBuy(bool isRepurchase)
	{
	}

	public override void OnMultiBuy(bool isRepurchase)
	{
	}

	private void ShowPurchaseConfirmWindow(UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopBuyBtnState state, bool isRepurchase)
	{
	}

	private void ExecuteSinglePurchase(bool isRepurchase)
	{
	}

	private void ExecuteMultiPurchase(bool isRepurchase)
	{
	}

	protected override UIModelDrawShop.EDrawShopBuyBtnState CalcBuyBtnState(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return UIModelDrawShop.EDrawShopBuyBtnState.Normal;
	}

	protected override void OnRefreshBuyBtn()
	{
	}

	public UIModelDrawShop.UnlimitedDiscountResult GetDiscountResult(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return default(UIModelDrawShop.UnlimitedDiscountResult);
	}

	public UIModelDrawShop.EDrawShopDiscountType GetActiveDiscountType(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return UIModelDrawShop.EDrawShopDiscountType.None;
	}

	public uint GetCurrentDiscountPrice(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return 0u;
	}

	public UIModelDrawShop.UnlimitedMixedPurchaseResult GetMixedPurchaseResult(int exchangeIndex)
	{
		return default(UIModelDrawShop.UnlimitedMixedPurchaseResult);
	}

	protected override bool CalcMixedPurchaseInfo(UIModelDrawShop.EDrawShopDrawType drawType, int exchangeIndex, out uint couponDrawCount, out uint couponCost, out uint currencyCost)
	{
		couponDrawCount = default(uint);
		couponCost = default(uint);
		currencyCost = default(uint);
		return false;
	}

	protected override void PurchaseSingle(bool isRepurchase)
	{
	}

	protected override void PurchaseMulti(bool isRepurchase)
	{
	}

	private void ExecuteDrawRequest(UIModelDrawShop.EDrawShopDrawType drawType, uint selectedItemIndex, bool isRepurchase)
	{
	}

	protected override bool CheckCurrencyEnough(UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return false;
	}

	protected override uint GetRequiredCurrency(UIModelDrawShop.EDrawShopDrawType drawType, UIModelDrawShop.EDrawShopBuyBtnState state)
	{
		return 0u;
	}

	protected override bool CheckCouponEnough(UIModelDrawShop.EDrawShopDrawType drawType)
	{
		return false;
	}

	public void SetSelectedPoolAwardIndex(uint index)
	{
	}

	public void ClearSelectedPoolAwardIndex()
	{
	}

	public bool IsItemSelected()
	{
		return false;
	}

	protected uint GetSelectedPoolAwardIndex()
	{
		return 0u;
	}

	private void UpdateSingleBuyBtnSelectionState()
	{
	}

	protected override void ApplySingleBtnSkin()
	{
	}

	protected override void ApplyMultiBtnSkin()
	{
	}

	protected override void ApplySingleBtnSkinByState(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected override void ApplyMultiBtnSkinByState(UIModelDrawShop.EDrawShopBuyBtnState state)
	{
	}

	protected override void ResetSingleBtnSkin()
	{
	}

	protected override void ResetMultiBtnSkin()
	{
	}

	private void ApplyLeftButtonCDN(string cdnUrl)
	{
	}

	private void ApplyRightButtonCDN(string cdnUrl)
	{
	}

	private void ApplyLeftDiscountCDN(string cdnUrl)
	{
	}

	private void ApplyRightDiscountCDN(string cdnUrl)
	{
	}

	private void ApplyLeftButtonVFX(string vfxName)
	{
	}

	private void DestroyLeftButtonVFX()
	{
	}

	private void ApplyRightButtonVFX(string vfxName)
	{
	}

	private void DestroyRightButtonVFX()
	{
	}

	private void ApplyLeftDiscountVFX(string vfxName)
	{
	}

	private void DestroyLeftDiscountVFX()
	{
	}

	private void ApplyRightDiscountVFX(string vfxName)
	{
	}

	private void DestroyRightDiscountVFX()
	{
	}

	private void ApplyDiscountPos(GameObject discountTag, string posStr)
	{
	}

	private static bool TryParseVector3(string str, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnSingleBuy(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnMultiBuy(bool P0)
	{
	}

	public UIModelDrawShop.EDrawShopBuyBtnState _003C_003EiFixBaseProxy_CalcBuyBtnState(UIModelDrawShop.EDrawShopDrawType P0)
	{
		return UIModelDrawShop.EDrawShopBuyBtnState.Normal;
	}

	public void _003C_003EiFixBaseProxy_OnRefreshBuyBtn()
	{
	}

	public bool _003C_003EiFixBaseProxy_CalcMixedPurchaseInfo(UIModelDrawShop.EDrawShopDrawType P0, int P1, out uint P2, out uint P3, out uint P4)
	{
		P2 = default(uint);
		P3 = default(uint);
		P4 = default(uint);
		return false;
	}

	public void _003C_003EiFixBaseProxy_PurchaseSingle(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PurchaseMulti(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckCurrencyEnough(UIModelDrawShop.EDrawShopDrawType P0, UIModelDrawShop.EDrawShopBuyBtnState P1)
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetRequiredCurrency(UIModelDrawShop.EDrawShopDrawType P0, UIModelDrawShop.EDrawShopBuyBtnState P1)
	{
		return 0u;
	}

	public bool _003C_003EiFixBaseProxy_CheckCouponEnough(UIModelDrawShop.EDrawShopDrawType P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ApplySingleBtnSkin()
	{
	}

	public void _003C_003EiFixBaseProxy_ApplyMultiBtnSkin()
	{
	}

	public void _003C_003EiFixBaseProxy_ApplySingleBtnSkinByState(UIModelDrawShop.EDrawShopBuyBtnState P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ApplyMultiBtnSkinByState(UIModelDrawShop.EDrawShopBuyBtnState P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetSingleBtnSkin()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetMultiBtnSkin()
	{
	}
}
