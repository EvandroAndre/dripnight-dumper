using System.Collections.Generic;

namespace proto;

public class CSGetFlame25BRedDotInfoRes
{
	public bool has_progress_claimable;

	public uint[] badge_ids;

	public List<Flame25BLevelDesc> levels;

	public List<Flame25BClanDesc> clans;

	public Flame25BLoadingCardInfo loading_card_info;
}
