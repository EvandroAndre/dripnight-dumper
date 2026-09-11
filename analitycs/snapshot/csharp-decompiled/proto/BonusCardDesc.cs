using ProtoBuf;

namespace proto;

public class BonusCardDesc : IMessage
{
	public uint id;

	public string name;

	public EInventory.BonusCardType card_type;

	public uint gold_factor;

	public uint exp_factor;

	public uint ep_debris_factor;

	public uint mentoring_intimacy_factor;

	public uint link_factor;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
