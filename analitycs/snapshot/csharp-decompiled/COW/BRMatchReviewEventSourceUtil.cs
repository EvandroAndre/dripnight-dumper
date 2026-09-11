using System.Collections.Generic;
using message;

namespace COW;

public static class BRMatchReviewEventSourceUtil
{
	private struct KillIdentityKey
	{
		public int Ms;

		public uint SrcPlayerID;

		public uint DstPlayerID;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}
	}

	public static List<HJNFDCJPPDE> BuildEventsWithSyntheticTeamEliminatedKills(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	private static bool ShouldCreateSyntheticKill(HJNFDCJPPDE evt, HashSet<KillIdentityKey> killKeys)
	{
		return false;
	}

	public static bool IsSyntheticTeamEliminatedKill(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static HJNFDCJPPDE CreateSyntheticKillFromTeamEliminated(HJNFDCJPPDE teamEliminatedEvent)
	{
		return null;
	}

	private static KillIdentityKey BuildKillIdentityKey(HJNFDCJPPDE evt)
	{
		return default(KillIdentityKey);
	}
}
