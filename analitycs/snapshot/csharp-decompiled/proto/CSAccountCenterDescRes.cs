using ProtoBuf;

namespace proto;

public class CSAccountCenterDescRes : IMessage
{
	public AccountCenterDesc acct_center_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
