using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class SeasonLimitedItemDesc : IMessage
{
	public uint general_item_id;

	public uint match_mode;

	public List<PUint32KeyVal> season_item_ids;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
