using ProtoBuf;

namespace proto;

public class RelationTypeInfoDesc : IMessage
{
	public EFriend.RelationType relation_type;

	public uint relation_item_id;

	public uint reject_countdown;

	public uint relation_break_up_cd;

	public uint relation_break_up_countdown;

	public float item_intimacy_diamond_rate;

	public float item_intimacy_coin_rate;

	public uint intimacy_week_max;

	public uint relation_friend_max;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
