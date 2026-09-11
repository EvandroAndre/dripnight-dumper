using System.Collections.Generic;

namespace proto;

public class MatchStatsAIDetail
{
	public class SkillInfo
	{
		public uint skill_id;

		public uint active_count;
	}

	public class CSBattleInfo
	{
		public ulong[] account_ids;

		public uint[] account_faction_ids;

		public bool is_match_win;

		public uint[] skill_ids;

		public List<SkillInfo> skill_infos;

		public uint kill_bot;

		public uint kill_ai;

		public uint kill_player;

		public uint down_count;

		public uint dying2dead_count;

		public uint damages;

		public uint dying2dead_damages;

		public uint to_player_damages;

		public uint to_bot_damages;

		public uint to_ai_damages;

		public uint rescue_count;

		public uint berescue_count;

		public bool is_mvp;

		public uint assist_count;

		public uint weapon_fire_count;

		public uint hit_count;

		public uint headshot_kills;

		public float headshot_rate;

		public uint medkit_use_count;

		public uint ice_wall_count;

		public uint grenade_count;

		public uint ice_grenade_count;

		public uint corrosion_grenade_count;

		public uint box_pickup_count;
	}

	public class CSRoundInfo
	{
		public enum PlayerStatus
		{
			None,
			Alive,
			Dying,
			Dead
		}

		public uint round_index;

		public bool is_round_win;

		public uint round_score;

		public PlayerStatus player_status;

		public uint round_duration;

		public uint survival_time;

		public uint first_fire_time;

		public uint skill_cnt;

		public uint kill_cnt;

		public uint kill_bot;

		public uint kill_ai;

		public uint kill_player;

		public uint down_count;

		public uint dying2dead_count;

		public uint damages;

		public uint dying2dead_damages;

		public uint to_player_damages;

		public uint to_bot_damages;

		public uint to_ai_damages;

		public uint rescue_count;

		public uint berescue_count;

		public bool is_mvp;

		public uint assist_count;

		public uint weapon_fire_count;

		public uint hit_count;

		public uint headshot_kills;

		public float headshot_rate;

		public uint double_kills;

		public uint triple_kills;

		public uint quadra_kills;

		public uint medkit_use_count;

		public uint ice_wall_count;

		public uint grenade_count;

		public uint ice_grenade_count;

		public uint corrosion_grenade_count;

		public uint box_pickup_count;
	}

	public class BRBattleInfo
	{
		public uint dying2dead_count;

		public uint kill_cnt;

		public uint kill_bot;

		public uint kill_ai;

		public uint kill_player;

		public uint damages;

		public uint dying2dead_damages;

		public uint to_player_damages;

		public uint to_bot_damages;

		public uint to_ai_damages;

		public uint cure_count;

		public uint medkit_use_count;

		public uint respirator_use_count;
	}

	public ulong account_id;

	public string lock_region;

	public ulong match_id;

	public uint ai_screen_play;

	public uint warm_match_type;

	public bool warm_match_is_ai;

	public bool have_protect_card;

	public bool quit_match;

	public CSBattleInfo cs_battle_info;

	public List<CSRoundInfo> cs_rounds;

	public BRBattleInfo br_battle_info;
}
