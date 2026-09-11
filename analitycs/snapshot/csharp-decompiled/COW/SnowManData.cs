using GCommon;

namespace COW;

public class SnowManData : CSVBaseData
{
	private uint _003CLevel_003Ek__BackingField;

	private uint[] _003CClothIDs_003Ek__BackingField;

	public uint Level
	{
		get
		{
			return _003CLevel_003Ek__BackingField;
		}
		set
		{
			_003CLevel_003Ek__BackingField = value;
		}
	}

	public uint[] ClothIDs
	{
		get
		{
			return _003CClothIDs_003Ek__BackingField;
		}
		set
		{
			_003CClothIDs_003Ek__BackingField = value;
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
