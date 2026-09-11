using GCommon;

namespace COW;

public class UICommonInAppPurchaseBtnController : UIBaseController
{
	private enum EPriceInfoGroup
	{
		Disabled,
		WithDiscount,
		Pending,
		WithoutDiscount
	}

	private const string PERCENT_OFF_FORMAT_STRING = "-{0}%";

	private bool m_Ready;

	private UICommonInAppPurchaseBtnView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetPurchasableBackground(bool isPurchasable)
	{
	}

	private void SetPriceInfoGroup(EPriceInfoGroup group)
	{
	}

	private void RefreshDiscountVFX(bool display)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetPurchasePrice(int originalPriceProductID, int discountPriceProductID, string fallbackOriginalPrice, string fallbackDiscountPrice)
	{
	}

	private void SetRebatePercentage(bool hasDiscount, uint rebatePercentage)
	{
	}

	private bool ValidityCheck(uint rebatePercentage)
	{
		return false;
	}

	private void SetDepth(int depth)
	{
	}

	private void SetBackgroundWidth(int width)
	{
	}

	private void BindOnPurchaseButtonClick(EventDelegate.Callback onPurchaseBtnClick)
	{
	}

	public void SetDisableMsgKey(string locKey)
	{
	}

	public void SetViewData(int depth, int width, EventDelegate.Callback onPurchaseBtnClick = null)
	{
	}

	public void UpdatePurchasePrice(int originalPriceProductID, int discountPriceProductID, uint rebatePercentage, string fallbackOriginalPrice, string fallbackDiscountPrice)
	{
	}

	public void SetButtonDisabled()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
