using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetVipCardDescRes : IMessage
{
	public List<VipCardDailyAwardDesc> daily_awards;

	public List<VipCardInitAwardDesc> init_awards;

	public List<VipCardDesc> descs;

	public List<VipCardRebateDesc> rebates;

	public uint resign_coins;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
