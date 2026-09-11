using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTimeLineRepItem
{
	public const int PROP_ID_ELAPSEDTIME = -440000;

	public const int PROP_ID_RESOURCE = -440001;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnElapsedTimeChangeEvent;

	public Action<string> OnResourceChangeEvent;

	private int _003CElapsedTime_003Ek__BackingField;

	private string _003CResource_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int ElapsedTime
	{
		get
		{
			return _003CElapsedTime_003Ek__BackingField;
		}
		private set
		{
			_003CElapsedTime_003Ek__BackingField = value;
		}
	}

	public string Resource
	{
		get
		{
			return _003CResource_003Ek__BackingField;
		}
		private set
		{
			_003CResource_003Ek__BackingField = value;
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

	public UGCTimeLineRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
