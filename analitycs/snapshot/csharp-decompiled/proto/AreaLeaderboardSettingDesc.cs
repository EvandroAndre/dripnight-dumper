using ProtoBuf;

namespace proto;

public class AreaLeaderboardSettingDesc : IMessage
{
	public long choose_area_time;

	public bool auto_choose_area;

	public uint[] hide_leaderboard_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
