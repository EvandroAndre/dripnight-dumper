using System.Collections.Generic;

namespace proto;

public class CustomCardRewardDesc
{
	public class CardInfo
	{
		public uint card_id;

		public uint card_num;
	}

	public uint custom_event_id;

	public uint id;

	public List<AwardDesc> awards;

	public List<CardInfo> cards;
}
