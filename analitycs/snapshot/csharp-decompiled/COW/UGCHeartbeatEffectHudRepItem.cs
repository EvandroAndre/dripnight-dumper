using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHeartbeatEffectHudRepItem
{
	public const int PROP_ID_OPENSTATE = -254000;

	public const int PROP_ID_PLAYSPEED = -254001;

	public const int PROP_ID_COLOR = -254002;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<float> OnPlaySpeedChangeEvent;

	public Action<int> OnColorChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private float _003CPlaySpeed_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

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

	public float PlaySpeed
	{
		get
		{
			return _003CPlaySpeed_003Ek__BackingField;
		}
		private set
		{
			_003CPlaySpeed_003Ek__BackingField = value;
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

	public UGCHeartbeatEffectHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
