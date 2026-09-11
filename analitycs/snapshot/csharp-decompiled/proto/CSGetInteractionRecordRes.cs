using System.Collections.Generic;

namespace proto;

public class CSGetInteractionRecordRes
{
	public class InteractionRecord
	{
		public AccountInfoBasic info;

		public long interact_at;

		public uint match_mode;

		public uint game_mode;

		public bool liked;

		public bool is_gifted;

		public List<SpectateRewardInfo> spectate_rewards;
	}

	public List<InteractionRecord> interactions;

	public uint total_num;

	public uint today_num;
}
