using System.Collections.Generic;
using GCommon;

namespace COW;

public class PeriodicRankingDataDisplayDataManager : SingletonModule<PeriodicRankingDataDisplayDataManager>
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public uint gameMode;

		internal bool _003CGetData_003Eb__0(PeriodicRankingDataDisplayData value)
		{
			return false;
		}
	}

	private List<PeriodicRankingDataDisplayData> m_DataList;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public PeriodicRankingDataDisplayData GetData(uint gameMode)
	{
		return null;
	}
}
