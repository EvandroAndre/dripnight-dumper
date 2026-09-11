using GCommon;

namespace COW;

public class FoldWingConfigData : CSVBaseData, IGetId
{
	private uint _003CItemID_003Ek__BackingField;

	private float _003CMinFlyHeight_003Ek__BackingField;

	private float _003CMinEndHeight_003Ek__BackingField;

	private float _003CFlySpeedHorizontal_003Ek__BackingField;

	private float _003CFlySpeedVertical_003Ek__BackingField;

	private float _003CFallSpeed_003Ek__BackingField;

	private float _003CTurnSpeed_003Ek__BackingField;

	private float _003CFlyMaxHeight_003Ek__BackingField;

	private float _003COverheightFallSpeed_003Ek__BackingField;

	private float _003CAcceleratedSpeed_003Ek__BackingField;

	private bool _003CCanAimassist_003Ek__BackingField;

	public uint ItemID
	{
		get
		{
			return _003CItemID_003Ek__BackingField;
		}
		private set
		{
			_003CItemID_003Ek__BackingField = value;
		}
	}

	public float MinFlyHeight
	{
		get
		{
			return _003CMinFlyHeight_003Ek__BackingField;
		}
		set
		{
			_003CMinFlyHeight_003Ek__BackingField = value;
		}
	}

	public float MinEndHeight
	{
		get
		{
			return _003CMinEndHeight_003Ek__BackingField;
		}
		set
		{
			_003CMinEndHeight_003Ek__BackingField = value;
		}
	}

	public float FlySpeedHorizontal
	{
		get
		{
			return _003CFlySpeedHorizontal_003Ek__BackingField;
		}
		set
		{
			_003CFlySpeedHorizontal_003Ek__BackingField = value;
		}
	}

	public float FlySpeedVertical
	{
		get
		{
			return _003CFlySpeedVertical_003Ek__BackingField;
		}
		set
		{
			_003CFlySpeedVertical_003Ek__BackingField = value;
		}
	}

	public float FallSpeed
	{
		get
		{
			return _003CFallSpeed_003Ek__BackingField;
		}
		set
		{
			_003CFallSpeed_003Ek__BackingField = value;
		}
	}

	public float TurnSpeed
	{
		get
		{
			return _003CTurnSpeed_003Ek__BackingField;
		}
		set
		{
			_003CTurnSpeed_003Ek__BackingField = value;
		}
	}

	public float FlyMaxHeight
	{
		get
		{
			return _003CFlyMaxHeight_003Ek__BackingField;
		}
		set
		{
			_003CFlyMaxHeight_003Ek__BackingField = value;
		}
	}

	public float OverheightFallSpeed
	{
		get
		{
			return _003COverheightFallSpeed_003Ek__BackingField;
		}
		set
		{
			_003COverheightFallSpeed_003Ek__BackingField = value;
		}
	}

	public float AcceleratedSpeed
	{
		get
		{
			return _003CAcceleratedSpeed_003Ek__BackingField;
		}
		set
		{
			_003CAcceleratedSpeed_003Ek__BackingField = value;
		}
	}

	public bool CanAimassist
	{
		get
		{
			return _003CCanAimassist_003Ek__BackingField;
		}
		private set
		{
			_003CCanAimassist_003Ek__BackingField = value;
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public FoldWingConfigData Clone()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
