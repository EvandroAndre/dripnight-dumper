using System.Collections.Generic;

namespace proto;

public class CustomEventProcessSettingDesc
{
	public uint custom_event_id;

	public uint process_id;

	public ulong start_value;

	public ulong end_value;

	public uint time_span;

	public List<AwardDesc> awards;
}
