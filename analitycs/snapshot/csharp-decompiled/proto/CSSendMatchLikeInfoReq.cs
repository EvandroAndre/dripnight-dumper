using System.Collections.Generic;

namespace proto;

public class CSSendMatchLikeInfoReq
{
	public ulong match_id;

	public uint game_mode;

	public uint match_mode;

	public List<LikeReceiverInfo> like_receiver_list;

	public uint season_id;

	public string workshop_code;
}
