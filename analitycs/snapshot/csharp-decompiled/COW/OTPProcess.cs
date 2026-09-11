namespace COW;

public class OTPProcess
{
	public OTPOperationType Operation;

	public OTPState State;

	public OTPState LastState;

	public OTPVerifyInfo VerifyInfo;

	public bool IsInRequesting;

	public bool IsFirstInRebindVerify;
}
