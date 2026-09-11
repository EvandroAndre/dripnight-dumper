using ProtoBuf;

namespace proto;

public class WeaponPowerLeaderboardDesc : IMessage
{
	public enum AwardCycleType
	{
		AwardCycleNone,
		AwardCycleMonth,
		AwardCycleWeek,
		AwardCycleDebug
	}

	public uint id;

	public int main_type;

	public uint[] area_ids;

	public uint award_id;

	public uint award_cycle_type;

	public long award_offset_sec;

	public uint size;

	public uint leader_board_type;

	public uint starting_score;

	public string desc;

	public uint estimate_score;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
