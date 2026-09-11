namespace COW;

public class BooyahPassDelegate : PayUtility.PaymentDelegate
{
	private static BooyahPassDelegate m_Instance;

	private bool m_IsDuoVersionLocked;

	private bool m_IsSubscriptionLocked;

	private string m_LastPurchasedSubscriptionProduct;

	private string[] m_DemandDuoVersionProducts;

	private string[] m_DemandSubscriptionProducts;

	public static BooyahPassDelegate I => null;

	public override string Name => null;

	public override void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
	{
	}

	public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
	{
		return null;
	}

	public override void OnPurchasing(string reason, bool willPurchase, string productIdentifier, long rebateId, bool isEvent, long eventId)
	{
	}

	public bool IsAllProductsAvailable()
	{
		return false;
	}

	public bool IsPurchaseSubscriptionLocked()
	{
		return false;
	}

	public void UpdateProductsInDemand(string[] duoVersions, string[] subscriptions, string[] demand, string reason)
	{
	}

	public void ResetProductsInDemand()
	{
	}

	public void SetDuoVersionOperationLock(bool lockOperation)
	{
	}

	public void SetSubscriptionOperationLock(bool lockOperation)
	{
	}

	public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
	{
	}

	public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnPurchasing(string P0, bool P1, string P2, long P3, bool P4, long P5)
	{
	}
}
