using System.Collections.Generic;

namespace tcp;

public class ShowEmoteNtf
{
	public ulong account_id;

	public uint emote_id;

	public List<TeammateEmoteInfo> teammate_emote_infos;

	public long create_time;
}
