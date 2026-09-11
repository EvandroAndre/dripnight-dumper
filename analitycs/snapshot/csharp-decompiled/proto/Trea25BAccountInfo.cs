using System.Collections.Generic;

namespace proto;

public class Trea25BAccountInfo
{
	public class HelpFriendInfo
	{
		public ulong account_id;

		public uint help_count;
	}

	public enum EAccountTag
	{
		EAT_NONE,
		EAT_ODD,
		EAT_EVEN
	}

	public uint goldenshovel_count;

	public uint daily_be_helped_count;

	public long update_time;

	public long help_send_time;

	public List<Trea25BMapInfo> maps;

	public List<HelpFriendInfo> help_friend_infos;

	public EAccountTag account_tag;

	public long account_tag_update_time;

	public uint continuous_mining_obstacles_count;

	public bool is_already_event_push;
}
