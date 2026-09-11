using GCommon;

namespace COW;

public class UIGrowthFundAdController : UIPopupWindowController
{
	public enum EAdType
	{
		NewbieAndGrowthFund = 1,
		GrowthFundNotBought,
		GrowthFundHasBought,
		NewbieOnly
	}

	private UIGrowthFundAdView m_View;

	public const string SHOW_GROWTH_AD = "show_growth_ad";

	private uint m_DelayCall;

	private EAdType m_Type;

	private UIModelPayment m_Payment;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnFinish()
	{
	}

	private void OnBtnClose()
	{
	}

	private void OnGotoNavigation()
	{
	}

	public void SetData(bool needGrowthFund = true)
	{
	}

	public void UpdateUrlAndEndTime(string url, uint endTime)
	{
	}

	private void _003COnFinish_003Eb__10_0()
	{
	}

	private void _003CUpdateUrlAndEndTime_003Eb__14_0(ResultTextureInfo texture)
	{
	}

	private void _003CUpdateUrlAndEndTime_003Eb__14_1(ResultTextureInfo texture)
	{
	}

	private void _003CUpdateUrlAndEndTime_003Eb__14_2(ResultTextureInfo texture)
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
