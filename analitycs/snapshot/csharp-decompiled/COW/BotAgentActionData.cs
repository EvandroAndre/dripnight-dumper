using System.Collections.Generic;
using COW.GamePlay;
using proto;

namespace COW;

public class BotAgentActionData
{
	public uint ID;

	public string Action;

	public EBotAgentTriggerType TriggerType;

	public List<uint> MatchModes;

	public List<uint> GameModes;

	public List<uint> GroupModes;

	public bool TriggerOnce;

	public bool TriggerInBattle;

	public uint TriggerAboveMemoryLevel;

	public string CD;

	public uint Type;

	public uint Priority;

	public EBotAgentActionSource Source;

	public KLDGLAFFLNJ UI;

	public EBotAgentConfigSource ConfigSource;

	public List<string> Params;

	public List<BotAgentActionSourceData> Sources;

	public BotAgentActionSourceData RollSource;

	public bool HasRandomSourceData()
	{
		return false;
	}

	public bool IsSourceEmpty()
	{
		return false;
	}

	public bool IsValidForGameInfo(uint matchMode, uint gameMode, uint groupMode)
	{
		return false;
	}

	public static implicit operator BotAgentActionData(BotAgentECADesc desc)
	{
		return null;
	}

	public int IsUserLevelCDValid()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
