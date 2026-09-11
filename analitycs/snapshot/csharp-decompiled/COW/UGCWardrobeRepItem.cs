using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCWardrobeRepItem
{
	public const int PROP_ID_TRIGGERRADIUS = -100000;

	public const int PROP_ID_MODELSHOW = -100001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnTriggerRadiusChangeEvent;

	public Action<bool> OnModelShowChangeEvent;

	private float _003CTriggerRadius_003Ek__BackingField;

	private bool _003CModelShow_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float TriggerRadius
	{
		get
		{
			return _003CTriggerRadius_003Ek__BackingField;
		}
		private set
		{
			_003CTriggerRadius_003Ek__BackingField = value;
		}
	}

	public bool ModelShow
	{
		get
		{
			return _003CModelShow_003Ek__BackingField;
		}
		private set
		{
			_003CModelShow_003Ek__BackingField = value;
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

	public UGCWardrobeRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
