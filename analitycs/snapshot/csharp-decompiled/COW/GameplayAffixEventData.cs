using proto;

namespace COW;

public class GameplayAffixEventData
{
	private ulong _003CStartTime_003Ek__BackingField;

	private ulong _003CEndTime_003Ek__BackingField;

	private uint[] _003CLobbyDisplayAffixes_003Ek__BackingField;

	private uint _003CEventOpenId_003Ek__BackingField;

	public ulong StartTime
	{
		get
		{
			return _003CStartTime_003Ek__BackingField;
		}
		private set
		{
			_003CStartTime_003Ek__BackingField = value;
		}
	}

	public ulong EndTime
	{
		get
		{
			return _003CEndTime_003Ek__BackingField;
		}
		private set
		{
			_003CEndTime_003Ek__BackingField = value;
		}
	}

	public uint[] LobbyDisplayAffixes
	{
		get
		{
			return _003CLobbyDisplayAffixes_003Ek__BackingField;
		}
		private set
		{
			_003CLobbyDisplayAffixes_003Ek__BackingField = value;
		}
	}

	public uint EventOpenId
	{
		get
		{
			return _003CEventOpenId_003Ek__BackingField;
		}
		private set
		{
			_003CEventOpenId_003Ek__BackingField = value;
		}
	}

	public GameplayAffixEventData(GameplayAffixDesc desc)
	{
	}

	public static int SortByStartTime(GameplayAffixEventData eventDataA, GameplayAffixEventData eventDataB)
	{
		return 0;
	}
}
