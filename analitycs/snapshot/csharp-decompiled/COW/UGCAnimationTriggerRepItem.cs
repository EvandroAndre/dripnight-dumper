using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAnimationTriggerRepItem
{
	public const int PROP_ID_ISCENTERPOS = -364000;

	public const int PROP_ID_LOOP = -364001;

	public const int PROP_ID_CLIP = -364002;

	public const int PROP_ID_ISAUTOPLAY = -364003;

	public const int PROP_ID_ISCUSTOMEMOTE = -364004;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnIsCenterPosChangeEvent;

	public Action<bool> OnLoopChangeEvent;

	public Action<string> OnClipChangeEvent;

	public Action<bool> OnIsAutoPlayChangeEvent;

	public Action<bool> OnIsCustomEmoteChangeEvent;

	private bool _003CIsCenterPos_003Ek__BackingField;

	private bool _003CLoop_003Ek__BackingField;

	private string _003CClip_003Ek__BackingField;

	private bool _003CIsAutoPlay_003Ek__BackingField;

	private bool _003CIsCustomEmote_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool IsCenterPos
	{
		get
		{
			return _003CIsCenterPos_003Ek__BackingField;
		}
		private set
		{
			_003CIsCenterPos_003Ek__BackingField = value;
		}
	}

	public bool Loop
	{
		get
		{
			return _003CLoop_003Ek__BackingField;
		}
		private set
		{
			_003CLoop_003Ek__BackingField = value;
		}
	}

	public string Clip
	{
		get
		{
			return _003CClip_003Ek__BackingField;
		}
		private set
		{
			_003CClip_003Ek__BackingField = value;
		}
	}

	public bool IsAutoPlay
	{
		get
		{
			return _003CIsAutoPlay_003Ek__BackingField;
		}
		private set
		{
			_003CIsAutoPlay_003Ek__BackingField = value;
		}
	}

	public bool IsCustomEmote
	{
		get
		{
			return _003CIsCustomEmote_003Ek__BackingField;
		}
		private set
		{
			_003CIsCustomEmote_003Ek__BackingField = value;
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

	public UGCAnimationTriggerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
