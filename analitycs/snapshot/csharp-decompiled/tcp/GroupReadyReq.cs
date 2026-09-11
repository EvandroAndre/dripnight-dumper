namespace tcp;

public class GroupReadyReq
{
	public ulong group_id;

	public bool ready;

	public bool quick_start;

	public uint matchmaking_reason;

	public uint ready_reason;
}
