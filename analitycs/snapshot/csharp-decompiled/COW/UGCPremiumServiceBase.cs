using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

internal abstract class UGCPremiumServiceBase : IUGCPremiumService
{
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public string key;

		internal bool _003CGetCDN_003Eb__0(WorkshopVIPCDN x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public UGCPremiumServiceBase _003C_003E4__this;

		public Action callback;

		internal void _003CRequestWorkshopMemberDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	protected const string Key_First_Viper_Format = "ugc_premium_first_viper_{0}";

	protected CSSharedItemDataManager.ItemSubType[] m_VipCardTypes;

	protected Dictionary<int, int> m_VIPTypeToItemType;

	private bool m_HasRequestVipControlDesc;

	protected List<StoreDesc> m_CardStoreDescList;

	protected List<CSSharedItemData> m_CardItemDataList;

	protected List<WorkshopVIPCDN> m_CDNList;

	protected proto.WorkshopVipInfo m_MyVipInfo;

	protected proto.WorkshopVipInfo m_LastMyVipInfo;

	protected WorkshopVIPControlDesc m_VipControlDesc;

	protected MLCGGNGNBFB m_MyVipChangeState;

	protected bool m_IsViper;

	protected bool m_InGameHudPremiumCenterState;

	public abstract bool IsOpen { get; set; }

	public abstract bool IsViper { get; }

	public abstract bool FreeUGCRoomCard { get; }

	public abstract List<StoreDesc> CardStoreDescList { get; }

	public MLCGGNGNBFB MyVipChangeState
	{
		get
		{
			return MLCGGNGNBFB.Expire;
		}
		protected set
		{
		}
	}

	public WorkshopVIPControlDesc VipControlDesc => null;

	public bool InGameHudPremiumCenterState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public abstract proto.WorkshopVipInfo GetMyVipInfo();

	public abstract proto.WorkshopVipInfo GetLastMyVipInfo();

	public abstract void RequestUnsubscribeWorkshopMember();

	public abstract void RequestPurchase(StoreDesc storeDesc, bool enableSubscribe, proto.EWorkshop.VIPType subscribeType, bool systemAuto = false);

	public abstract bool TryRequestRenewWorkshopMember();

	public abstract void OnBuyPremiumNotify(tcp.WorkshopVipInfo info);

	public abstract int GetUserGems();

	public abstract uint GetStorePrice(StoreDesc storeDesc);

	protected virtual void UpdateCardStoreDescList()
	{
	}

	public virtual void Clearup()
	{
	}

	public CSSharedItemData GetItemData(uint itemId)
	{
		return null;
	}

	public string GetCDN(string key)
	{
		return null;
	}

	public CSSharedItemDataManager.ItemSubType ConvertToItemSubType(proto.EWorkshop.VIPType vipType)
	{
		return CSSharedItemDataManager.ItemSubType.ItemSubType_NONE;
	}

	public proto.EWorkshop.VIPType ConvertToVIPType(CSSharedItemDataManager.ItemSubType itemSubType)
	{
		return proto.EWorkshop.VIPType.VIPType_NONE;
	}

	public bool IsOpenSubscribe(CSSharedItemDataManager.ItemSubType cardType)
	{
		return false;
	}

	protected bool CheckMyVipExpireTime()
	{
		return false;
	}

	protected bool CheckVipExpireTime(long startTime, long endTime)
	{
		return false;
	}

	protected void RequestWorkshopMemberDesc(Action callback = null)
	{
	}

	protected void NotifyDataChanged(uint propID, object[] param)
	{
	}
}
