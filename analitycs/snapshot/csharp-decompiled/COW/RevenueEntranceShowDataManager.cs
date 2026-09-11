using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class RevenueEntranceShowDataManager : SingletonModule<RevenueEntranceShowDataManager>
{
	private Dictionary<uint, uint> m_TypePriorityDict;

	private byte m_RevenueEntranceChangeIsValid;

	private const byte Flag_RevenueEntranceABTest = 1;

	private const byte Flag_RevenueEntranceInTeamShowABTest = 2;

	public const uint TAG_COLOR_YELLOW = 4290380031u;

	public const uint TAG_COLOR_RED = 4286066687u;

	private static readonly int[] RevenueEntranceTypePriorit;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public uint GetEntrancePriority(ERevenueEntranceType type)
	{
		return 0u;
	}

	public void ProcessRevenueRes(CSGetRevenueEntranceShowDescRes descs)
	{
	}
}
