using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class AIRegionalAllocationTableDataManager : SingletonModule<AIRegionalAllocationTableDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<AIRegionalAllocationTableData, uint> _003C_003E9__2_0;

		internal uint _003COnInit_003Eb__2_0(AIRegionalAllocationTableData value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, AIRegionalAllocationTableData> m_Dict;

	private Dictionary<string, List<string>> m_DictRegionToData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<string> GetLanguageByRegion(string region)
	{
		return null;
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
