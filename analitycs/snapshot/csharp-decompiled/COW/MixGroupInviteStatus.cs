using tcp;

namespace COW;

public class MixGroupInviteStatus
{
	public GroupInviteNtf inviteData;

	public float expireTimeStamp;

	public uint delayCallId;

	public UIModelTeamReserve.EReserveReplyStatus replyStatus;
}
