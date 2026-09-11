using System.Collections.Generic;

namespace proto;

public class NewageBObjectsDesc
{
	public uint stage;

	public uint item_id;

	public uint exchange_num;

	public List<AwardDesc> awards;

	public uint activity_id;

	public uint[] skin_award_ids;
}
