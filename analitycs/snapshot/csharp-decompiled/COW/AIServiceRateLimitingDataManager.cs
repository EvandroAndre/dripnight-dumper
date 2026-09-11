using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class AIServiceRateLimitingDataManager : SingletonModule<AIServiceRateLimitingDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<AIServiceRateLimitingData, uint> _003C_003E9__2_0;

		internal uint _003COnInit_003Eb__2_0(AIServiceRateLimitingData value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, AIServiceRateLimitingData> m_Dict;

	private Dictionary<int, AIServiceRateLimitingData> m_DictRuleIdToData;

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

	public AIServiceRateLimitingData GetAIServiceRateLimitingDataByRuleId(int ruleId)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
