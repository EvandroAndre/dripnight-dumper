using GCommon;

namespace COW;

internal class UIBooyahPassSecondPurchaseConfirmWndController : UIPopupWindowController
{
	public enum ESecondPurchaseType
	{
		Reward,
		NowGetLine,
		FutureGetLine
	}

	private UIBooyahPassSecondPurchaseConfirmWndView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private const uint PURCHASE_PP_REWARD_SHOW_COUNT = 20u;

	private const string PURCHASE_POPUP_TITLE = "PurchasePopup";

	private string m_PremiumType;

	private BooyahPassStatusType m_StatusType;

	private const uint EXPAND_SCROLLVIEW_HEIGHT = 332u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitBPRewardItemTemplate()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RefreshView()
	{
	}

	public void SetViewData(BooyahPassStatusType statusType)
	{
	}

	private void OnPurchaseBtnClick()
	{
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__10_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__10_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitBPRewardItemTemplate_003Eb__10_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
