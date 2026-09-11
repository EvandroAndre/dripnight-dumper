using ProtoBuf;

namespace proto;

public class WeaponPowerLeaderboardSettingsDesc : IMessage
{
	public long choose_area_time;

	public bool auto_choose_area;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
