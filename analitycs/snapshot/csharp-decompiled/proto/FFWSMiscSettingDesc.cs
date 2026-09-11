using System.Collections.Generic;

namespace proto;

public class FFWSMiscSettingDesc
{
	public uint sugar_token_id;

	public uint exchange_token_id;

	public long guessing_deadline;

	public long award_announced_time;

	public long live_start_time;

	public long live_end_time;

	public List<string> live_cdn_urls;

	public string live_url;

	public long final_team_url_show_start_time;

	public long final_team_url_show_end_time;

	public string final_team_url;

	public long champion_url_show_switch_time;

	public string champion_url;

	public long store_unlock_time;

	public List<string> live_cdn_gopos;
}
