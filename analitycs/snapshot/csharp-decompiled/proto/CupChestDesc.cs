using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CupChestDesc : IMessage
{
	public uint cup_type;

	public uint cup_id;

	public uint chest_id;

	public uint[] chest_tier;

	public uint chest_unlock_wins;

	public string chest_res;

	public string chest_name;

	public uint[] ticket_item_id;

	public List<AwardDesc> awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
