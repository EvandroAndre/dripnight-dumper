using System.Collections.Generic;

namespace tcp;

public class GroupSpectateReq
{
	public ulong spectate_account_id;

	public List<AccountIDCPingInfo> ping_list;

	public uint[] available_maps;

	public uint system_platform;

	public MatchClientInfo client_info;

	public List<MapVersionInfo> map_versions;
}
