using System.Collections.Generic;
using message;
using proto;
using tcp;

namespace COW;

internal interface IUGCPremiumService
{
	bool IsOpen { get; set; }

	bool IsViper { get; }

	bool FreeUGCRoomCard { get; }

	MLCGGNGNBFB MyVipChangeState { get; }

	List<StoreDesc> CardStoreDescList { get; }

	WorkshopVIPControlDesc VipControlDesc { get; }

	bool InGameHudPremiumCenterState { get; set; }

	proto.WorkshopVipInfo GetMyVipInfo();

	proto.WorkshopVipInfo GetLastMyVipInfo();

	void RequestUnsubscribeWorkshopMember();

	void RequestPurchase(StoreDesc storeDesc, bool enableSubscribe, proto.EWorkshop.VIPType subscribeType, bool systemAuto = false);

	bool TryRequestRenewWorkshopMember();

	void OnBuyPremiumNotify(tcp.WorkshopVipInfo info);

	int GetUserGems();

	uint GetStorePrice(StoreDesc storeDesc);

	CSSharedItemData GetItemData(uint itemId);

	string GetCDN(string key);

	CSSharedItemDataManager.ItemSubType ConvertToItemSubType(proto.EWorkshop.VIPType vipType);

	proto.EWorkshop.VIPType ConvertToVIPType(CSSharedItemDataManager.ItemSubType itemSubType);

	bool IsOpenSubscribe(CSSharedItemDataManager.ItemSubType cardType);

	void Clearup();
}
