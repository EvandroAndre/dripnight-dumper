using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetMailListRes : IMessage
{
	public List<MailInfo> mails;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
