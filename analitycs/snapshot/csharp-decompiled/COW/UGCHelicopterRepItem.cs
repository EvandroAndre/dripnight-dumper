using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCHelicopterRepItem
{
	public const int PROP_ID_FORWARDSPEED = -411000;

	public const int PROP_ID_BACKWARDSPEED = -411001;

	public const int PROP_ID_UPSPEED = -411002;

	public const int PROP_ID_DOWNSPEED = -411003;

	public const int PROP_ID_GRENADEMINDAMAGE = -411004;

	public const int PROP_ID_GRENADEMAXDAMAGE = -411005;

	public const int PROP_ID_GRENADERANGE = -411006;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnForwardSpeedChangeEvent;

	public Action<float> OnBackwardSpeedChangeEvent;

	public Action<float> OnUpSpeedChangeEvent;

	public Action<float> OnDownSpeedChangeEvent;

	public Action<int> OnGrenadeMinDamageChangeEvent;

	public Action<int> OnGrenadeMaxDamageChangeEvent;

	public Action<float> OnGrenadeRangeChangeEvent;

	private float _003CForwardSpeed_003Ek__BackingField;

	private float _003CBackwardSpeed_003Ek__BackingField;

	private float _003CUpSpeed_003Ek__BackingField;

	private float _003CDownSpeed_003Ek__BackingField;

	private int _003CGrenadeMinDamage_003Ek__BackingField;

	private int _003CGrenadeMaxDamage_003Ek__BackingField;

	private float _003CGrenadeRange_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float ForwardSpeed
	{
		get
		{
			return _003CForwardSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CForwardSpeed_003Ek__BackingField = value;
		}
	}

	public float BackwardSpeed
	{
		get
		{
			return _003CBackwardSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CBackwardSpeed_003Ek__BackingField = value;
		}
	}

	public float UpSpeed
	{
		get
		{
			return _003CUpSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CUpSpeed_003Ek__BackingField = value;
		}
	}

	public float DownSpeed
	{
		get
		{
			return _003CDownSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CDownSpeed_003Ek__BackingField = value;
		}
	}

	public int GrenadeMinDamage
	{
		get
		{
			return _003CGrenadeMinDamage_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeMinDamage_003Ek__BackingField = value;
		}
	}

	public int GrenadeMaxDamage
	{
		get
		{
			return _003CGrenadeMaxDamage_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeMaxDamage_003Ek__BackingField = value;
		}
	}

	public float GrenadeRange
	{
		get
		{
			return _003CGrenadeRange_003Ek__BackingField;
		}
		private set
		{
			_003CGrenadeRange_003Ek__BackingField = value;
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

	public UGCHelicopterRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
