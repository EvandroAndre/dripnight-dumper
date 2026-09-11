using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSupplyBoxTriggerRepItem
{
	public const int PROP_ID_MODEL = -2506000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnModelChangeEvent;

	private int _003CModel_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Model
	{
		get
		{
			return _003CModel_003Ek__BackingField;
		}
		private set
		{
			_003CModel_003Ek__BackingField = value;
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

	public UGCSupplyBoxTriggerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
