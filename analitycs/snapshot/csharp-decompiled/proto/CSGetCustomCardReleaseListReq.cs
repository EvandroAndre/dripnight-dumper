using System.Collections.Generic;

namespace proto;

public class CSGetCustomCardReleaseListReq
{
	public uint custom_event_id;

	public List<CustomCardFriendInfo> friends;
}
