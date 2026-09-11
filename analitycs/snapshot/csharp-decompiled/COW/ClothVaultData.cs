using System;

namespace COW;

public class ClothVaultData : IComparable<ClothVaultData>
{
	private uint _003CLegendId_003Ek__BackingField;

	private bool _003CIsOwned_003Ek__BackingField;

	private EClothVaultType _003CClothVaultType_003Ek__BackingField;

	public uint m_BaseItemId;

	private bool _003CIsNew_003Ek__BackingField;

	public uint LegendId
	{
		get
		{
			return _003CLegendId_003Ek__BackingField;
		}
		private set
		{
			_003CLegendId_003Ek__BackingField = value;
		}
	}

	public bool IsOwned
	{
		get
		{
			return _003CIsOwned_003Ek__BackingField;
		}
		private set
		{
			_003CIsOwned_003Ek__BackingField = value;
		}
	}

	public EClothVaultType ClothVaultType
	{
		get
		{
			return _003CClothVaultType_003Ek__BackingField;
		}
		private set
		{
			_003CClothVaultType_003Ek__BackingField = value;
		}
	}

	public bool IsNew
	{
		get
		{
			return _003CIsNew_003Ek__BackingField;
		}
		private set
		{
			_003CIsNew_003Ek__BackingField = value;
		}
	}

	public ClothVaultData()
	{
	}

	public ClothVaultData(uint legendId, EClothVaultType type, bool isNew = false)
	{
	}

	public int CompareTo(ClothVaultData other)
	{
		return 0;
	}
}
