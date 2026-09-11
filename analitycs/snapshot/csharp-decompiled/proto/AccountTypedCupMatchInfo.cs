namespace proto;

public class AccountTypedCupMatchInfo
{
	public ulong team_id;

	public uint cup_type;

	public uint cup_id;

	public uint tier;

	public string team_name;

	public string country_or_area;

	public uint head_pic;

	public uint banner_id;

	public bool is_locked;

	public ulong captain_id;

	public uint member_num;

	public uint win_count;

	public ulong[] member_ids;

	public bool is_qualified;

	public bool[] battle_record;
}
