using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class RebateCardDisplayInfo
{
	public Color BgColor;

	public string SubscriptionPeriodTextKey;

	public string Subscription_TitleKey;

	public string Subscription_BenefitKey;

	public string ConfirmBeforeSubscribe_TitleKey;

	public string ConfirmBeforeSubscribe_TextKey;

	public string ConfirmBeforeSubscribe_LegalKey;

	public string NotifyAfterSubscribe_SuccessKey;

	public string PurchaseWhileSubscribed_TipsKey;

	public string NotSubscribed_CheckBoxTextKey;

	public string Subscribed_CheckBoxTextKey;

	public string Subscription_LastPaymentTimeKey;

	public string Subscription_NextPaymentTimeKey;

	public string HasReadSubscriptionHintPrefKey;

	public string ExtraItemKey;

	public string InstantDiamondsKey;

	public string DailyAndTotalDiamondsKey;

	public string RebateRateKey;

	public string ResetTimeKey;

	public string VipCardKey;

	public static readonly Dictionary<int, RebateCardDisplayInfo> Infos;
}
