using System.Collections.Generic;
using proto;

namespace COW;

public class ClanWarChampionshipStage
{
	public enum EStage
	{
		None,
		QualifierWarmUp,
		QualifierMatch,
		QualifierSettlement,
		EliminatorWarmUp,
		EliminatorMatch,
		EliminatorSettlement
	}

	public enum ChampionshipRoundType
	{
		Qualifier = 1,
		Eliminator
	}

	public uint SeasonId;

	public uint SeasonType;

	public uint RoundId;

	public bool IsFirstEliminatorRound;

	public uint SeaRoundId;

	public uint QualifierScore;

	public bool OutInQualifier;

	public bool OutInEliminator;

	public uint OutRoundId;

	public uint QualifierRoundPointAdvance;

	public uint CurEliminatorRankAdvance;

	public ChampionshipRoundType StageType;

	public EStage Stage;

	public long CurStageEndTime;

	public uint CurPoints;

	public uint CurRankInEliminator;

	public string CurRankRegion;

	public bool isLastRound;

	public uint LastEliminatorRankAdvance;

	public uint LastQualifierScoreAdvance;

	public List<AwardDesc> awards;

	public uint GetStageID()
	{
		return 0u;
	}

	public override string ToString()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
