using GCommon;

namespace COW;

public class UIInsufficientDiamondsPopupWndController : UIPopupWindowController
{
	private UIInsufficientDiamondsPopupWndView m_View;

	private UINavigationUtil.UINavigationFrom m_From;

	private EInsufficientDiamondsGotoType m_Type;

	private int m_NeedGems;

	private UIModelPayment m_ModelPayment;

	private bool m_IsCloseByGoto;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UINavigationUtil.UINavigationFrom from, EInsufficientDiamondsGotoType type, int needGems)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshInfo()
	{
	}

	private void RefreshGrowthFundV2RebateLabel()
	{
	}

	private void RefreshNewBieBundleRebateLabel()
	{
	}

	private void RefreshCDN()
	{
	}

	private void OnIAPBundleBtnClick()
	{
	}

	private void OnBundleBtnClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
