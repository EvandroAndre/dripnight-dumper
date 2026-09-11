using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class PresetAgentECADataManager : SingletonModule<PresetAgentECADataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PresetAgentECAData, uint> _003C_003E9__2_0;

		internal uint _003COnInit_003Eb__2_0(PresetAgentECAData value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, PresetAgentECAData> m_Dict;

	private List<PresetAgentECAData> m_List;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public PresetAgentECAData GetPresetAgentECADataByQuestionId(uint questionId)
	{
		return null;
	}

	public List<PresetAgentECAData> GetPresetAgentECADataList()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
