using System.Collections.Generic;

namespace proto;

public class CSCustomTCMainRes
{
	public class RewardInfo
	{
		public uint piece;

		public uint amount;
	}

	public uint custom_event_id;

	public CustomTCConstantDesc constant;

	public List<CustomTCPieceDesc> pieces;

	public List<CustomTCRewardDesc> rewards;

	public List<RewardInfo> reward_infos;

	public uint current_piece;

	public uint progress;

	public uint free_count;
}
