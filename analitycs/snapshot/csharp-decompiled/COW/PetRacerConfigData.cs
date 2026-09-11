using GCommon;

namespace COW;

internal class PetRacerConfigData : CSVBaseData
{
	private uint _003CPetID_003Ek__BackingField;

	private string _003CPetName_003Ek__BackingField;

	private ResourceID _003CPetIngamePrafab_003Ek__BackingField;

	private string _003CIdleAnim_003Ek__BackingField;

	private string _003CRunAnim_003Ek__BackingField;

	private string _003CFalldownAnim_003Ek__BackingField;

	private string _003CIdleSprite_003Ek__BackingField;

	private string _003CRunSprite_003Ek__BackingField;

	private ResourceID _003CIndicatorPrefab_003Ek__BackingField;

	public uint PetID
	{
		get
		{
			return _003CPetID_003Ek__BackingField;
		}
		private set
		{
			_003CPetID_003Ek__BackingField = value;
		}
	}

	public string PetName
	{
		get
		{
			return _003CPetName_003Ek__BackingField;
		}
		private set
		{
			_003CPetName_003Ek__BackingField = value;
		}
	}

	public ResourceID PetIngamePrafab
	{
		get
		{
			return _003CPetIngamePrafab_003Ek__BackingField;
		}
		private set
		{
			_003CPetIngamePrafab_003Ek__BackingField = value;
		}
	}

	public string IdleAnim
	{
		get
		{
			return _003CIdleAnim_003Ek__BackingField;
		}
		private set
		{
			_003CIdleAnim_003Ek__BackingField = value;
		}
	}

	public string RunAnim
	{
		get
		{
			return _003CRunAnim_003Ek__BackingField;
		}
		private set
		{
			_003CRunAnim_003Ek__BackingField = value;
		}
	}

	public string FalldownAnim
	{
		get
		{
			return _003CFalldownAnim_003Ek__BackingField;
		}
		private set
		{
			_003CFalldownAnim_003Ek__BackingField = value;
		}
	}

	public string IdleSprite
	{
		get
		{
			return _003CIdleSprite_003Ek__BackingField;
		}
		private set
		{
			_003CIdleSprite_003Ek__BackingField = value;
		}
	}

	public string RunSprite
	{
		get
		{
			return _003CRunSprite_003Ek__BackingField;
		}
		private set
		{
			_003CRunSprite_003Ek__BackingField = value;
		}
	}

	public ResourceID IndicatorPrefab
	{
		get
		{
			return _003CIndicatorPrefab_003Ek__BackingField;
		}
		private set
		{
			_003CIndicatorPrefab_003Ek__BackingField = value;
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
