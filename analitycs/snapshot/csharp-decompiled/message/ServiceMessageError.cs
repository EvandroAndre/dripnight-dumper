namespace message;

public static class ServiceMessageError
{
	public const uint Login_BadRequest = 400u;

	public const uint Login_Forbidden = 403u;

	public const uint Login_UserNotExisted = 404u;

	public const uint Register_StatusBadRequest = 400u;

	public const uint BR_AUTH_SERVER_PROTECT_IS_OPEN = 800u;

	public const uint BR_GEOIP_REGION_NOT_OPEN = 801u;

	public const uint BR_FB_CONNECTED_GAS_ONLY = 802u;

	public const uint InvalidMsdkErrorCode = 900u;

	public const uint Match_Result_NoResultFound = 404u;
}
