using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLowGravityRepItem
{
	public const int PROP_ID_JUMPHEIGHT = -152000;

	public const int PROP_ID_CUSTOMGRAVITY = -152001;

	public const int PROP_ID_SHOWORHIDE = -152002;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnJumpHeightChangeEvent;

	public Action<float> OnCustomGravityChangeEvent;

	public Action<bool> OnShowOrHideChangeEvent;

	private float _003CJumpHeight_003Ek__BackingField;

	private float _003CCustomGravity_003Ek__BackingField;

	private bool _003CShowOrHide_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float JumpHeight
	{
		get
		{
			return _003CJumpHeight_003Ek__BackingField;
		}
		private set
		{
			_003CJumpHeight_003Ek__BackingField = value;
		}
	}

	public float CustomGravity
	{
		get
		{
			return _003CCustomGravity_003Ek__BackingField;
		}
		private set
		{
			_003CCustomGravity_003Ek__BackingField = value;
		}
	}

	public bool ShowOrHide
	{
		get
		{
			return _003CShowOrHide_003Ek__BackingField;
		}
		private set
		{
			_003CShowOrHide_003Ek__BackingField = value;
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

	public UGCLowGravityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
