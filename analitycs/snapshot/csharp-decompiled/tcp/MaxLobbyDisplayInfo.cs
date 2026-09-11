using ProtoBuf;

namespace tcp;

public class MaxLobbyDisplayInfo : IMessage
{
	public uint[] weapon_ids;

	public uint vehicle_display;

	public uint gloo_display;

	public uint skyboard_display;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
