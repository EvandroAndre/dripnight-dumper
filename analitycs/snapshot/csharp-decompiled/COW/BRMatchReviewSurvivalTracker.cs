using System;
using System.Collections.Generic;
using message;

namespace COW;

public class BRMatchReviewSurvivalTracker
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HJNFDCJPPDE> _003C_003E9__3_0;

		internal int _003CBuild_003Eb__3_0(HJNFDCJPPDE a, HJNFDCJPPDE b)
		{
			return 0;
		}
	}

	private List<SurvivalSnapshot> m_Timeline;

	private int m_InitialPlayerCount;

	private int m_InitialTeamCount;

	public void Build(List<HJNFDCJPPDE> allEvents, List<JODHCHIKNEP> teams)
	{
	}

	public SurvivalSnapshot GetSurvivalAt(float timeMs)
	{
		return default(SurvivalSnapshot);
	}

	public void Reset()
	{
	}
}
