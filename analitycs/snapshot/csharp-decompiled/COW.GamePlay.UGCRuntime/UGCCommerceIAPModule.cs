using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCCommerceIAPModule : IUGCModule
{
	private UGCRuntime m_UGCRuntime;

	private UIModelUGCCommerceIAP m_CommerceIAPModel;

	private bool m_PurchaseRegionSwitch;

	public UGCCommerceIAPModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	public void OpenPremiumStore()
	{
	}

	public void OpenPremiumPurchase(string itemCode, int count)
	{
	}

	public bool IsPurchaseRegionOpen()
	{
		return false;
	}
}
