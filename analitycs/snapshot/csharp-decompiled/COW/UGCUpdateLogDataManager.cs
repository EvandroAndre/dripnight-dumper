using System;
using GCommon;

namespace COW;

public class UGCUpdateLogDataManager : SingletonModule<UGCUpdateLogDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CSVBaseData> _003C_003E9__3_0;

		internal int _003COnInit_003Eb__3_0(CSVBaseData a, CSVBaseData b)
		{
			return 0;
		}
	}

	private UGCUpdateLogData m_Data;

	public UGCUpdateLogData Data => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
