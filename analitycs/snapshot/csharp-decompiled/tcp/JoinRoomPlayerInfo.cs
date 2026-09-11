using System.Collections.Generic;

namespace tcp;

public class JoinRoomPlayerInfo
{
	public ulong conn_id;

	public uint emulator_score;

	public AccountMatchInfo basic_info;

	public uint[] available_maps;

	public string country_code;

	public uint using_version;

	public string language;

	public List<MapVersionInfo> map_versions;

	public string gp_player_id;

	public uint plat_id;
}
