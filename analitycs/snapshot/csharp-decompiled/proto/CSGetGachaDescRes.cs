using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetGachaDescRes : IMessage
{
	public List<GachaDesc> gacha_desc_list;

	public List<ChestLuckyRemindConfigDesc> lucky_remind_configs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
