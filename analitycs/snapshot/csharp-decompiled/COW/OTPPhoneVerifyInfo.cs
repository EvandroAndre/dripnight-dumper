namespace COW;

public class OTPPhoneVerifyInfo
{
	public string CountryCode;

	public string AreaCode;

	public OTPPhoneVerifyAccess Access;

	public string PhoneNumber;

	public string VerifyCode;

	public int TodaySendTimes;

	public int TodayVerifyTimes;

	public ulong NextCanSendOTPTimeStamp;
}
