using ProtoBuf;

namespace proto;

public class AntiAddictionConfigDesc : IMessage
{
	public string country;

	public EAntiAddiction.AgeState age;

	public uint total_time1;

	public EAntiAddiction.TotalTimeBanMode ban_mode1;

	public uint ban_time1;

	public string total_time_hint_string1;

	public uint total_time2;

	public EAntiAddiction.TotalTimeBanMode ban_mode2;

	public uint ban_time2;

	public string total_time_hint_string2;

	public uint total_time3;

	public EAntiAddiction.TotalTimeBanMode ban_mode3;

	public uint ban_time3;

	public string total_time_hint_string3;

	public string region;

	public uint[] chat_switch_list;

	public uint[] voice_switch_list;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
