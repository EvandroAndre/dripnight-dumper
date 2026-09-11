using GCommon;
using proto;

namespace COW;

public class UITopUpEventIAPController : UIPaymentController.PaymentTabContentController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public ActivityGroupDesc group;

		internal bool _003CSetSubBg_003Eb__0(AdvertDesc e)
		{
			return false;
		}
	}

	private UITopUpEventController m_UITopUpEventController;

	private UIActivityADFullContentController m_ADTopUpEventController;

	private UIModelActivity m_Model;

	private bool isADFull;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIOpen()
	{
	}

	public override void RefreshContent()
	{
	}

	public override void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
	{
	}

	private void CloseOldPanel()
	{
	}

	private void SetSubBg(ActivityGroupDesc group)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void OnPopUpWindowListChange(bool isCovered)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	public void _003C_003EiFixBaseProxy_GotoByParams(UIPaymentController.PaymentGotoParams P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopUpWindowListChange(bool P0)
	{
	}
}
