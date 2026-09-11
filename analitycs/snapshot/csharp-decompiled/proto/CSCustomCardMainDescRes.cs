using System.Collections.Generic;

namespace proto;

public class CSCustomCardMainDescRes
{
	public uint custom_event_id;

	public List<CustomCardInfoDesc> cards;

	public List<CustomCardProgressDesc> progress_infos;

	public List<CustomCardRewardDesc> floor_infos;

	public CustomCardConstantDesc constant;
}
