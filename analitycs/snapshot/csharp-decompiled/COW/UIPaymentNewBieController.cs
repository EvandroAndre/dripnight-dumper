using GCommon;

namespace COW;

public class UIPaymentNewBieController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
{
	private UIPaymentNewBieView m_View;

	private UICountDownController m_CountDownCtrl;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UIModelNewPlayerIAPBundle m_ModelNewPlayerIAPBundle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void RefreshContent()
	{
	}

	private void RefreshCountDown()
	{
	}

	private void RefreshViewData()
	{
	}

	private void OnBtnPurchaseClick()
	{
	}

	private void RefreshCDNBG()
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003CRefreshCountDown_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
