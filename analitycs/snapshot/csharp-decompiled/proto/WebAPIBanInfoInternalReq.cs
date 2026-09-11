namespace proto;

public class WebAPIBanInfoInternalReq
{
	public string env;

	public ulong account_id;

	public long expire_at;

	public string ban_reason;

	public string ban_message;

	public string operator_id;

	public string lock_region;

	public string noti_region;

	public string ban_type;
}
