using System.Collections.Generic;

namespace proto;

public class VipCardInfo
{
	public EVipCard.VipCardType card_type;

	public uint start_time;

	public uint end_time;

	public List<VipCardAwardStatus> award_infos;

	public uint last_period_start_time;

	public uint last_period_end_time;

	public List<VipCardAwardStatus> last_period_award_infos;
}
