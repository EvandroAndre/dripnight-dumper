using System.Collections.Generic;

namespace proto;

public class CallbackProcessDesc
{
	public uint callback_id;

	public uint process_id;

	public uint callback_value;

	public List<AwardDesc> awards;

	public string award_cdn;

	public string award_cdn2;
}
