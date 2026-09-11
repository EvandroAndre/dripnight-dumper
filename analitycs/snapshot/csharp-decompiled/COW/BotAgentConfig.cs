using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class BotAgentConfig : SingletonModule<BotAgentConfig>
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public string localLang;

		public Predicate<BotAgentPromptDesc> _003C_003E9__1;

		internal bool _003CProcessBotAgentECAList_003Eb__1(BotAgentPromptDesc d)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public BotAgentECADesc action;

		internal bool _003CProcessBotAgentECAList_003Eb__0(BotAgentPromptDesc e)
		{
			return false;
		}
	}

	private const uint CS_ID_OFFSET = 10000000u;

	private static readonly HashSet<uint> CS_IVALID_GAME_MODES;

	private static readonly HashSet<uint> BR_IVALID_GAME_MODES;

	private bool m_HasDataGot;

	private Dictionary<uint, BotAgentActionData> m_AutoActionDataDic;

	private Dictionary<uint, BotAgentActionData> m_ManualActionDataDic;

	private Dictionary<uint, BotAgentActionData> m_DragActionDataDic;

	private HashSet<uint> m_ValidInMatch;

	private HashSet<uint> m_ValidInBRMatch;

	private HashSet<uint> m_ValidInCSMatch;

	private EBotAgentActionSource m_ForceSourceType;

	private const string BOTAGENT_SEND_ACCOUNT_IDS = "BOTAGENT_SEND_ACCOUNT_IDS";

	private const string BOTAGENT_SEND_ACCOUNT_TIMES = "BOTAGENT_SEND_ACCOUNT_TIMES";

	private const string BOTAGENT_ACTION_TRIGGERED = "BOTAGENT_ACTION_TRIGGERED";

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void RequestBotAgentData()
	{
	}

	private void ClearDicData()
	{
	}

	private void ProcessBotAgentData(CSAIBotAgentDescRes res)
	{
	}

	private List<BotAgentECADesc> ConvertCSECAListToBR(List<CSBotAgentECADesc> csEcaList)
	{
		return null;
	}

	private List<BotAgentPromptDesc> ConvertCSPromptListToBR(List<CSBotAgentPromptDesc> csPromptList)
	{
		return null;
	}

	private void ProcessBotAgentECAList(List<BotAgentECADesc> ecaList, List<BotAgentPromptDesc> promptList, string localLang, uint memoryLevel, EBotAgentConfigSource configSource, uint idOffset = 0u)
	{
	}

	private bool ValidateIDRange(uint originalID, EBotAgentConfigSource configSource)
	{
		return false;
	}

	private bool ValidateCDNUrlFormat(string cdnUrl, uint configID, string action, out string localizedUrl, string localLang)
	{
		localizedUrl = null;
		return false;
	}

	private bool ValidateConfigForModeType(BotAgentActionData data, EBotAgentConfigSource configSource)
	{
		return false;
	}

	private void CalValidInMatch()
	{
	}

	private bool IsValidForSourceData(BotAgentPromptDesc sourceData, EBotAgentActionSource sourceType)
	{
		return false;
	}

	public bool IsValidInMatch(uint matchMode, uint gameMode, uint groupMode)
	{
		return false;
	}

	private uint MakeMatchKey(uint matchMode, uint gameMode, uint groupMode)
	{
		return 0u;
	}

	public uint GetUserType()
	{
		return 0u;
	}

	public bool IsBotAgentSettingUIEnabled(bool isInGame)
	{
		return false;
	}

	public bool IsBotAgentSettingUIEnabledBR(bool isInGame)
	{
		return false;
	}

	public bool IsBotAgentSettingUIEnabledCS(bool isInGame)
	{
		return false;
	}

	public bool IsBotAgentEnabledBySys()
	{
		return false;
	}

	public bool IsBotAgentDataValid()
	{
		return false;
	}

	public bool IsBotAgentDataValidBR()
	{
		return false;
	}

	public bool IsBotAgentDataValidCS()
	{
		return false;
	}

	public List<BotAgentActionData> GetAllAutoBotAgentDatas(bool filter)
	{
		return null;
	}

	public List<BotAgentActionData> GetAllManualBotAgentDatas()
	{
		return null;
	}

	public List<BotAgentActionData> GetAllDragBotAgentDatas()
	{
		return null;
	}

	public List<BotAgentActionData> GetAllIdleTipBotAgentDatas()
	{
		return null;
	}

	public BotAgentActionData GetActionDataByActionID(uint type)
	{
		return null;
	}

	private void CheckAndSendEventLogPerDay()
	{
	}

	public bool HasAccountTriggered(uint actionID)
	{
		return false;
	}

	public void SetAccountTriggered(uint actionID)
	{
	}

	public void OnUserLevelUp(uint newLevel)
	{
	}

	private List<BotAgentECADesc> ProcessTestCSECAData()
	{
		return null;
	}

	private List<BotAgentPromptDesc> ProcessTestCSECAPrompt()
	{
		return null;
	}

	private void _003CRequestBotAgentData_003Eb__13_0(HttpErrorCode errorCode, object res)
	{
	}
}
