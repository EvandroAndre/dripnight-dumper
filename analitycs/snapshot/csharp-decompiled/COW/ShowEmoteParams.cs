using System.Collections.Generic;
using tcp;

namespace COW;

public class ShowEmoteParams
{
	public UIMaleAvatar Avatar;

	public ulong AccountID;

	public uint EmoteID;

	public List<TeammateEmoteInfo> TeammateEmoteInfoList;

	public EDuoEmoteStage EDuoEmoteStage;

	public EmoteExtralInfo ExtralInfo;

	public ShowEmoteParams(UIMaleAvatar avatar, ulong accountID, uint emoteID, List<TeammateEmoteInfo> teammateEmoteInfoList, EDuoEmoteStage eDuoEmoteStage, EmoteExtralInfo extralInfo)
	{
	}
}
