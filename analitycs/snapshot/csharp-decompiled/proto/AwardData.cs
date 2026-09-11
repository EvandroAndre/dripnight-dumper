using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AwardData : IMessage
{
	public List<Item> items;

	public uint coins;

	public uint gems;

	public uint exps;

	public uint activeness;

	public uint accelerators;

	public List<LikeItem> like_items;

	public uint active_points;

	public List<HippoInventoryItem> hippo_items;

	public uint hippo_money;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
