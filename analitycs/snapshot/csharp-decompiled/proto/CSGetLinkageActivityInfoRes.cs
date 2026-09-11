using System.Collections.Generic;

namespace proto;

public class CSGetLinkageActivityInfoRes
{
	public uint day;

	public uint activity_id;

	public uint activity_type;

	public uint today_data;

	public uint total_data;

	public EActivity.State state;

	public long timezone_offset_secs;

	public ulong global_ep_badges;

	public List<LinkageProcessRewards> process_rewards;

	public string cdn_url;
}
