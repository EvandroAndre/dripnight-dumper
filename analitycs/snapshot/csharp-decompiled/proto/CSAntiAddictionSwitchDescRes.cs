using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSAntiAddictionSwitchDescRes : IMessage
{
	public AntiAddictionSwitchDesc anti_addiction_switch_desc;

	public List<PhoneNumControlDesc> phone_num_control_list;

	public List<DailyRechargeLimitDesc> daily_recharge_limit_descs;

	public AntiAddictionBRCommonConfigDesc br_common_config_desc;

	public List<AntiAddictionBRConfigDesc> br_config_descs;

	public List<AntiAddictionConfigDesc> config_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
