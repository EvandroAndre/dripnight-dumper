using System.Collections.Generic;

namespace proto;

public class AccountLeaderboardProfile
{
	public AccountInfoBasic basic_info;

	public AccountInfoWithStats stat;

	public uint rank;

	public uint ranking_points;

	public byte[] limited_event_info;

	public List<HuntingGroundRecords> hunting_ground_records;

	public List<HuntingGroundLikePVERecords> hgl_pve_records;

	public uint cs_peak_points;
}
