using System.Collections.Generic;

namespace proto;

public class CSGetNB1ReSysWarmUpInfoRes
{
	public NB1ReSysWarmUpSettingDesc settings;

	public bool has_token;

	public bool has_final_reward;

	public List<BigEventProgressAwardDesc> nb1_progress_award_desc;

	public string claimed_date;
}
