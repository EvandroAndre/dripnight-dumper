using System.Collections.Generic;

namespace proto;

public class PVPCardInfo
{
	public bool enable_flip;

	public bool win_award;

	public List<CardPrice> card_price;

	public List<AwardFromCard> awards;

	public uint flip_count_today;

	public uint flip_count_max;

	public string back_image_url;
}
