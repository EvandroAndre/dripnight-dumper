using System.Collections.Generic;

namespace tcp;

public class RoomSpectateIngamePlayerReq
{
	public ulong spectate_account_id;

	public List<AccountIDCPingInfo> ping_list;

	public uint[] available_maps;

	public uint system_platform;

	public MatchClientInfo client_info;

	public ulong room_id;

	public string language;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public List<MapVersionInfo> map_versions;
}
