using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAddScoreVFXHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1037000;

	public const int PROP_ID_SCORENUM = -1037001;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnScoreNumChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CScoreNum_003Ek__BackingField;

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

	public int ScoreNum
	{
		get
		{
			return _003CScoreNum_003Ek__BackingField;
		}
		private set
		{
			_003CScoreNum_003Ek__BackingField = value;
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

	public UGCAddScoreVFXHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
