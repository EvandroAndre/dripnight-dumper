using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetBPAllDescsRes : IMessage
{
	public EventSettingDesc event_setting;

	public BPEventExpression event_expression;

	public List<BPGoods> goods;

	public BPCycleGoods cycle_goods;

	public BPPrice price;

	public BPSubscribe subscribe;

	public List<EPDailyProcessRewardDesc> daily_process_reward_desc;

	public List<ChallengeDesc> daily_challenge;

	public List<ChallengeDesc> weekly_challenge;

	public List<ChallengeDesc> weekly_challenge_pool;

	public BPPrice next_price;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
