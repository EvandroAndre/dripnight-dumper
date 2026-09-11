using GCommon;
using proto;

namespace COW;

public class AwardItemInfo : BaseItemInfo
{
	private EInventory.AwardType _003CAward_Type_003Ek__BackingField;

	private uint _003CAward_Max_Num_003Ek__BackingField;

	public EInventory.AwardType Award_Type
	{
		get
		{
			return _003CAward_Type_003Ek__BackingField;
		}
		private set
		{
			_003CAward_Type_003Ek__BackingField = value;
		}
	}

	public uint Award_ID
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public uint Award_Num
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public uint Award_Max_Num
	{
		get
		{
			return _003CAward_Max_Num_003Ek__BackingField;
		}
		private set
		{
			_003CAward_Max_Num_003Ek__BackingField = value;
		}
	}

	public ResourceID Award_Item_IconRes
	{
		get
		{
			return default(ResourceID);
		}
		private set
		{
		}
	}

	public string Award_Item_Name
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public int Award_Item_Type
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public uint Award_Expire_Time
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public AwardItemInfo()
		: base(EInventory.AwardType.AwardType_NONE, 0u)
	{
	}

	public static implicit operator AwardItemInfo(AwardDesc item)
	{
		return null;
	}

	private static void FindIcon(AwardItemInfo info)
	{
	}
}
