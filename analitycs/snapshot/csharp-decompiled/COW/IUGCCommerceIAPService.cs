using System.Collections.Generic;
using proto;

namespace COW;

internal interface IUGCCommerceIAPService
{
	List<WorkshopProductInfo> StoreItemList { get; set; }

	List<WorkshopProductInfo> RequestStoreData();

	void RequestPurchase(WorkshopProductInfo data, uint count, uint price);

	void RequestExchange(uint gems, uint itemTokens, WorkshopProductInfo data, uint count, uint price);

	int GetUserGems();

	int GetUserToken();

	int GetItemTokenCount();

	void SetTokenCount(int tokenCount);

	void Clearup();
}
