using ProtoBuf;

namespace proto;

public class PrimeLevelDesc : IMessage
{
	public uint level;

	public int points;

	public uint badge;

	public uint profile_skin;

	public uint profile_ani;

	public uint interface_skin;

	public uint set_share;

	public uint avatar_frame;

	public uint name_color;

	public uint festival;

	public uint big_screen;

	public uint matchmaking_blacklist;

	public uint add_set;

	public uint add_friend;

	public uint exclusive_shop;

	public uint exclusive_gacha;

	public uint emote;

	public uint avatar_banner1;

	public uint avatar_banner2;

	public uint avatar_banner3;

	public uint gloo_wall;

	public uint prime_leader_board;

	public uint profile_badge;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
