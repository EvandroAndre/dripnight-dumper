using System.Collections.Generic;

namespace proto;

public class CreditPunishOtherDesc
{
	public uint id;

	public ECreditScore.PunishOtherType punish_type;

	public ulong sub_type;

	public Dictionary<uint, bool> trigger_behaviors;

	public uint punish_check_time;

	public long punish_duration;

	public long check_cycle_duration;

	public uint match_mode;
}
