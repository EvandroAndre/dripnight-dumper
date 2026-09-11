using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ExtraRewardDesc : IMessage
{
	public uint chest_id;

	public string icon;

	public uint cdt_type;

	public uint cdt_value;

	public List<ExchangedAward> reward_list;

	public uint chest_sub_id;

	public uint token_id;

	public uint token_num;

	public uint rare_reward;

	public bool is_show_box;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
