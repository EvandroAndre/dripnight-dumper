using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

internal class UGCPremiumServiceRelease : UGCPremiumServiceBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CSSharedItemData> _003C_003E9__25_0;

		internal int _003CUpdateCardStoreDescList_003Eb__25_0(CSSharedItemData x, CSSharedItemData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public bool enableSubscribe;

		public proto.EWorkshop.VIPType subscribeType;

		public bool systemAuto;

		internal void _003CRequestPurchase_003Eb__0(CSPurchaseReq req)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UGCPremiumServiceRelease _003C_003E4__this;

		public Action callback;

		internal void _003CRequestGetWorkshopViperInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private UIModelMall m_ModelMall;

	private bool m_IsOpen;

	private bool m_HasAddAssist;

	private bool m_NeedCheckAutoBuy;

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

	public override void Clearup()
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

	private void RequestUGCPremiumInfoInLobby()
	{
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

	private void RequestGetWorkshopViperInfo(bool force = false, Action callback = null)
	{
	}

	protected override void UpdateCardStoreDescList()
	{
	}

	private void AddAssist(proto.WorkshopVipInfo vip_info)
	{
	}

	private void _003CRequestUGCPremiumInfoInLobby_003Eb__17_0()
	{
	}

	private void _003CRequestUGCPremiumInfoInLobby_003Eb__17_1()
	{
	}

	private void _003CRequestUnsubscribeWorkshopMember_003Eb__18_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Clearup()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateCardStoreDescList()
	{
	}
}
