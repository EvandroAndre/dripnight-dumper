using System.Collections.Generic;

namespace proto;

public class CustomCardProgressDesc
{
	public uint custom_event_id;

	public uint id;

	public uint condition;

	public List<AwardDesc> awards;

	public uint normal_cdnid;

	public uint open_cdnid;

	public string effect_fbx;
}
