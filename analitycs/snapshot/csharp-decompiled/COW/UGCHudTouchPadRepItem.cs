using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHudTouchPadRepItem
{
	public const int PROP_ID_ALPHA = -387000;

	public const int PROP_ID_ALLOWPRESSEDOUTSIDE = -387001;

	public const int PROP_ID_DISABLECOLLIDER = -387002;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnAlphaChangeEvent;

	public Action<bool> OnAllowPressedOutsideChangeEvent;

	public Action<bool> OnDisableColliderChangeEvent;

	private float _003CAlpha_003Ek__BackingField;

	private bool _003CAllowPressedOutside_003Ek__BackingField;

	private bool _003CDisableCollider_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Alpha
	{
		get
		{
			return _003CAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CAlpha_003Ek__BackingField = value;
		}
	}

	public bool AllowPressedOutside
	{
		get
		{
			return _003CAllowPressedOutside_003Ek__BackingField;
		}
		private set
		{
			_003CAllowPressedOutside_003Ek__BackingField = value;
		}
	}

	public bool DisableCollider
	{
		get
		{
			return _003CDisableCollider_003Ek__BackingField;
		}
		private set
		{
			_003CDisableCollider_003Ek__BackingField = value;
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

	public UGCHudTouchPadRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
