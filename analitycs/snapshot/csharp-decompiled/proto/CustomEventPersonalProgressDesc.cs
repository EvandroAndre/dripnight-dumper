using System.Collections.Generic;

namespace proto;

public class CustomEventPersonalProgressDesc
{
	public uint custom_event_id;

	public uint progress_id;

	public uint token_amount;

	public List<AwardDesc> awards;
}
