using System.Collections.Generic;

namespace proto;

public class CustomTCRewardDesc
{
	public uint custom_event_id;

	public uint piece;

	public List<AwardDesc> awards;

	public uint normal_cdnid;

	public uint open_cdnid;

	public string effect_fbx;

	public uint lock_cdnid;
}
