using System.Collections.Generic;
using proto;
using tcp;

namespace COW;

internal class UGCPremiumServiceDebug : UGCPremiumServiceBase
{
	private bool m_IsOpen;

	private const long ONE_DAY_SECONDS = 86400L;

	private int m_GemsCount;

	private List<StoreDesc> m_StoreDescList;

	public override bool IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override bool IsViper => false;

	public override bool FreeUGCRoomCard => false;

	public override List<StoreDesc> CardStoreDescList => null;

	public void InitDebugData(bool isViper, int gemsCount)
	{
	}

	public override proto.WorkshopVipInfo GetMyVipInfo()
	{
		return null;
	}

	public override proto.WorkshopVipInfo GetLastMyVipInfo()
	{
		return null;
	}

	public override void RequestUnsubscribeWorkshopMember()
	{
	}

	public override void RequestPurchase(StoreDesc storeDesc, bool enableSubscribe, proto.EWorkshop.VIPType subscribeType, bool systemAuto = false)
	{
	}

	public override bool TryRequestRenewWorkshopMember()
	{
		return false;
	}

	public override void OnBuyPremiumNotify(tcp.WorkshopVipInfo info)
	{
	}

	public override int GetUserGems()
	{
		return 0;
	}

	public override uint GetStorePrice(StoreDesc storeDesc)
	{
		return 0u;
	}
}
