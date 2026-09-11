namespace proto;

public class AdminCloneAccountReq
{
	public ulong from_account_id;

	public string from_account_lock_region;

	public ulong to_account_id;

	public string to_account_lock_region;

	public bool clone_stats;

	public bool clone_weapon_power;
}
