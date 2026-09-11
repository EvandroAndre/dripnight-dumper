using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GetOppositeSexModelRes : IMessage
{
	public List<OppositeSexModelDesc> opposite_sex_models;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
