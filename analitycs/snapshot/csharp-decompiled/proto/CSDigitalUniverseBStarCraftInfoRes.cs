using System.Collections.Generic;

namespace proto;

public class CSDigitalUniverseBStarCraftInfoRes
{
	public class PlayerInfo
	{
		public ulong account_id;

		public uint progress;

		public uint gravitational_value;

		public ulong assistance_left_time;

		public string nick_name;

		public uint group_times;

		public uint assistance_times;

		public uint head_pic;

		public long upvote_timestamp;
	}

	public class AssistanceInfo
	{
		public ulong account_id;

		public string nick_name;

		public uint head_pic;

		public ulong timestamp;
	}

	public List<PlayerInfo> player_infos;

	public uint daily_assistance_times;

	public List<AssistanceInfo> assistance_history;

	public uint upvoted_times;

	public string message_text;

	public uint[] claimed_target_list;

	public ulong assist_timestamp;
}
