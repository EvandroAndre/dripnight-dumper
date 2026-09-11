using System.Collections.Generic;
using LitJson;
using message;

namespace COW;

public class ModeVariables
{
	public enum ClassicGameModeIndex
	{
		CS,
		TDM,
		Party
	}

	public enum CustomModeTemplateIndex
	{
		Annihilate = 0,
		Score = 1,
		Racing = 2,
		FullCustom = 3,
		PVE_LEVEL = 4,
		PVE_DEFENCE = 5,
		Cat = 6,
		Total = 999
	}

	public enum SpecialCustomMode
	{
		Infection
	}

	public const int DefaultTeamNum = 2;

	public const int DefaultTeamMemberNum = 4;

	public const int ModeTemplateID = 1;

	public const int TeamNumID = 6;

	public const int TeamMemberNumID = 7;

	public const int FULL_CUSTOM_ROUND_NUM_ID = 8;

	public const int FULL_CUSTOM_ROUND_PREPARE_TIME_ID = 29;

	public const int FULL_CUSTOM_ROUND_TIME_ID = 9;

	public const int FULL_CUSTOM_ENABLE_MULTI_ROUND_ID = 27;

	public const int MIN_SPAWN_NUM_ID = 105;

	public const int CAT_HIDE_TIME_ID = 83;

	public const int MorphModeDisableTemplate = 134;

	public const int RecommendStartGameNumber = 135;

	public const int EnableHalfWayJoin = 136;

	public const int HalfWayJoinEffectTime = 137;

	public const int HalfWayJoinNumberLimit = 138;

	public const int HalfWayJoinNumber = 139;

	public const int EnableHalfWayJoinEffectTime = 140;

	public const int DisableDepthMap = 154;

	public const int EnableQuickStartMatch = 175;

	public const int MinNumOfMatchStar = 82;

	public const int GameStartTime = 188;

	public const int GamePrepareTime = 189;

	public const int EnableSocialFriendList = 200;

	public const int EnableSocialDialogBox = 201;

	public const int EnableSocialPlayerDetail = 202;

	private Dictionary<string, ModeVariable> m_Variables;

	private Dictionary<int, ModeVariable> m_VariablesById;

	private APELAOJEDNI m_CustomModeDataCache;

	public int CurrentCustomModeTemplateIndexInBuildingData;

	public bool IsEmpty()
	{
		return false;
	}

	public bool FromJsonData(JsonData jsonData)
	{
		return false;
	}

	public CLMPMGMIDGD ToProtoData()
	{
		return null;
	}

	private IDNGJCFGGAL ToCSModeProtoData()
	{
		return null;
	}

	private JEFMBPEEDGA ToIntegralModeProtoData()
	{
		return null;
	}

	private NIGOENPDEDM ToPartyModeProtoData()
	{
		return null;
	}

	private DLGJOMMMGPI ToGeneralProtoData()
	{
		return null;
	}

	private APELAOJEDNI ToCustomModeProtoData()
	{
		return null;
	}

	private void LogVariable(ModeVariable variable, bool logAllValues = false)
	{
	}

	public bool FromProtoData(CLMPMGMIDGD protoData)
	{
		return false;
	}

	private void CompatiblePublicVersion()
	{
	}

	public bool FromCSModeProtoData(IDNGJCFGGAL protoData, uint groupMode)
	{
		return false;
	}

	public bool FromIntegralModeProtoData(JEFMBPEEDGA protoData, uint groupMode)
	{
		return false;
	}

	public bool FromPartyModeProtoData(NIGOENPDEDM protoData, uint groupMode)
	{
		return false;
	}

	public bool FromGeneralProtoData(DLGJOMMMGPI protoData)
	{
		return false;
	}

	public bool FromCustomModeProtoData(uint mapID, APELAOJEDNI protoData, uint templateID)
	{
		return false;
	}

	private void SetVariableValueFromCustomModeProtoData(ModeVariable variable, LJICFKFGFHL protoVar)
	{
	}

	public ModeVariable GetVariable(string name, bool needLog = true)
	{
		return null;
	}

	public void CopyFrom(ModeVariables variables)
	{
	}

	public uint GetGameMode()
	{
		return 0u;
	}

	public void SetGameModeWithTemplate(uint mode, uint template)
	{
	}

	public uint GetGroupMode()
	{
		return 0u;
	}

	public uint GetTeamMemberCount()
	{
		return 0u;
	}

	public uint GetTeamCount()
	{
		return 0u;
	}

	public uint GetUGCSocialFlag()
	{
		return 0u;
	}

	public int GetRecommendStartGameNumber()
	{
		return 0;
	}

	public bool GetEnableHalfWayJoin()
	{
		return false;
	}

	public bool GetEnableHalfWayJoinEffectTime()
	{
		return false;
	}

	public int GetHalfWayJoinEffectTime()
	{
		return 0;
	}

	public bool GetHalfWayJoinNumberLimit()
	{
		return false;
	}

	public int GetHalfWayJoinNumber()
	{
		return 0;
	}

	public uint GetUGCModeTemplate()
	{
		return 0u;
	}

	public bool GetCustomModeTemplateIndexEnabled()
	{
		return false;
	}

	public bool GetCustomModeTeamNumSelectable()
	{
		return false;
	}

	public ModeVariable GetVariableById(int id)
	{
		return null;
	}

	public void Save()
	{
	}

	public void SaveMeta()
	{
	}

	public void ResetToDefault()
	{
	}

	public void ResetToSaved()
	{
	}

	public bool CheckIsChanged()
	{
		return false;
	}
}
