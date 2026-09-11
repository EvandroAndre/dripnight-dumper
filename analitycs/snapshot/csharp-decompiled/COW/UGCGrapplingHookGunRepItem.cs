using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGrapplingHookGunRepItem
{
	public const int PROP_ID_THROWSPEED = -237000;

	public const int PROP_ID_TOWSPEED = -237001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnThrowSpeedChangeEvent;

	public Action<float> OnTowSpeedChangeEvent;

	private float _003CThrowSpeed_003Ek__BackingField;

	private float _003CTowSpeed_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float ThrowSpeed
	{
		get
		{
			return _003CThrowSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CThrowSpeed_003Ek__BackingField = value;
		}
	}

	public float TowSpeed
	{
		get
		{
			return _003CTowSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CTowSpeed_003Ek__BackingField = value;
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

	public UGCGrapplingHookGunRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
