using System.Collections.Generic;

namespace proto;

public class CSGetCustomMilestoneSettingRes
{
	public uint custom_event_id;

	public List<CustomMilestoneProgressDesc> progress;

	public CustomMilestoneSettingDesc setting;

	public List<CustomMilestoneShareDesc> shares;
}
