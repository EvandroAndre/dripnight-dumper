using ProtoBuf;

namespace proto;

public class ClanLeaderboardSettingsDesc : IMessage
{
	public long choose_area_time;

	public bool auto_choose_area;

	public bool active_leaderboard_is_open;

	public long active_leaderboard_open_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
