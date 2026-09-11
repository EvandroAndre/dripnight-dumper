using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCProfilerEntityRepItem
{
	public const int PROP_ID_SOURCEID = -475000;

	public const int PROP_ID_CODEID = -475001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnSourceIDChangeEvent;

	public Action<string> OnCodeIDChangeEvent;

	private string _003CSourceID_003Ek__BackingField;

	private string _003CCodeID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string SourceID
	{
		get
		{
			return _003CSourceID_003Ek__BackingField;
		}
		private set
		{
			_003CSourceID_003Ek__BackingField = value;
		}
	}

	public string CodeID
	{
		get
		{
			return _003CCodeID_003Ek__BackingField;
		}
		private set
		{
			_003CCodeID_003Ek__BackingField = value;
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

	public UGCProfilerEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
