using tcp;

namespace COW;

public class InviteFriendData
{
	public ulong AccountID;

	public string Region;

	public EGroup.InviteeType InviteeType;

	public bool isOffline;

	public bool isCsBan;

	public EInvitePushType PushType;

	public string NickName;

	public InviteFriendData(ulong account, string region, EGroup.InviteeType inviteeType, bool offline, EInvitePushType pushType, bool csBan, string nickName)
	{
	}
}
