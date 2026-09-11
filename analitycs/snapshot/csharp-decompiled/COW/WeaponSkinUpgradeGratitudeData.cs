using GCommon;

namespace COW;

public class WeaponSkinUpgradeGratitudeData : CSVBaseData
{
	private uint _003CWeaponSet2_003Ek__BackingField;

	private uint _003CWeaponSet1_003Ek__BackingField;

	private int _003CWeaponSet1Level_003Ek__BackingField;

	private uint _003CItem_003Ek__BackingField;

	private uint _003CNum_003Ek__BackingField;

	public uint WeaponSet2
	{
		get
		{
			return _003CWeaponSet2_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponSet2_003Ek__BackingField = value;
		}
	}

	public uint WeaponSet1
	{
		get
		{
			return _003CWeaponSet1_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponSet1_003Ek__BackingField = value;
		}
	}

	public int WeaponSet1Level
	{
		get
		{
			return _003CWeaponSet1Level_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponSet1Level_003Ek__BackingField = value;
		}
	}

	public uint Item
	{
		get
		{
			return _003CItem_003Ek__BackingField;
		}
		private set
		{
			_003CItem_003Ek__BackingField = value;
		}
	}

	public uint Num
	{
		get
		{
			return _003CNum_003Ek__BackingField;
		}
		private set
		{
			_003CNum_003Ek__BackingField = value;
		}
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
