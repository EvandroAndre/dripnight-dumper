using System.Collections.Generic;

namespace proto;

public class MajorLoginRes
{
	public ulong account_id;

	public string lock_region;

	public string noti_region;

	public string ip_region;

	public string agora_environment;

	public string new_active_region;

	public List<string> recommend_regions;

	public string token;

	public uint ttl;

	public string server_url;

	public uint emulator_score;

	public BlacklistInfoRes blacklist;

	public LoginQueueInfo queue_info;

	public string tp_url;

	public uint app_server_id;

	public string ip_city;

	public string ip_subdivision;

	public uint kts;

	public byte[] ak;

	public byte[] aiv;

	public string ffanti_url;

	public FFAntiConfigDesc ff_anti_config_desc;
}
