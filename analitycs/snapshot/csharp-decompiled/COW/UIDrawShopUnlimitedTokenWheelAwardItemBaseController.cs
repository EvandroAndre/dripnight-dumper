using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIDrawShopUnlimitedTokenWheelAwardItemBaseController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public int savedLeftAbs;

		public int savedRightAbs;

		public UIDrawShopUnlimitedTokenWheelAwardItemBaseController _003C_003E4__this;

		internal void _003CRefreshTokenState_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_1
	{
		public int savedLeftAbs;

		public int savedRightAbs;

		public UIDrawShopUnlimitedTokenWheelAwardItemBaseController _003C_003E4__this;

		internal void _003CRefreshTokenState_003Eb__1()
		{
		}
	}

	private const string VFX_RED_QUALITY = "UIFX_DRAWSHOPWHEEL_BIGPRIZE_UP_RED";

	private const string VFX_YELLOW_QUALITY = "UIFX_DRAWSHOPWHEEL_BIGPRIZE_UP_YELLOW";

	public UIDrawShopUnlimitedTokenWheelAwardItemViewSetting m_View;

	protected UIModelDrawShop m_ModelDrawShop;

	protected UIModelGacha m_ModelGacha;

	public DrawShopWheelExchangeDesc m_ExchangeItemDesc;

	protected BaseItemInfo m_ItemInfo;

	protected bool m_IsCanClaim;

	protected int m_Index;

	protected uint m_DrawShopId;

	private GameObject m_CanExchangeVFX;

	private ResourceID m_CanExchangeVFXResId;

	protected bool m_IsBigCDN;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void SetViewData(uint drawShopId, DrawShopWheelExchangeDesc exchangeItemDesc)
	{
	}

	public uint GetDrawShopId()
	{
		return 0u;
	}

	protected virtual void RefreshItemShow()
	{
	}

	protected virtual BaseItemInfo CreateBaseItemInfo(DrawShopWheelExchangeDesc exchangeItemDesc)
	{
		return null;
	}

	protected virtual bool IsItemOwned(DrawShopWheelExchangeDesc exchangeItemDesc)
	{
		return false;
	}

	public virtual void UpdateStateDisplay()
	{
	}

	protected virtual void RefreshTokenState()
	{
	}

	protected virtual void RefreshTokenNumberLabelWithDiamondText()
	{
	}

	private void SetMainCurrencyIcon(UISprite sprite)
	{
	}

	protected virtual void RefreshTokenStateVFX()
	{
	}

	private void LoadCanExchangeVFX(string vfxName)
	{
	}

	private void DestroyCanExchangeVFX()
	{
	}

	protected virtual void SetQualityBG(int quality, UISprite qualityBG, bool isRareItem)
	{
	}

	private void OnAwardBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
