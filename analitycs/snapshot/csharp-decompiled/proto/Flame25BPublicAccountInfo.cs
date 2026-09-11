using System.Collections.Generic;

namespace proto;

public class Flame25BPublicAccountInfo
{
	public class Flame25BProp
	{
		public uint prop_id;

		public uint prop_value;
	}

	public class Flame25BPropInfo
	{
		public uint game_mode;

		public uint match_mode;

		public List<Flame25BProp> props;
	}

	public class Flame25BEvent
	{
		public ulong event_serial_id;

		public uint event_id;

		public uint event_type;

		public long event_time;

		public uint event_value;

		public uint like_count;
	}

	public uint flame_level;

	public uint choose_clan_id;

	public uint like_total;

	public uint player_like_total;

	public uint cur_progress;

	public List<Flame25BChooseProp> choose_props;

	public string role_cdn_url;

	public List<Flame25BPropInfo> prop_infos;

	public uint[] badge_ids;

	public List<Flame25BEvent> events;
}
