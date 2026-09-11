using GCommon;

namespace COW;

public class ArenaNPCSuitData : CSVBaseData
{
	private uint _003CID_003Ek__BackingField;

	private uint _003CHeadSlotItemID_003Ek__BackingField;

	private uint _003CChestSlotItemID_003Ek__BackingField;

	private uint _003CLegsSlotItemID_003Ek__BackingField;

	private uint _003CFeetSlotItemID_003Ek__BackingField;

	private uint _003CAvatarID_003Ek__BackingField;

	private ResourceID _003CAnimatorID_003Ek__BackingField;

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

	public uint HeadSlotItemID
	{
		get
		{
			return _003CHeadSlotItemID_003Ek__BackingField;
		}
		private set
		{
			_003CHeadSlotItemID_003Ek__BackingField = value;
		}
	}

	public uint ChestSlotItemID
	{
		get
		{
			return _003CChestSlotItemID_003Ek__BackingField;
		}
		private set
		{
			_003CChestSlotItemID_003Ek__BackingField = value;
		}
	}

	public uint LegsSlotItemID
	{
		get
		{
			return _003CLegsSlotItemID_003Ek__BackingField;
		}
		private set
		{
			_003CLegsSlotItemID_003Ek__BackingField = value;
		}
	}

	public uint FeetSlotItemID
	{
		get
		{
			return _003CFeetSlotItemID_003Ek__BackingField;
		}
		private set
		{
			_003CFeetSlotItemID_003Ek__BackingField = value;
		}
	}

	public uint AvatarID
	{
		get
		{
			return _003CAvatarID_003Ek__BackingField;
		}
		private set
		{
			_003CAvatarID_003Ek__BackingField = value;
		}
	}

	public ResourceID AnimatorID
	{
		get
		{
			return _003CAnimatorID_003Ek__BackingField;
		}
		private set
		{
			_003CAnimatorID_003Ek__BackingField = value;
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
