using System.Collections.Generic;

namespace proto;

public class CSGetBooyahDaySettingRes
{
	public BooyahDaySettingDesc setting;

	public List<BigEventTokenTipsDesc> exchange_token_tips;

	public List<BigEventTokenTipsDesc> sugar_token_tips;

	public List<BooyahDayProcessRewardDesc> process_reward_info;

	public List<BigEventProcessSettingDesc> process_setting;

	public List<BooyahDaySignInDesc> sign_in;
}
