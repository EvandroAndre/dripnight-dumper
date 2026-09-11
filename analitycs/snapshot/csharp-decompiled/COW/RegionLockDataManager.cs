using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class RegionLockDataManager : SingletonModule<RegionLockDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RegionLock, string> _003C_003E9__2_0;

		internal string _003COnInit_003Eb__2_0(RegionLock value)
		{
			return null;
		}
	}

	private Dictionary<string, string> m_DictIPRegionToIDRegion;

	private CSVAsyncDataMap<string, RegionLock> m_DictRegionLock;

	protected override void OnInit()
	{
	}

	protected void loadData()
	{
	}

	protected override void OnCleanup()
	{
	}

	public string GetIDRegionFromIPRegion(string countryCode)
	{
		return null;
	}
}
