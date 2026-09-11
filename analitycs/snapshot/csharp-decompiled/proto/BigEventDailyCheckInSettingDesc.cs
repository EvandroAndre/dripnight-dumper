using System.Collections.Generic;

namespace proto;

public class BigEventDailyCheckInSettingDesc
{
	public uint event_id;

	public uint login_day_num;

	public List<AwardDesc> awards;

	public string show_login_story;

	public bool is_grand_award;
}
