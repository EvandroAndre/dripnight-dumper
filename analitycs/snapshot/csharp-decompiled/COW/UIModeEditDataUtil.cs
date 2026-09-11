using System.Collections.Generic;
using LitJson;
using message;

namespace COW;

public static class UIModeEditDataUtil
{
	public enum CustomModeTemplateType
	{
		FullCustom = 0,
		Score = 1,
		Racing = 2,
		Annihilate = 3,
		ScoreMulTeam = 4,
		RacingMulTeam = 5,
		AnnihilateMulTeam = 6,
		PVE_LEVEL = 7,
		PVE_DEFENCE = 8,
		Cat = 10
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int code;

		internal bool _003CTemplateToGameModeIndex_003Eb__0(CustomModeTemplateMappingInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public int modeIndex;

		internal bool _003CGameModeIndexAndTeamNumToTemplate_003Eb__0(CustomModeTemplateMappingInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public int modeIndex;

		internal bool _003CGetModeIndexTemplateMappingInfo_003Eb__0(CustomModeTemplateMappingInfo info)
		{
			return false;
		}
	}

	public static readonly uint ModeTemplateTotalSwitchId;

	public static ModeVariables CustomModeVariables;

	public static ModeVariables ClassicModeVariables;

	public static bool IsCustomModeActivated;

	public static Dictionary<int, UGCCustomModeTemplateRuleData> CustomModeTemplateRules;

	public static List<CustomModeTemplateMappingInfo> CustomModeTemplateMapping;

	public static ModeVariable RPNCal(List<string> elements, List<ModeVariable> modeVariables)
	{
		return null;
	}

	public static int GetTemplateIDFromSlotInfo(SceneEditSlotInfo slotInfo)
	{
		return 0;
	}

	public static void GetRoundAndBattleStyleAndModeName(SceneEditSlotInfo slotInfo, out string round, out string battleStyle, out string modeName)
	{
		round = null;
		battleStyle = null;
		modeName = null;
	}

	public static int GetMinNumOfMatchStart(SceneEditSlotInfo slotInfo)
	{
		return 0;
	}

	public static bool IsFPPResourceNecessary(CLMPMGMIDGD modeSetting, uint gameMode)
	{
		return false;
	}

	public static APELAOJEDNI GetUGCCommonCustomModeSetting(SceneEditSlotInfo slotInfo)
	{
		return null;
	}

	public static uint GetModeFromModeWithTemplate(uint modeWithTemplate)
	{
		return 0u;
	}

	public static uint GetTemplateFromModeWithTemplate(uint modeWithTemplate)
	{
		return 0u;
	}

	public static uint MakeModeWithTemplate(uint mode, uint template)
	{
		return 0u;
	}

	public static bool IsFullCustom(uint code)
	{
		return false;
	}

	public static int TemplateToGameModeIndex(int code)
	{
		return 0;
	}

	public static int GameModeIndexAndTeamNumToTemplate(int modeIndex, int teamNum)
	{
		return 0;
	}

	public static CustomModeTemplateMappingInfo GetModeIndexTemplateMappingInfo(int modeIndex)
	{
		return null;
	}

	public static int FallbackIfTemplateIndexIsForbidden(int modeIndex)
	{
		return 0;
	}

	public static bool FallbackIfMultiTeamsIsForbidden(int modeIndex)
	{
		return false;
	}

	public static Dictionary<int, UGCCustomModeTemplateRuleData> TryLoadCustomModeRuleDataIfNeed(bool force = false)
	{
		return null;
	}

	private static void BuildCustomModeForbiddenInfo(List<UGCCustomModeTemplateRuleData> data)
	{
	}

	public static IModeEditComponentData BuildComponent(UIModeEditData.EditDataContext context, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static ModeVariableBinding BuildBool(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static bool BuildBool(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return false;
	}

	public static ModeVariableBinding BuildInt(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static ModeVariableBinding BuildInt(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static int BuildIntInternal(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return 0;
	}

	public static ModeVariableBinding BuildFloat(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static ModeVariableBinding BuildVector3(ModeVariables contextVariables, JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static string BuildString(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static JsonData BuildObject(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static JsonData BuildArray(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static bool BuildIntArray(JsonData jsonData, string key, List<int> arrayToBuild, bool allowEmpty = true)
	{
		return false;
	}

	public static bool BuildArray(ModeVariables contextVariables, JsonData jsonData, string key, List<ModeVariableBinding> arrayToBuild, ModeVariable.VariableType type, bool allowEmpty = true)
	{
		return false;
	}

	public static ModeVariableBinding BuildBinding(ModeVariables contextVariables, JsonData jsonData)
	{
		return null;
	}

	public static IDefalutVariableInternalRule BuildVariableInternalRule(JsonData jsonData)
	{
		return null;
	}

	public static IModeVariableBindingModifier BuildBindingModifier(ModeVariables contextVariables, JsonData jsonData, bool allowEmpty = true)
	{
		return null;
	}

	public static ModeVariable BuildVariable(JsonData jsonData)
	{
		return null;
	}

	public static JsonData CheckData(JsonData jsonData, string key, bool allowEmpty = true)
	{
		return null;
	}

	public static void LogErrorMissingField(string fieldName)
	{
	}

	public static void LogErrorWrongType(string fieldName, JsonType type)
	{
	}

	public static void LogErrorDataIsNull()
	{
	}
}
