namespace proto;

public class CSGetAccountCupInfoBundleByAccountIDsOrderlyReq
{
	public uint cup_type;

	public uint cup_id;

	public ulong[] account_ids;

	public bool need_team_info;
}
