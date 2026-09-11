using tcp;

namespace COW;

public class MixGroupJoinStatus
{
	public GroupJoinRequestNtf joinData;

	public float expireTimeStamp;

	public uint delayCallId;

	public UIModelTeamReserve.EReserveReplyStatus replyStatus;
}
