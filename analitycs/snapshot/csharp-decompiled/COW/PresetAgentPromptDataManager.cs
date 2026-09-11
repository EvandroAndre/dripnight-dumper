using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class PresetAgentPromptDataManager : SingletonModule<PresetAgentPromptDataManager>
{
	public enum EPresetAgentPromptType
	{
		None,
		Skill,
		DefaultQuestion
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PresetAgentPrompt, uint> _003C_003E9__8_0;

		internal uint _003COnInit_003Eb__8_0(PresetAgentPrompt value)
		{
			return 0u;
		}
	}

	private CSVAsyncDataMap<uint, PresetAgentPrompt> m_Dict;

	private List<PresetAgentPrompt> m_LocLangDataList;

	private Dictionary<uint, List<PresetAgentPrompt>> m_DictDefaultQuestionIdToPromptDataList;

	private List<PresetAgentPrompt> m_DefaultQuestionList;

	private Dictionary<uint, PresetAgentPrompt> m_DictAvatarIdToPromptData;

	public const uint DefaultAutoPromptQuestionId = 1u;

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

	public PresetAgentPrompt GetPresetAgentPromptDataById(uint id)
	{
		return null;
	}

	public List<PresetAgentPrompt> GetPresetAgentPromptDefualtQuestion()
	{
		return null;
	}

	public PresetAgentPrompt GetPresetAgentPromptDataByAvatarId(uint id)
	{
		return null;
	}

	public PresetAgentPrompt GetPresetAgentPromptDataByKey(uint subType, uint recType)
	{
		return null;
	}

	public PresetAgentPrompt GetPresetAgentDefaultPromptDataBySubType(uint subType)
	{
		return null;
	}

	private void ProcessData()
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
