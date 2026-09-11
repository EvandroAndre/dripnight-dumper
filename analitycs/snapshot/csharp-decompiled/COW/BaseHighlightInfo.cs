using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class BaseHighlightInfo
{
	public uint GameMode;

	public uint Kill;

	public uint HighlightScore;

	public List<ReplayHighlightEvent> HighlightEvents;

	public List<ReplayHighlightEvent> HeadShotHighlightEvents;

	public List<ReplayHighlightEvent> MultiKillHighlightEvents;

	public List<ReplayHighlightEvent> CSAceHighlightEvents;

	public List<ReplayHighlightEvent> EpicHighlightEvents;

	public List<ReplayHighlightEvent> GuaranteedEvents;

	public List<ReplayKillEvent> KillEvents;

	public List<ReplayDeadEvent> DeadEvents;

	public HashSet<uint> CSAceRound;

	public bool CorrectionKillEvent(uint serial, float point, int weapon_id)
	{
		return false;
	}
}
