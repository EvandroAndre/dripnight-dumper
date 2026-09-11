using GCommon;

namespace COW;

internal class PartyInteractiveNPCDialogConfigData : CSVBaseData
{
	private uint _003CID_003Ek__BackingField;

	private string _003CContent_003Ek__BackingField;

	private string _003CNextID_003Ek__BackingField;

	private bool _003CIsNPC_003Ek__BackingField;

	public uint ID
	{
		get
		{
			return _003CID_003Ek__BackingField;
		}
		private set
		{
			_003CID_003Ek__BackingField = value;
		}
	}

	public string Content
	{
		get
		{
			return _003CContent_003Ek__BackingField;
		}
		private set
		{
			_003CContent_003Ek__BackingField = value;
		}
	}

	public string NextID
	{
		get
		{
			return _003CNextID_003Ek__BackingField;
		}
		private set
		{
			_003CNextID_003Ek__BackingField = value;
		}
	}

	public bool IsNPC
	{
		get
		{
			return _003CIsNPC_003Ek__BackingField;
		}
		private set
		{
			_003CIsNPC_003Ek__BackingField = value;
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
