using System.Collections.Generic;

namespace tcp;

public class ShowEmoteReq
{
	public ulong group_id;

	public uint emote_id;

	public List<TeammateEmoteInfo> teammate_emote_infos;
}
