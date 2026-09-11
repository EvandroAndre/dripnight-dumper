using System.Collections.Generic;

namespace proto;

public class OccupationDetailInfo
{
	public class WeaponTotalInfo
	{
		public uint weapon_type;

		public uint total_kills;

		public uint headshot_kills;

		public uint max_kill_weapon_id;

		public uint max_kill_num;

		public uint max_damage_weapon_id;

		public uint max_damage_num;
	}

	public uint season_id;

	public uint game_mode;

	public List<OccupationInfo> occupations;

	public uint games;

	public uint select_id;

	public uint match_mode;

	public uint extend_val;

	public List<WeaponTotalInfo> weapon_total_infos;

	public ulong cure_amount;

	public uint scan_target_cnt;

	public uint throwing_kills;

	public uint throwing_damage_cnt;

	public uint throwing_multi_kills;

	public List<OccupationHistorySeason> historys;
}
