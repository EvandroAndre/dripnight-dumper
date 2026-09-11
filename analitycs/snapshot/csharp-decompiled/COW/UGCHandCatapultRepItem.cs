using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHandCatapultRepItem
{
	public const int PROP_ID_HORIZONTALMINANGLE = -360000;

	public const int PROP_ID_HORIZONTALMAXANGLE = -360001;

	public const int PROP_ID_VERTICALMINANGLE = -360002;

	public const int PROP_ID_VERTICALMAXANGLE = -360003;

	public const int PROP_ID_SPEED = -360004;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnHorizontalMinAngleChangeEvent;

	public Action<float> OnHorizontalMaxAngleChangeEvent;

	public Action<float> OnVerticalMinAngleChangeEvent;

	public Action<float> OnVerticalMaxAngleChangeEvent;

	public Action<float> OnSpeedChangeEvent;

	private float _003CHorizontalMinAngle_003Ek__BackingField;

	private float _003CHorizontalMaxAngle_003Ek__BackingField;

	private float _003CVerticalMinAngle_003Ek__BackingField;

	private float _003CVerticalMaxAngle_003Ek__BackingField;

	private float _003CSpeed_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float HorizontalMinAngle
	{
		get
		{
			return _003CHorizontalMinAngle_003Ek__BackingField;
		}
		private set
		{
			_003CHorizontalMinAngle_003Ek__BackingField = value;
		}
	}

	public float HorizontalMaxAngle
	{
		get
		{
			return _003CHorizontalMaxAngle_003Ek__BackingField;
		}
		private set
		{
			_003CHorizontalMaxAngle_003Ek__BackingField = value;
		}
	}

	public float VerticalMinAngle
	{
		get
		{
			return _003CVerticalMinAngle_003Ek__BackingField;
		}
		private set
		{
			_003CVerticalMinAngle_003Ek__BackingField = value;
		}
	}

	public float VerticalMaxAngle
	{
		get
		{
			return _003CVerticalMaxAngle_003Ek__BackingField;
		}
		private set
		{
			_003CVerticalMaxAngle_003Ek__BackingField = value;
		}
	}

	public float Speed
	{
		get
		{
			return _003CSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CSpeed_003Ek__BackingField = value;
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

	public UGCHandCatapultRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
