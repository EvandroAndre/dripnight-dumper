using System.Collections.Generic;

namespace proto;

public class LevelRewardsDesc
{
	public uint target_level;

	public List<AwardDesc> awards;

	public string award_show;

	public string award_icon;

	public string award_icon_big;

	public List<ExchangedAward> exchange_awards;

	public AwardDesc display_fresh_awards;
}
