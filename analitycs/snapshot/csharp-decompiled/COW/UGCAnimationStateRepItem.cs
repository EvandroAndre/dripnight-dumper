using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAnimationStateRepItem
{
	public const int PROP_ID_NAME = -295000;

	public const int PROP_ID_ISLOOP = -295001;

	public const int PROP_ID_SPEED = -295002;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnNameChangeEvent;

	public Action<bool> OnIsLoopChangeEvent;

	public Action<float> OnSpeedChangeEvent;

	private string _003CName_003Ek__BackingField;

	private bool _003CIsLoop_003Ek__BackingField;

	private float _003CSpeed_003Ek__BackingField;

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

	public UGCAnimationStateRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
