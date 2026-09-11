using GCommon;

namespace COW;

public class UICommonDiamondPurchaseBtnController : UIBaseController
{
	private const string PERCENT_OFF_FORMAT_STRING = "-{0}%";

	private bool m_Ready;

	private bool m_HideDiscountVFX;

	private UICommonDiamondPurchaseBtnView m_View;

	private int m_BpDiscountSpriteWidth;

	private int m_SaleBgWidth;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetButtonStateInternal(bool enable)
	{
	}

	private void SetPurchasePrice(uint originalPrice, uint discountPrice)
	{
	}

	private void SetDiscountVFXActive(bool active)
	{
	}

	public void SetSpecialIconView(string iconName)
	{
	}

	private void RefreshDiscountVFXGroup(uint originalPrice, uint discountPrice, bool assignPercentage, uint percentage)
	{
	}

	private static bool ValidityCheck(uint originalPrice, uint discountPrice, bool assignPercentage, uint percentage)
	{
		return false;
	}

	private void SetDepth(int depth)
	{
	}

	private void SetBackgroundWidth(int width)
	{
	}

	private void BindOnPurchaseBtnClick(EventDelegate.Callback onPurchaseBtnClick)
	{
	}

	public void SetViewData(int depth, int width, uint originalPrice, uint discountPrice = 0u, bool hideDiscountVFX = false, bool assignPercentage = false, uint percentage = 0u, EventDelegate.Callback onPurchaseBtnClick = null)
	{
	}

	public void SetViewData(int depth, int width, bool hideDiscountVFX = false, EventDelegate.Callback onPurchaseBtnClick = null)
	{
	}

	public void SetButtonState(bool enable)
	{
	}

	public void SetDisableMsgKey(string locKey)
	{
	}

	public void UpdatePurchasePrice(uint originalPrice, uint discountPrice = 0u, bool assignPercentage = false, uint percentage = 0u)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
