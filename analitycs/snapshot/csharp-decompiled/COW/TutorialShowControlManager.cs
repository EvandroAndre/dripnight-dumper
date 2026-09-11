using System;
using GCommon;

namespace COW;

internal class TutorialShowControlManager : SingletonModule<TutorialShowControlManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<TutorialShowControlConfigData, uint> _003C_003E9__2_0;

		public static Func<TutorialSoundConfigData, uint> _003C_003E9__2_1;

		internal uint _003COnInit_003Eb__2_0(TutorialShowControlConfigData value)
		{
			return 0u;
		}

		internal uint _003COnInit_003Eb__2_1(TutorialSoundConfigData value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, TutorialShowControlConfigData> m_DictShowControl;

	private CSVAsyncDataMap<uint, TutorialSoundConfigData> m_DictSound;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public TutorialShowControlConfigData GetTutorialShowControlByID(uint id)
	{
		return null;
	}

	public TutorialSoundConfigData GetTutorialSoundDataBySoundID(uint id)
	{
		return null;
	}

	public ResourceID GetTutorialSoundID(uint stepID, int voiceIndex)
	{
		return default(ResourceID);
	}
}
