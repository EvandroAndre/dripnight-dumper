using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class CraftlandCreatorStats
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CraftlandCreatorLevelInfo> _003C_003E9__12_0;

		internal int _003C_002Ector_003Eb__12_0(CraftlandCreatorLevelInfo a, CraftlandCreatorLevelInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public uint level;

		internal bool _003CGetLevelUnlockTime_003Eb__0(CraftlandCreatorLevelInfo info)
		{
			return false;
		}
	}

	public ulong CreatorId;

	public ulong FollowerCount;

	public ulong Exp;

	public readonly List<CraftlandCreatorLevelInfo> LevelInfos;

	public readonly HashSet<uint> AwardedLevels;

	public string Bio;

	public readonly List<string> PinnedMaps;

	public long LatestUpdateAt;

	public uint GetCurLv()
	{
		return 0u;
	}

	public bool IsLevelUnLock(uint level)
	{
		return false;
	}

	public long GetLevelUnlockTime(uint level)
	{
		return 0L;
	}

	public CraftlandCreatorStats()
	{
	}

	public CraftlandCreatorStats(WorkshopCreatorStats stats)
	{
	}
}
