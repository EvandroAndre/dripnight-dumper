using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class AccountLevelUpInfo : IMessage
{
	public ulong account_id;

	public uint level_before;

	public uint level_after;

	public uint new_exp;

	public AwardDataTCP awards;

	public List<ExchangedAwardTCP> exchanged_awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
