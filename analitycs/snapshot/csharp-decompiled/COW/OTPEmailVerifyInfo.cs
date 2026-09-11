namespace COW;

public class OTPEmailVerifyInfo
{
	public string Email;

	public string VerifyCode;

	public int TodaySendTimes;

	public int TodayVerifyTimes;

	public ulong NextCanSendOTPTimeStamp;
}
