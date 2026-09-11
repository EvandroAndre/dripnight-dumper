using GarenaMSDK;

namespace COW;

public class OTPBindInfo
{
	public AccountSecurityState State;

	public AccountPlatform Platform;

	public OTPVerifyAccess OTPVerifyAccess;

	public string Email;

	public string Phone;

	public OTPVerifyAccess OriOTPVerifyAccess;

	public string OriEmail;

	public string OriPhone;

	public ulong CoolingTimeStamp;

	public ulong LockingTimeStamp;
}
