using GCommon;

namespace COW;

internal class PartyNPCDialogConfigData : CSVBaseData
{
	private uint _003CGroupID_003Ek__BackingField;

	private uint _003CCharID_003Ek__BackingField;

	private string _003CCharDialog_003Ek__BackingField;

	private uint _003COrder_003Ek__BackingField;

	public uint GroupID
	{
		get
		{
			return _003CGroupID_003Ek__BackingField;
		}
		private set
		{
			_003CGroupID_003Ek__BackingField = value;
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

	public string CharDialog
	{
		get
		{
			return _003CCharDialog_003Ek__BackingField;
		}
		private set
		{
			_003CCharDialog_003Ek__BackingField = value;
		}
	}

	public uint Order
	{
		get
		{
			return _003COrder_003Ek__BackingField;
		}
		private set
		{
			_003COrder_003Ek__BackingField = value;
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
