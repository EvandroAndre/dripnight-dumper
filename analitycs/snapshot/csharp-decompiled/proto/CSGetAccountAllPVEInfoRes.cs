using System.Collections.Generic;

namespace proto;

public class CSGetAccountAllPVEInfoRes
{
	public HuntingGroundDetailedInfo hunting_ground_info;

	public List<HuntingGroundLikePVEInfo> hgl_pve_info;

	public PlayerTalentInfo talent;

	public bool has_talent_daily_reward;

	public uint[] display_leaderboard_ids;
}
