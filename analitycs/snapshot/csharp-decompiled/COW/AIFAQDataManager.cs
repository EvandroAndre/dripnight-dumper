using System;
using GCommon;

namespace COW;

public class AIFAQDataManager : SingletonModule<AIFAQDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<AIFAQData, uint> _003C_003E9__1_0;

		internal uint _003COnInit_003Eb__1_0(AIFAQData value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, AIFAQData> m_Dict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public AIFAQData GetAIFAQDataBySceneId(uint id)
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
