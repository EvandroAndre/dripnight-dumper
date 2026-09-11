using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelEvoPass : UIBaseModel
{
	private class EvoPassDelegate : PayUtility.PaymentDelegate
	{
		private static EvoPassDelegate _I;

		private string LastSubscribedProductIdentifier;

		public static EvoPassDelegate I => null;

		public override string Name => null;

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public override void OnPurchasing(string reason, bool willPurchase, string productIdentifier, long rebateId, bool isEvent, long eventId)
		{
		}

		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		public override void OnRebateOptionsUpdated(string reason, bool result, long[] rebateIds)
		{
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_OnPurchasing(string P0, bool P1, string P2, long P3, bool P4, long P5)
		{
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public void _003C_003EiFixBaseProxy_OnRebateOptionsUpdated(string P0, bool P1, long[] P2)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__63_0;

		internal void _003CRequestPurchaseEvoPass_003Eb__63_0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public UIModelEvoPass _003C_003E4__this;

		public HttpManager.EHttpChannel channel;

		public string cmd;

		internal void _003CRequestEvoPassDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public UIModelEvoPass _003C_003E4__this;

		public bool isBackEndNotify;

		public bool isExpired;

		public bool getSlotsInfo;

		public string cmd;

		internal void _003CRequestEvoPassInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_EvoPassPurchaseSuccess = 2u;

	public const uint PropID_EvoPassSubscriptionBonusUpdate = 4u;

	public const uint PropID_EvoPassSubscriptionDone = 8u;

	public const uint PropID_EvoPassModelStateChange = 16u;

	public const uint PropID_EvoPassOnProductUpdate = 32u;

	public const uint PropID_EvoPassGetDesc = 64u;

	public const uint PropID_EvoPassGetInfo = 128u;

	public const uint PropID_EvoPassGetInfoLate = 256u;

	public ulong EvoPassExpireTime;

	public List<uint> PrivilegePetList;

	public List<uint> PrivilegeAvatarList;

	public List<uint> PrivilegeWeaponSkinList;

	public bool HasFirstSubscribeBonus;

	public bool HasRequestEvoInfo;

	public int EnumPrivilegeIDCount;

	public const uint EVO_ACESS_ITEM_ID = 863000001u;

	public Dictionary<uint, MembershipDesc> EvoPassDescDic;

	public Dictionary<uint, ClientEvoPassData> EvoPassType2DataDic;

	private Dictionary<uint, string> PrivilegeID2TitleKey;

	private Dictionary<uint, int> PrivilegeID2DataIndex;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private Empty m_EmptyReq;

	private CSGetMembershipDescRes m_EvoPassDesc;

	public MembershipBigAwardDesc CurBigAward;

	public MembershipBigAwardDesc NextBigAward;

	public List<MembershipAwardDesc> PrivilegeList;

	private EMemberShipModelState _003CCurrentModelState_003Ek__BackingField;

	private EMemberShipBackEndNotifyState _003CCurrentPurchaseState_003Ek__BackingField;

	private bool m_ShouldDelayEvoPassReward;

	private bool m_HasPendingEvoPassReward;

	private List<MembershipBigAwardDesc> BigReward;

	private string EvoPassBigAwardPlayerPrefKey;

	private string EvoPassExpirePlayerPrefKey;

	private string EvoPassNewPlayerPrefKey;

	public bool RenewEvoPass;

	public CSGetMembershipDescRes EvoPassDesc => null;

	public EMemberShipModelState CurrentModelState
	{
		get
		{
			return _003CCurrentModelState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentModelState_003Ek__BackingField = value;
		}
	}

	public EMemberShipBackEndNotifyState CurrentPurchaseState
	{
		get
		{
			return _003CCurrentPurchaseState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentPurchaseState_003Ek__BackingField = value;
		}
	}

	public bool EvoGunVip => false;

	public bool ShouldDelayEvoPassReward
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasPendingEvoPassReward
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private int SubscriptionEvoPassSwitch => 0;

	public bool GetEvoPassIsOpen()
	{
		return false;
	}

	public bool IsMembershipSwitchOn()
	{
		return false;
	}

	public bool IsMembershipPurchaseSwitchOn()
	{
		return false;
	}

	public bool ShouldShowEvoPassEntry()
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ClearEvoPassCache()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void InitAfterLogin()
	{
	}

	public ClientEvoPassData GetEvoPassDataByType(EVipCard.MembershipRebateType evoPassType)
	{
		return null;
	}

	public string GetPrivilegeKey(uint id)
	{
		return null;
	}

	public void PurchaseEvoPass(EVipCard.MembershipRebateType evoPassType, bool subscribe)
	{
	}

	public bool CanDisplaySubscription(EVipCard.MembershipRebateType evoPassType)
	{
		return false;
	}

	public bool IsEvoPassActive()
	{
		return false;
	}

	public bool ContainsAvatar(uint id)
	{
		return false;
	}

	public bool ContainsPet(uint id)
	{
		return false;
	}

	public void RequestEvoPassDesc(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestEvoPassInfo(uint httpOption = 0u, bool isBackEndNotify = false, bool getSlotsInfo = false, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void RequestPurchaseEvoPass(uint rebateId, uint gemsPrice)
	{
	}

	private void InitEvoWeaponDataToAssist(CSGetMembershipInfoRes info)
	{
	}

	private void ProcessEvoPassDescRes(CSGetMembershipDescRes res)
	{
	}

	public void RefreshBigReward()
	{
	}

	private void SyncLocalMembershipStateToProfile()
	{
	}

	private void ProcessEvoPassInfoRes(CSGetMembershipInfoRes res)
	{
	}

	public void OnBackEndNotifyPurchased()
	{
	}

	private bool SupportSubscription(EVipCard.MembershipRebateType evoPassType)
	{
		return false;
	}

	private void OnGOPNotifyPurchased(string productIdentifier, int rebateId)
	{
	}

	private void OnSubscribed(string productIdentifier)
	{
	}

	private void ChangeBackEndNotifyState(EMemberShipBackEndNotifyState nextState)
	{
	}

	private void ChangeModelState(EMemberShipModelState nextState, object[] data)
	{
	}

	private void OnProductAndRebateOptionsUpdate()
	{
	}

	private void RegisterProductAndRebateIDs()
	{
	}

	public void UpdateEvoPassProducts()
	{
	}

	public bool CheckIsEvoPassItem(uint id)
	{
		return false;
	}

	private void _003COnSubscribed_003Eb__79_0(string product_identifier)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
