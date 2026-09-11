using System.Collections.Generic;

namespace proto;

public class CSGetEighthBInfoRes
{
	public class AITrainsInfo
	{
		public string ai_train;

		public bool is_ban;
	}

	public class SeventhBOtherMessageInfo
	{
		public uint send_msg_id;

		public string other_message;

		public ulong signature_time;

		public string signature;
	}

	public uint cur_progress;

	public uint[] claimed_progress;

	public uint[] own_decorations;

	public EighthBApplyDecorationInfo apply_decoration_info;

	public List<AITrainsInfo> ai_trains;

	public uint ai_generate_times;

	public uint claimable_linkage_token_cnt;

	public uint got_linkage_token_cnt;

	public SeventhBOtherMessageInfo seventhb_message;
}
