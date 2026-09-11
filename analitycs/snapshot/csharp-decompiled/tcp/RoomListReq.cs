using System.Collections.Generic;

namespace tcp;

public class RoomListReq
{
	public ulong room_id;

	public ERoom.Type room_type;

	public List<EMatch.GameMode> game_modes;

	public ERoom.TabType room_tab_type;

	public string workshop_code;

	public string language;

	public ulong clan_id;

	public ulong esports_id;

	public uint preset_id;
}
