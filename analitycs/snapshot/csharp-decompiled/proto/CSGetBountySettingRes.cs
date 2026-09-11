using System.Collections.Generic;

namespace proto;

public class CSGetBountySettingRes
{
	public BountySettingDesc setting;

	public List<BigEventTokenTipsDesc> exchange_token_tips;

	public List<BountyPlayerRatingDesc> player_ratings;
}
