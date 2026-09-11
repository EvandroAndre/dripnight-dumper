using System.Collections.Generic;

namespace tcp;

public class ModeStatsScoreUpdateNtf
{
	public uint score_before;

	public uint score_after;

	public List<ModeStatsScoreDetail> score_update_details;
}
