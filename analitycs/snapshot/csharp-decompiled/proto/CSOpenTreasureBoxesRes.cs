using System.Collections.Generic;

namespace proto;

public class CSOpenTreasureBoxesRes
{
	public AwardData awards;

	public List<LeftBoxInfo> left_boxes_num;

	public List<ExchangedAward> exchangedAwards;

	public bool is_open_success;
}
