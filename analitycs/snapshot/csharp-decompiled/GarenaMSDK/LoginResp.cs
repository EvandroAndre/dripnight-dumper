namespace GarenaMSDK;

public class LoginResp
{
	public ErrorCode errCode;

	public string openID;

	public string accessToken;

	public int platform;

	public int originalPlatform;

	public int primaryPlatform;

	public string extraMessage;

	public SessionStatus status;

	public string exceptionMessage;

	public string exceptionStackTrace;
}
