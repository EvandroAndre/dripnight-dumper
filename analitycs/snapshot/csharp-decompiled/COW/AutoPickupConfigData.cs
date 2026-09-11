using System;
using GCommon;

namespace COW;

public class AutoPickupConfigData : CSVBaseData, IComparable
{
	public int Id;

	public uint[] ItemTypes;

	public uint[] SubTypes;

	public int[] MenuType;

	public uint ItemId;

	public string LocKey;

	public bool IsDefaultOpen;

	public int InitialOrder;

	public int InitialNum;

	public int PickupMin;

	public int PickupMax;

	public int PickupUnit;

	private int _003CParentID_003Ek__BackingField;

	private int _003CParentOrder_003Ek__BackingField;

	private string primaryKey;

	private string m_NewKey;

	private string m_PlayerPrefOrderKey;

	private string m_PlayerPrefPickupNumKey;

	private int _003CStateValue_003Ek__BackingField;

	private int _003COrder_003Ek__BackingField;

	private int _003CPickupNum_003Ek__BackingField;

	public int ParentID
	{
		get
		{
			return _003CParentID_003Ek__BackingField;
		}
		private set
		{
			_003CParentID_003Ek__BackingField = value;
		}
	}

	public int ParentOrder
	{
		get
		{
			return _003CParentOrder_003Ek__BackingField;
		}
		private set
		{
			_003CParentOrder_003Ek__BackingField = value;
		}
	}

	public int StateValue
	{
		get
		{
			return _003CStateValue_003Ek__BackingField;
		}
		private set
		{
			_003CStateValue_003Ek__BackingField = value;
		}
	}

	public int Order
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

	public int PickupNum
	{
		get
		{
			return _003CPickupNum_003Ek__BackingField;
		}
		private set
		{
			_003CPickupNum_003Ek__BackingField = value;
		}
	}

	public bool HasNoParent => false;

	public override bool AfterParseData()
	{
		return false;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public string GetNewKey()
	{
		return null;
	}

	public void RefreshKeyState()
	{
	}

	public void SetParent(AutoPickupConfigData parent)
	{
	}

	public void SetPickupItemState(EAutoPickup open)
	{
	}

	public void SetPickupSpeedState(EAutoPickupSpeed speed)
	{
	}

	public void SetPickupStateValue(int value)
	{
	}

	public void SetPickupItemPriority(int priority)
	{
	}

	public void SetPickupItemNum(int pickupNum)
	{
	}

	public void ResetPickupItemPreference()
	{
	}

	public bool CanAutoPickUp()
	{
		return false;
	}

	public bool IsPickupSpeedConfig()
	{
		return false;
	}

	public bool ContainMenuItems()
	{
		return false;
	}

	public bool IsPickupNumAvailable()
	{
		return false;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
