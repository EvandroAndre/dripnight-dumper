using System.Collections.Generic;

namespace tcp;

public class RoomGroupInfo
{
	public ulong id;

	public string name;

	public List<RoomPlayerInfo> members;

	public string abbr_name;

	public uint rank;

	public uint score;
}
