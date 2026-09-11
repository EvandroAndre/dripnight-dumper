using GCommon;

namespace COW;

internal class GameFunctionSwitchData : CSVBaseData
{
	private FunctionType m_FunctionType;

	private FunctionType _003CFunctionType_003Ek__BackingField;

	private string m_FunctionName;

	private string _003CFunctionName_003Ek__BackingField;

	private int m_LevelLimit;

	private int _003CLevelLimit_003Ek__BackingField;

	private bool m_IsOpen;

	private bool _003CIsOpen_003Ek__BackingField;

	public FunctionType FunctionType
	{
		get
		{
			return _003CFunctionType_003Ek__BackingField;
		}
		private set
		{
			_003CFunctionType_003Ek__BackingField = value;
		}
	}

	public string FunctionName
	{
		get
		{
			return _003CFunctionName_003Ek__BackingField;
		}
		private set
		{
			_003CFunctionName_003Ek__BackingField = value;
		}
	}

	public int LevelLimit
	{
		get
		{
			return _003CLevelLimit_003Ek__BackingField;
		}
		set
		{
			_003CLevelLimit_003Ek__BackingField = value;
		}
	}

	public bool IsOpen
	{
		get
		{
			return _003CIsOpen_003Ek__BackingField;
		}
		private set
		{
			_003CIsOpen_003Ek__BackingField = value;
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
