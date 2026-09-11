using System.Collections.Generic;

namespace proto;

public class CSGetMoneyHeistInfoRes
{
	public uint speed_from_friend;

	public uint speed_from_task;

	public uint speed_from_tokens;

	public uint[] rewarded;

	public ulong[] help_other;

	public List<HelpPlayer> be_helped;

	public uint deposit;

	public uint speed_change_time;

	public long reset_time;
}
