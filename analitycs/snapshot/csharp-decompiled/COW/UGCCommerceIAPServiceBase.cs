using System.Collections.Generic;
using proto;

namespace COW;

internal abstract class UGCCommerceIAPServiceBase : IUGCCommerceIAPService
{
	private List<WorkshopProductInfo> _003CStoreItemList_003Ek__BackingField;

	public List<WorkshopProductInfo> StoreItemList
	{
		get
		{
			return _003CStoreItemList_003Ek__BackingField;
		}
		set
		{
			_003CStoreItemList_003Ek__BackingField = value;
		}
	}

	public abstract List<WorkshopProductInfo> RequestStoreData();

	public abstract void RequestPurchase(WorkshopProductInfo data, uint count, uint price);

	public abstract void RequestExchange(uint gems, uint itemTokens, WorkshopProductInfo data, uint count, uint price);

	public abstract int GetUserGems();

	public abstract int GetUserToken();

	public abstract int GetItemTokenCount();

	public abstract void SetTokenCount(int tokenCount);

	public virtual void Clearup()
	{
	}
}
