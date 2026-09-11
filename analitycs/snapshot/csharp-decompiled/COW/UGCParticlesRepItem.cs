using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCParticlesRepItem
{
	public const int PROP_ID_RESUUID = -417000;

	public const int PROP_ID_ELAPSEDPERCENTAGE = -417001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnResUUIDChangeEvent;

	public Action<float> OnElapsedPercentageChangeEvent;

	private string _003CResUUID_003Ek__BackingField;

	private float _003CElapsedPercentage_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public float ElapsedPercentage
	{
		get
		{
			return _003CElapsedPercentage_003Ek__BackingField;
		}
		private set
		{
			_003CElapsedPercentage_003Ek__BackingField = value;
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

	public UGCParticlesRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
