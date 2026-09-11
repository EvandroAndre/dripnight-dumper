using System.Collections.Generic;
using proto;

namespace COW;

internal class UGCCommerceIAPServiceRelease : UGCCommerceIAPServiceBase
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UGCCommerceIAPServiceRelease _003C_003E4__this;

		public WorkshopProductInfo data;

		public uint count;

		public uint price;

		internal void _003CRequestExchange_003Eb__0()
		{
		}
	}

	private UIModelUser m_ModelUser;

	private UIModelInventory m_ModelInventory;

	private UIModelUGCCommerceIAP m_ModelCommerceIAP;

	private ulong m_RefreshStoreDataTime;

	private int m_RefreshStoreDataSeconds;

	public UGCCommerceIAPServiceRelease(UIModelUGCCommerceIAP model)
	{
	}

	public override void Clearup()
	{
	}

	public override List<WorkshopProductInfo> RequestStoreData()
	{
		return null;
	}

	public override void RequestPurchase(WorkshopProductInfo data, uint count, uint price)
	{
	}

	public override void RequestExchange(uint gems, uint itemTokens, WorkshopProductInfo data, uint count, uint price)
	{
	}

	public override int GetUserGems()
	{
		return 0;
	}

	public override int GetUserToken()
	{
		return 0;
	}

	public override int GetItemTokenCount()
	{
		return 0;
	}

	public override void SetTokenCount(int tokenCount)
	{
	}

	public void _003C_003EiFixBaseProxy_Clearup()
	{
	}
}
