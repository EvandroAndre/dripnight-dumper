using System.Collections.Generic;

namespace proto;

public class EighthBMatchStats
{
	public class EighthBInfo
	{
		public uint id;

		public uint cnt;

		public bool pre_cdt_triggered;
	}

	public ulong[] eighthb_oldff_teammate_ids;

	public uint occupy_oldff_cnt;

	public uint enter_oldff_cnt;

	public uint battle_zone_kills;

	public uint battle_zone_damage;

	public uint battle_zone_win_cnt;

	public uint pickup_unlimited_weapon_cnt;

	public uint perform_train_event_type;

	public List<EighthBInfo> get_unlimited_item;

	public List<EighthBInfo> use_unlimited_item;
}
