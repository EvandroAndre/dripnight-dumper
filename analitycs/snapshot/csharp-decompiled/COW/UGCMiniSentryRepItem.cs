using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMiniSentryRepItem
{
	public const int PROP_ID_DAMAGE = -225000;

	public const int PROP_ID_INTERVAL = -225001;

	public const int PROP_ID_HITCHANCE = -225002;

	public const int PROP_ID_RANGE = -225003;

	public const int PROP_ID_ANGLESPEED = -225004;

	public const int PROP_ID_ANGLEUP = -225005;

	public const int PROP_ID_ANGLEDOWN = -225006;

	public const int PROP_ID_HPMAX = -225007;

	public const int PROP_ID_LIFETIME = -225008;

	public const int PROP_ID_MAXCOUNT = -225009;

	public const int PROP_ID_FIREANGLE = -225010;

	public const int PROP_ID_DEFENSE = -225011;

	public const int PROP_ID_BITEARMOR = -225012;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnAngleSpeedChangeEvent;

	public Action<float> OnAngleUpChangeEvent;

	public Action<float> OnAngleDownChangeEvent;

	public Action<int> OnHpMaxChangeEvent;

	private float _003CAngleSpeed_003Ek__BackingField;

	private float _003CAngleUp_003Ek__BackingField;

	private float _003CAngleDown_003Ek__BackingField;

	private int _003CHpMax_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float AngleSpeed
	{
		get
		{
			return _003CAngleSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CAngleSpeed_003Ek__BackingField = value;
		}
	}

	public float AngleUp
	{
		get
		{
			return _003CAngleUp_003Ek__BackingField;
		}
		private set
		{
			_003CAngleUp_003Ek__BackingField = value;
		}
	}

	public float AngleDown
	{
		get
		{
			return _003CAngleDown_003Ek__BackingField;
		}
		private set
		{
			_003CAngleDown_003Ek__BackingField = value;
		}
	}

	public int HpMax
	{
		get
		{
			return _003CHpMax_003Ek__BackingField;
		}
		private set
		{
			_003CHpMax_003Ek__BackingField = value;
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

	public UGCMiniSentryRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
