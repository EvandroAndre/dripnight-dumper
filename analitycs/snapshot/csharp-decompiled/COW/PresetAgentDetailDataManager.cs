using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class PresetAgentDetailDataManager : SingletonModule<PresetAgentDetailDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PresetAgentDetail, uint> _003C_003E9__4_0;

		internal uint _003COnInit_003Eb__4_0(PresetAgentDetail value)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public uint questionType;

		internal bool _003CGetPresetAgentDetailByAvatarIdAndQuestionType_003Eb__0(PresetAgentDetail x)
		{
			return false;
		}
	}

	private CSVAsyncDataMap<uint, PresetAgentDetail> m_Dict;

	private List<PresetAgentDetail> m_LocLangDetailDataList;

	private Dictionary<uint, List<PresetAgentDetail>> m_DictAvatarIdToDetailDataList;

	public const string DefaultLanguage = "default";

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

	public PresetAgentDetail GetPresetAgentDetailByAvatarIdAndQuestionType(uint avatarId, uint questionType)
	{
		return null;
	}

	private void ProrcessDictAvatarIdToDetailDataList()
	{
	}

	private static string LocalizeCDN(string cdn, string localLang)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
