using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCProgressbarHudRepItem
{
	public const int PROP_ID_OPENSTATE = -120000;

	public const int PROP_ID_FOLLOWTARGET = -120001;

	public const int PROP_ID_COLOR = -120002;

	public const int PROP_ID_HUDLENGTH = -120003;

	public const int PROP_ID_CURRENTVALUE = -120004;

	public const int PROP_ID_OFFSET = -120005;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<int> OnHUDLengthChangeEvent;

	public Action<float> OnCurrentValueChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private int _003CHUDLength_003Ek__BackingField;

	private float _003CCurrentValue_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public string FollowTarget
	{
		get
		{
			return _003CFollowTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFollowTarget_003Ek__BackingField = value;
		}
	}

	public int Color
	{
		get
		{
			return _003CColor_003Ek__BackingField;
		}
		private set
		{
			_003CColor_003Ek__BackingField = value;
		}
	}

	public int HUDLength
	{
		get
		{
			return _003CHUDLength_003Ek__BackingField;
		}
		private set
		{
			_003CHUDLength_003Ek__BackingField = value;
		}
	}

	public float CurrentValue
	{
		get
		{
			return _003CCurrentValue_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentValue_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
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

	public UGCProgressbarHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
