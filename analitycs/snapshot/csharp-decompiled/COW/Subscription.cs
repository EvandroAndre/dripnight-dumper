using GarenaMSDK;

namespace COW;

public class Subscription
{
	private int _LastPaymentTime;

	private int _NextPaymentTime;

	private SubscriptionPeriod _Period;

	private long _GracePeriodExpiryTime;

	private long _OnHoldSince;

	public SubscriptionStatus Status;

	public const string PAYMENT_TIME_FORMAT_TO_MINS = "yyyy-MM-dd H:mm";

	public const string PAYMENT_TIME_FORMAT_TO_DATE = "yyyy-MM-dd";

	public const int TEST_RENEWAL_INTERVAL_SECS = 300;

	public int LastPaymentTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public SubscriptionPeriod Period
	{
		get
		{
			return SubscriptionPeriod.None;
		}
		set
		{
		}
	}

	public int NextPaymentTime => 0;

	public long GracePeriodExpiryTime => 0L;

	public bool IsInGracePeriod => false;

	public long OnHoldSince => 0L;

	public bool IsOnHold => false;

	private void _UpdateNextPaymentTime()
	{
	}

	public static Subscription _(SDKIAP.Subscription subscription)
	{
		return null;
	}

	public bool HasLastPaymentTime()
	{
		return false;
	}

	public bool HasNextPaymentTime()
	{
		return false;
	}

	private bool? PaymentOverdue()
	{
		return null;
	}

	public bool WillBegin()
	{
		return false;
	}

	public bool WithinPeriod()
	{
		return false;
	}

	public bool HasEnded()
	{
		return false;
	}

	public bool CanSubscribe()
	{
		return false;
	}

	public bool CanUnsubscribe()
	{
		return false;
	}

	public bool GotoSubscriptionManagement()
	{
		return false;
	}

	public static string Brief(Subscription subscription)
	{
		return null;
	}

	public static string Detail(Subscription subscription)
	{
		return null;
	}
}
