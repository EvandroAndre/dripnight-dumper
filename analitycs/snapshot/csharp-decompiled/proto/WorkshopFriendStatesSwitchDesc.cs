using ProtoBuf;

namespace proto;

public class WorkshopFriendStatesSwitchDesc : IMessage
{
	public uint game_mode;

	public string comment;

	public bool friend_states_switch;

	public bool reserve_button_switch;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
