using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCFoldWingRepItem
{
	public const int PROP_ID_MINFLYHEIGHT = -205000;

	public const int PROP_ID_MINENDHEIGHT = -205001;

	public const int PROP_ID_FLYSPEEDHORIZONTAL = -205002;

	public const int PROP_ID_FLYSPEEDVERTICAL = -205003;

	public const int PROP_ID_FALLSPEED = -205004;

	public const int PROP_ID_TURNSPEED = -205005;

	public const int PROP_ID_FLYMAXHEIGHT = -205006;

	public const int PROP_ID_OVERHEIGHTFALLSPEED = -205007;

	public const int PROP_ID_ACCELERATEDSPEED = -205008;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnMinFlyHeightChangeEvent;

	public Action<float> OnMinEndHeightChangeEvent;

	public Action<float> OnFlySpeedHorizontalChangeEvent;

	public Action<float> OnFlySpeedVerticalChangeEvent;

	public Action<float> OnFallSpeedChangeEvent;

	public Action<float> OnTurnSpeedChangeEvent;

	public Action<float> OnFlyMaxHeightChangeEvent;

	public Action<float> OnOverheightFallSpeedChangeEvent;

	public Action<float> OnAcceleratedSpeedChangeEvent;

	private float _003CMinFlyHeight_003Ek__BackingField;

	private float _003CMinEndHeight_003Ek__BackingField;

	private float _003CFlySpeedHorizontal_003Ek__BackingField;

	private float _003CFlySpeedVertical_003Ek__BackingField;

	private float _003CFallSpeed_003Ek__BackingField;

	private float _003CTurnSpeed_003Ek__BackingField;

	private float _003CFlyMaxHeight_003Ek__BackingField;

	private float _003COverheightFallSpeed_003Ek__BackingField;

	private float _003CAcceleratedSpeed_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float MinFlyHeight
	{
		get
		{
			return _003CMinFlyHeight_003Ek__BackingField;
		}
		private set
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
		private set
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
		private set
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
		private set
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
		private set
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
		private set
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
		private set
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
		private set
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
		private set
		{
			_003CAcceleratedSpeed_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCFoldWingRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
