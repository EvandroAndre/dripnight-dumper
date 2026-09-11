using GCommon;
using proto;

namespace COW;

public class UIEvoPassPurchaseController : UIMallPurchaseBaseController
{
	private UIModelEvoPass m_ModelEvoPass;

	private ClientEvoPassData m_EvoPassData;

	private string m_IAPPurchasePriceString;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(EVipCard.MembershipRebateType evoPassType)
	{
	}

	private void OnGemsPurchaseBtnClick()
	{
	}

	private void OnIAPPurchaseBtnClick()
	{
	}

	private void SetPriceData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
