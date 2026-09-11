using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ExchangedAward : IMessage
{
	public EInventory.AwardType origin_award_type;

	public uint origin_award_id;

	public uint origin_award_num;

	public EInventory.AwardType dest_award_type;

	public uint dest_award_id;

	public uint dest_award_num;

	public uint origin_award_time;

	public uint source_item_id;

	public List<AwardDesc> dest_award_list;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
