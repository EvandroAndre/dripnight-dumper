using ProtoBuf;

namespace proto;

public class SquadTreasureAwardDesc : IMessage
{
	public uint squad_treasure_id;

	public uint award_tier_id;

	public uint award_type;

	public uint award_item_id;

	public uint award_num;

	public uint award_time;

	public bool is_big_award;

	public AwardDesc awards;

	public uint award_background_effect;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
