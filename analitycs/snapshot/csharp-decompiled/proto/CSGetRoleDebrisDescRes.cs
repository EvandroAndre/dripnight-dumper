using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetRoleDebrisDescRes : IMessage
{
	public List<RoleDebrisPurchaseDesc> role_debris_tables;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
