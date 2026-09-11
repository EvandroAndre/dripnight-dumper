using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class GEventShowEmote : GEvent
{
	public uint EmoteId;

	public List<TeammateEmoteInfo> teammate_emote_infos;

	public EDuoEmoteStage DuoEmoteStage;

	public EmoteExtralInfo ExtraInfo;
}
