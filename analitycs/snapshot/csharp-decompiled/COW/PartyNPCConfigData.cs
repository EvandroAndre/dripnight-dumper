using GCommon;

namespace COW;

internal class PartyNPCConfigData : CSVBaseData
{
	private uint _003CNPCID_003Ek__BackingField;

	private uint _003CCharID_003Ek__BackingField;

	private string _003CCharName_003Ek__BackingField;

	private uint _003CCharSuit_003Ek__BackingField;

	private ResourceID _003CActionID_003Ek__BackingField;

	private bool _003CIsInteractive_003Ek__BackingField;

	private uint _003CDialogID_003Ek__BackingField;

	public uint NPCID
	{
		get
		{
			return _003CNPCID_003Ek__BackingField;
		}
		private set
		{
			_003CNPCID_003Ek__BackingField = value;
		}
	}

	public uint CharID
	{
		get
		{
			return _003CCharID_003Ek__BackingField;
		}
		private set
		{
			_003CCharID_003Ek__BackingField = value;
		}
	}

	public string CharName
	{
		get
		{
			return _003CCharName_003Ek__BackingField;
		}
		private set
		{
			_003CCharName_003Ek__BackingField = value;
		}
	}

	public uint CharSuit
	{
		get
		{
			return _003CCharSuit_003Ek__BackingField;
		}
		private set
		{
			_003CCharSuit_003Ek__BackingField = value;
		}
	}

	public ResourceID ActionID
	{
		get
		{
			return _003CActionID_003Ek__BackingField;
		}
		private set
		{
			_003CActionID_003Ek__BackingField = value;
		}
	}

	public bool IsInteractive
	{
		get
		{
			return _003CIsInteractive_003Ek__BackingField;
		}
		private set
		{
			_003CIsInteractive_003Ek__BackingField = value;
		}
	}

	public uint DialogID
	{
		get
		{
			return _003CDialogID_003Ek__BackingField;
		}
		private set
		{
			_003CDialogID_003Ek__BackingField = value;
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static PartyNPCConfigData GetDataByCharID(uint charID)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
