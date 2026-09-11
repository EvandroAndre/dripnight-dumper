using ProtoBuf;

namespace proto;

public class AccountPrefers : IMessage
{
	public bool hide_my_lobby;

	public uint[] pregame_show_choices;

	public uint[] br_pregame_show_choices;

	public bool hide_personal_info;

	public bool disable_friend_spectate;

	public bool hide_occupation;

	public uint[] cs_peak_pregame_show_choices;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
