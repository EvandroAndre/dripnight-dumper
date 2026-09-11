using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAnimationClipRepItem
{
	public const int PROP_ID_NAME = -296000;

	public const int PROP_ID_LENGTH = -296001;

	public const int PROP_ID_SPEED = -296002;

	public const int PROP_ID_ISLOOP = -296003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnNameChangeEvent;

	public Action<float> OnLengthChangeEvent;

	public Action<float> OnSpeedChangeEvent;

	public Action<bool> OnIsLoopChangeEvent;

	private string _003CName_003Ek__BackingField;

	private float _003CLength_003Ek__BackingField;

	private float _003CSpeed_003Ek__BackingField;

	private bool _003CIsLoop_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		private set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public float Length
	{
		get
		{
			return _003CLength_003Ek__BackingField;
		}
		private set
		{
			_003CLength_003Ek__BackingField = value;
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

	public bool IsLoop
	{
		get
		{
			return _003CIsLoop_003Ek__BackingField;
		}
		private set
		{
			_003CIsLoop_003Ek__BackingField = value;
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

	public UGCAnimationClipRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
