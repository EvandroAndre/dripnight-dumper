using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAnimationControllerAbleRepItem
{
	public const int PROP_ID_ANIMATIONCONTROLLERRESUUID = -314000;

	public const int PROP_ID_ANIMATIONCONTROLLER = -314001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnAnimationControllerResUUIDChangeEvent;

	public Action<string> OnAnimationControllerChangeEvent;

	private string _003CAnimationControllerResUUID_003Ek__BackingField;

	private string _003CAnimationController_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string AnimationControllerResUUID
	{
		get
		{
			return _003CAnimationControllerResUUID_003Ek__BackingField;
		}
		private set
		{
			_003CAnimationControllerResUUID_003Ek__BackingField = value;
		}
	}

	public string AnimationController
	{
		get
		{
			return _003CAnimationController_003Ek__BackingField;
		}
		private set
		{
			_003CAnimationController_003Ek__BackingField = value;
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

	public UGCAnimationControllerAbleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
