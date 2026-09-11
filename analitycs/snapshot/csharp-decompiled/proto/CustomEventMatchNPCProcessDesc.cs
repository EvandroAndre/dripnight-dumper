using System.Collections.Generic;

namespace proto;

public class CustomEventMatchNPCProcessDesc
{
	public uint custom_event_id;

	public uint id;

	public uint process_amount;

	public uint process_story_id;

	public List<AwardDesc> awards;

	public uint normal_cdnid;

	public uint open_cdnid;

	public string effect_fbx;
}
