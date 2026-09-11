using System.Collections.Generic;

namespace proto;

public class RoomGroupMatchStats
{
	public ulong group_id;

	public uint rank;

	public uint score;

	public string name;

	public List<RoomPlayerMatchStats> members;

	public uint group_index;
}
