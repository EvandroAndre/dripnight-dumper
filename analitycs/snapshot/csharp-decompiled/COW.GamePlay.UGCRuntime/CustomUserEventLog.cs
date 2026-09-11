using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class CustomUserEventLog : UGCEventLogBase
{
	private ulong _003CAccountID_003Ek__BackingField;

	private ulong _003CMatchID_003Ek__BackingField;

	private string _003CRegion_003Ek__BackingField;

	private string _003CWorkshopCode_003Ek__BackingField;

	private int _003CGameMode_003Ek__BackingField;

	private int _003CCustomGameMode_003Ek__BackingField;

	private int _003CMatchMode_003Ek__BackingField;

	private int _003CGroupMode_003Ek__BackingField;

	private int _003CMapID_003Ek__BackingField;

	private int _003CRoundID_003Ek__BackingField;

	private List<string> _003CCustomKeys_003Ek__BackingField;

	private List<object> _003CCustomValues_003Ek__BackingField;

	public ulong AccountID
	{
		get
		{
			return _003CAccountID_003Ek__BackingField;
		}
		set
		{
			_003CAccountID_003Ek__BackingField = value;
		}
	}

	public ulong MatchID
	{
		get
		{
			return _003CMatchID_003Ek__BackingField;
		}
		set
		{
			_003CMatchID_003Ek__BackingField = value;
		}
	}

	public string Region
	{
		get
		{
			return _003CRegion_003Ek__BackingField;
		}
		set
		{
			_003CRegion_003Ek__BackingField = value;
		}
	}

	public string WorkshopCode
	{
		get
		{
			return _003CWorkshopCode_003Ek__BackingField;
		}
		set
		{
			_003CWorkshopCode_003Ek__BackingField = value;
		}
	}

	public int GameMode
	{
		get
		{
			return _003CGameMode_003Ek__BackingField;
		}
		set
		{
			_003CGameMode_003Ek__BackingField = value;
		}
	}

	public int CustomGameMode
	{
		get
		{
			return _003CCustomGameMode_003Ek__BackingField;
		}
		set
		{
			_003CCustomGameMode_003Ek__BackingField = value;
		}
	}

	public int MatchMode
	{
		get
		{
			return _003CMatchMode_003Ek__BackingField;
		}
		set
		{
			_003CMatchMode_003Ek__BackingField = value;
		}
	}

	public int GroupMode
	{
		get
		{
			return _003CGroupMode_003Ek__BackingField;
		}
		set
		{
			_003CGroupMode_003Ek__BackingField = value;
		}
	}

	public int MapID
	{
		get
		{
			return _003CMapID_003Ek__BackingField;
		}
		set
		{
			_003CMapID_003Ek__BackingField = value;
		}
	}

	public int RoundID
	{
		get
		{
			return _003CRoundID_003Ek__BackingField;
		}
		set
		{
			_003CRoundID_003Ek__BackingField = value;
		}
	}

	public List<string> CustomKeys
	{
		get
		{
			return _003CCustomKeys_003Ek__BackingField;
		}
		set
		{
			_003CCustomKeys_003Ek__BackingField = value;
		}
	}

	public List<object> CustomValues
	{
		get
		{
			return _003CCustomValues_003Ek__BackingField;
		}
		set
		{
			_003CCustomValues_003Ek__BackingField = value;
		}
	}
}
