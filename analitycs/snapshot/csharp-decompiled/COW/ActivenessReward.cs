using System.Collections.Generic;
using proto;

namespace COW;

public class ActivenessReward
{
	public uint group_id;

	public uint box_id;

	public string box;

	public string box_icon1;

	public string box_icon2;

	public string open_vfx;

	public uint necessary_activeness;

	public List<AwardDesc> awardsList;

	public bool received;
}
