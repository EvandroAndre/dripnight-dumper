using ProtoBuf;

namespace proto;

public class RateAppSwitchDesc : IMessage
{
	public string region;

	public bool ios_open;

	public bool gp_open;

	public bool huawei_open;

	public bool xiaomi_open;

	public uint game_mode1;

	public uint rank1;

	public uint game_mode2;

	public uint rank2;

	public uint cd;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
