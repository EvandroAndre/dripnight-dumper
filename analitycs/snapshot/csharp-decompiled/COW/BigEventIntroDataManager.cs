using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class BigEventIntroDataManager : SingletonModule<BigEventIntroDataManager>
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public EBigEventIntroTiming timing;

		internal bool _003CGetIntroData_003Eb__0(BigEventIntroData e)
		{
			return false;
		}
	}

	private Dictionary<int, List<BigEventIntroData>> m_Data;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public BigEventIntroData GetIntroData(ELimitedEvent.EventID eventId, EBigEventIntroTiming timing)
	{
		return null;
	}
}
