using System.Collections.Generic;

namespace proto;

public class DigitaluniverseBMissionRewardDesc
{
	public uint id;

	public uint progress;

	public List<AwardDesc> award_items;

	public ELimitedEvent.DigitaluniverseBGateType gate_type;
}
