using System;
using System.Text;
using message;
using proto;

namespace COW;

public static class UGCProfileHelper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<int> _003C_003E9__4_0;

		internal bool _003CExtractSelfKillCount_003Eb__4_0(int x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public UGCMatchStats stats;

		internal bool _003CExtractSelfStats_003Eb__0(UGCPlayerStats x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public UGCMatchStats stats;

		internal bool _003CExtractSelfTeamStats_003Eb__0(UGCTeamStats x)
		{
			return false;
		}
	}

	public static bool IsUGCGame(NIKKALKPIBO gameMode)
	{
		return false;
	}

	public static int ExtractTeamCount(UGCMatchStats stats)
	{
		return 0;
	}

	public static int ExtractMaxTeammateCount(UGCMatchStats stats)
	{
		return 0;
	}

	public static int ExtractSelfRank(UGCMatchStats stats)
	{
		return 0;
	}

	public static int ExtractSelfKillCount(UGCMatchStats stats)
	{
		return 0;
	}

	public static UGCPlayerStats ExtractSelfStatsFromAllPlayers(UGCMatchStats stats)
	{
		return null;
	}

	public static UGCPlayerStats ExtractSelfStats(UGCMatchStats stats)
	{
		return null;
	}

	public static UGCTeamStats ExtractSelfTeamStats(UGCMatchStats stats)
	{
		return null;
	}

	public static bool IsTeammate(UGCMatchStats stats, ulong accountID, out bool foundUser)
	{
		foundUser = default(bool);
		return false;
	}

	public static string Print(UGCMatchStats stats)
	{
		return null;
	}

	public static void Print(UGCTeamStats teamStats, ref StringBuilder sb)
	{
	}
}
