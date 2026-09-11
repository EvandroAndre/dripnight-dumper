namespace tcp;

public class RoomApplyJoinReq
{
	public ulong room_id;

	public string nickname;

	public ExternalIconInfo external_icon_info;

	public uint rank;

	public uint ranking_points;

	public uint cs_rank;

	public uint cs_ranking_points;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public uint head_pic;

	public ulong participant_id;

	public ERoom.Type room_type;

	public ulong original_room_id;

	public ulong original_group_id;

	public BadgeInfo badge_info;

	public uint role;

	public bool membership_privilege;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint cs_peak_points;

	public bool display_cs_peak_point;

	public uint avatar_frame;
}
