using System.Collections.Generic;

namespace tcp;

public class MatchmakingSpectateReq
{
	public ulong spectate_account_id;

	public List<AccountIDCPingInfo> ping_list;

	public uint[] available_maps;

	public uint system_platform;

	public MatchClientInfo client_info;

	public List<MapVersionInfo> map_versions;

	public ulong pre_group_id;
}
