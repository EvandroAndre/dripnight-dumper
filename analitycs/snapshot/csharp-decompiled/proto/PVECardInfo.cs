using System.Collections.Generic;

namespace proto;

public class PVECardInfo
{
	public bool enable_flip;

	public List<CardPrice> card_price;

	public List<AwardFromCard> awards;

	public uint flip_count_today;

	public uint flip_count_max;

	public List<CardImageDesc> back_image;

	public uint match_rank;
}
