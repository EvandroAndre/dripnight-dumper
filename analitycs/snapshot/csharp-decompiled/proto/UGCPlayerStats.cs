using System.Collections.Generic;

namespace proto;

public class UGCPlayerStats
{
	public ulong account_id;

	public string nickname;

	public string clan_name;

	public uint head_pic;

	public uint banner_id;

	public uint avatar_id;

	public uint role;

	public uint liked;

	public string lock_region;

	public bool is_mvp;

	public bool is_quit;

	public uint relation_mask;

	public int[] score_to_show;

	public uint global_rank;

	public uint custom_result;

	public List<string> custom_score_name;

	public List<string> custom_score_value;

	public BadgeInfo badge_info;

	public bool membership_privilege;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint avatar_frame;
}
