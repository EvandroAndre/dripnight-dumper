namespace proto;

public class AccountPresence
{
	public ulong account_id;

	public string noti_region;

	public EPresence.AccountPresence presence;

	public long update_time;

	public long login_time;

	public ulong group_id;

	public string group_region;

	public string lock_region;

	public uint match_mode;

	public uint game_mode;

	public uint map_id;

	public uint group_member_cnt;

	public uint group_mode;

	public EPresence.AccountSocialStatus social_status;

	public string workshop_code;

	public string workshop_name;

	public ulong room_id;

	public EPresence.SocialPresence social_presence;

	public SocialRecommendLabels social_recommend_labels;

	public uint room_type;

	public uint room_member_cnt;

	public uint room_max_member_cnt;

	public EPresence.AccountCraftLandEditStatus craft_land_edit_status;

	public bool enable_halfway_join;
}
