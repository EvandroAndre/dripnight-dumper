using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelRebateCard : UIBaseModel
{
	public enum ExtraRewardStatus
	{
		None,
		Unclaimable,
		Claimable,
		Claimed
	}

	private class RebateCardsDelegate : PayUtility.PaymentDelegate
	{
		private static RebateCardsDelegate _I;

		private string LastSubscribedProductIdentifier;

		public static RebateCardsDelegate I => null;

		public override string Name => null;

		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		public override void OnRebateOptionsUpdated(string task, bool result, long[] rebateIds)
		{
		}

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public override bool OnRebateOptionRedeemed(string reason, bool result, PayUtility.RebateOptionRedeemResult update)
		{
			return false;
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public void _003C_003EiFixBaseProxy_OnRebateOptionsUpdated(string P0, bool P1, long[] P2)
		{
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_OnRebateOptionRedeemed(string P0, bool P1, PayUtility.RebateOptionRedeemResult P2)
		{
			return false;
		}
	}

	private readonly List<RebateCardData> m_RebateCardDatas;

	private readonly Dictionary<int, int> m_RebateCardActivityType;

	private Dictionary<int, bool?> m_SubscriptionBonusAvailable;

	private ERebateModelState m_CurrentModelState;

	private RebateCardInfo m_MonthCardData;

	private RebateCardInfo m_WeekCardData;

	private ulong m_NextResetTimeSpan;

	public const uint PropID_RebateCardDataUpdate = 2u;

	public const uint PropID_PurchaseSuccess = 4u;

	public const uint PropID_RedeemSuccess = 8u;

	public const uint PropID_RebateCardPriceUpdate = 16u;

	public const uint PropID_ShouldNotifyChange = 32u;

	public const uint PropID_RebateCardSubscriptionUpdate = 128u;

	public const uint PropID_RebateCardSubscriptionBonusUpdate = 256u;

	public const uint PropID_RebateCardSubscriptionDone = 512u;

	private const long REDEEM_RESET_TIME_OF_DAY_UTC_MS = 68400000L;

	public bool RebateCardEnabled => false;

	public bool RebateCardSubscriptionEnabled => false;

	public ERebateModelState CurrentModelState => ERebateModelState.eNone;

	public RebateCardInfo MonthCardData => null;

	public RebateCardInfo WeekCardData => null;

	public bool ShouldNotify
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static SubscriptionPeriod Convert(RebateCardType rct)
	{
		return SubscriptionPeriod.None;
	}

	public RebateCardInfo RebateCard(RebateCardType rebateCardType)
	{
		return null;
	}

	public bool SupportSubscription(RebateCardType rebateCardType)
	{
		return false;
	}

	public bool SubscriptionBonusAvailable(RebateCardType rebateCardType)
	{
		return false;
	}

	public void RequestSubscriptionBonusAvailable()
	{
	}

	private void OnGetSubscriptionBonusStatus(HttpErrorCode httpErrorCode, object obj)
	{
	}

	public string SubscriptionProductIdentifier(RebateCardType rebateCardType)
	{
		return null;
	}

	public PayItemData SubscriptionProduct(RebateCardType rebateCardType)
	{
		return null;
	}

	public void SetExtraRewardActivitiesRead()
	{
	}

	public ActivityGroupDesc GetExtraRewardActivityGroupDesc(RebateCardType type)
	{
		return null;
	}

	public ExtraRewardStatus GetExtraRewardStatus(ActivityGroupDesc desc)
	{
		return ExtraRewardStatus.None;
	}

	public BaseItemInfo GetExtraReward(ActivityGroupDesc desc)
	{
		return null;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public override void Init()
	{
	}

	public void InitAfterLogin()
	{
	}

	public override void LoginOffline()
	{
	}

	private void CleanupRebateCardData()
	{
	}

	private void LoadRebateCardDataWithRegion()
	{
	}

	public void ProcessRebateCardDesc(List<RebateCardDesc> descList)
	{
	}

	public List<RebateCardData> GetRebateCardDataList()
	{
		return null;
	}

	private void UpdateRebateCardPriceStatus()
	{
	}

	private void _UpdateRebateCardLocalizedPriceStatus(RebateCardInfo rebateCardInfo)
	{
	}

	private void UpdateRebateCardSubscriptionStatus()
	{
	}

	private void _UpdateRebateCardSubscriptionPriceStatus(RebateCardType rebateCardType)
	{
	}

	private RebateCardInfo.ELocalizedPriceStatus GetLocalizedPriceStatus(string productIdentifier)
	{
		return RebateCardInfo.ELocalizedPriceStatus.Unloaded;
	}

	public void UpdateRebateCardTips()
	{
	}

	private void UpdateExtraRewardTips()
	{
	}

	public void UpdateRebateCardActivity()
	{
	}

	private void TryClaimExtraReward(RebateCardType rebateCardType)
	{
	}

	public void ChangeModelState(ERebateModelState nextState, object[] data)
	{
	}

	private void UpdateRebateCardLocalNotification()
	{
	}

	public void ReloadRebateCardsData()
	{
	}

	private void OnRebateCardProductsUpdated()
	{
	}

	private void OnRebateCardSubscriptionProductsUpdated()
	{
	}

	public void PurchaseRebateCard(RebateCardData rebateCardData, bool subscribe)
	{
	}

	private void OnPurchased(string productIdentifier, int rebateId)
	{
	}

	public void ShowSubscriptionTips(RebateCardType rebateCardType, Vector3 position)
	{
	}

	private void OnSubscribed(string productIdentifier)
	{
	}

	public void RequestGetRedeem(int rebateId)
	{
	}

	public void OnRebateOptionRedeemed(PayUtility.RebateOptionRedeemResult result)
	{
	}

	private void _003COnSubscribed_003Eb__68_0(string product_identifier)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_LoginOffline()
	{
	}
}
