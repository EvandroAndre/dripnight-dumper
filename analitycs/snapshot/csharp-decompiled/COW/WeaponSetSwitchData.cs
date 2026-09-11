using GCommon;

namespace COW;

public class WeaponSetSwitchData : CSVBaseData
{
	private uint _003CweaponSetID_003Ek__BackingField;

	private int _003CprevWeaponSetID_003Ek__BackingField;

	public uint weaponSetID
	{
		get
		{
			return _003CweaponSetID_003Ek__BackingField;
		}
		private set
		{
			_003CweaponSetID_003Ek__BackingField = value;
		}
	}

	public int prevWeaponSetID
	{
		get
		{
			return _003CprevWeaponSetID_003Ek__BackingField;
		}
		private set
		{
			_003CprevWeaponSetID_003Ek__BackingField = value;
		}
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	private int ReadPrevWeaponSetID(string regions, string[] headers, string[] values)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
