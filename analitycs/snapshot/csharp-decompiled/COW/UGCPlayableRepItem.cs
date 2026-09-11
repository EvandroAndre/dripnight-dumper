using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayableRepItem
{
	public const int PROP_ID_PLAYING = -197000;

	public const int PROP_ID_FLAG = -197001;

	public const int PROP_ID_AUTOPLAY = -197002;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnPlayingChangeEvent;

	public Action<int> OnFlagChangeEvent;

	public Action<bool> OnAutoPlayChangeEvent;

	private bool _003CPlaying_003Ek__BackingField;

	private int _003CFlag_003Ek__BackingField;

	private bool _003CAutoPlay_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool Playing
	{
		get
		{
			return _003CPlaying_003Ek__BackingField;
		}
		private set
		{
			_003CPlaying_003Ek__BackingField = value;
		}
	}

	public int Flag
	{
		get
		{
			return _003CFlag_003Ek__BackingField;
		}
		private set
		{
			_003CFlag_003Ek__BackingField = value;
		}
	}

	public bool AutoPlay
	{
		get
		{
			return _003CAutoPlay_003Ek__BackingField;
		}
		private set
		{
			_003CAutoPlay_003Ek__BackingField = value;
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

	public UGCPlayableRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
