using System.Collections.Generic;

namespace proto;

public class FFWSGuessingAwardDesc
{
	public uint session;

	public ELimitedEvent.FFWSGuessingAwardType award_enum;

	public List<AwardDesc> awards;

	public uint guessing_entries;
}
