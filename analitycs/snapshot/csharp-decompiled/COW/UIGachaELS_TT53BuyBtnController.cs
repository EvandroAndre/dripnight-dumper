using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaELS_TT53BuyBtnController : UIGachaBuyBtnController
{
	private UIGachaELS_TT53BuyBtnView m_ELS_TT53BuyBtnView;

	private GameObject m_OnceOneBtnUIFX;

	private GameObject m_OnceTenBtnUIFX;

	private GameObject m_OnceSwitchBtnVFX;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected virtual void InitView()
	{
	}

	protected override void InitBuyBtnBaseView()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void PurchaseSingle(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	public override void PurchaseMulti(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	protected override void SetOneLimitPercentLabel(uint chestID)
	{
	}

	protected override void ShowNormalPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	protected override void ShowNormalMixedUI(GachaDesc desc)
	{
	}

	protected override void ShowDiscountPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	protected override void ShowDiscountMixedUI(GachaDesc desc)
	{
	}

	protected override void ShowLimitPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
	{
	}

	public void ShowOnceUIFX()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_PurchaseSingle(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_PurchaseMulti(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SetOneLimitPercentLabel(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowNormalPurchaseUI(GachaDesc P0, UIModelGacha.GachaDrawType P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowNormalMixedUI(GachaDesc P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowDiscountPurchaseUI(GachaDesc P0, UIModelGacha.GachaDrawType P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowDiscountMixedUI(GachaDesc P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowLimitPurchaseUI(GachaDesc P0, UIModelGacha.GachaDrawType P1, uint P2)
	{
	}
}
