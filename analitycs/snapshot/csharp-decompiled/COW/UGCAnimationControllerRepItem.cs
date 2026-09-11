using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAnimationControllerRepItem
{
	public const int PROP_ID_ATTACHTARGET = -297000;

	public const int PROP_ID_CURRENTSTATE = -297001;

	public const int PROP_ID_CURRENTCLIP = -297002;

	public const int PROP_ID_CURRENTCLIPPROGRESS = -297003;

	public const int PROP_ID_RESUUID = -297004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnAttachTargetChangeEvent;

	public Action<string> OnCurrentStateChangeEvent;

	public Action<string> OnCurrentClipChangeEvent;

	public Action<float> OnCurrentClipProgressChangeEvent;

	public Action<string> OnResUUIDChangeEvent;

	private string _003CAttachTarget_003Ek__BackingField;

	private string _003CCurrentState_003Ek__BackingField;

	private string _003CCurrentClip_003Ek__BackingField;

	private float _003CCurrentClipProgress_003Ek__BackingField;

	private string _003CResUUID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string AttachTarget
	{
		get
		{
			return _003CAttachTarget_003Ek__BackingField;
		}
		private set
		{
			_003CAttachTarget_003Ek__BackingField = value;
		}
	}

	public string CurrentState
	{
		get
		{
			return _003CCurrentState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentState_003Ek__BackingField = value;
		}
	}

	public string CurrentClip
	{
		get
		{
			return _003CCurrentClip_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentClip_003Ek__BackingField = value;
		}
	}

	public float CurrentClipProgress
	{
		get
		{
			return _003CCurrentClipProgress_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentClipProgress_003Ek__BackingField = value;
		}
	}

	public string ResUUID
	{
		get
		{
			return _003CResUUID_003Ek__BackingField;
		}
		private set
		{
			_003CResUUID_003Ek__BackingField = value;
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

	public UGCAnimationControllerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
