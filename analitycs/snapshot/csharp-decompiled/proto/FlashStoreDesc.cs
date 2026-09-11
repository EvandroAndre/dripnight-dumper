using System.Collections.Generic;

namespace proto;

public class FlashStoreDesc
{
	public uint flash_store_activity_id;

	public long start_time;

	public long end_time;

	public uint flash_store_id;

	public uint flash_gem_id;

	public List<FlashStorePeriodInfo> period_infos;

	public string store_title_url;

	public string mission_title_url;

	public string language;
}
