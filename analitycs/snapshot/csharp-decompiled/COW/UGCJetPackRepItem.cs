using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCJetPackRepItem
{
	public const int PROP_ID_MAXENERGY = -199000;

	public const int PROP_ID_BASEENERGYCOST = -199001;

	public const int PROP_ID_UPCHANGEENERGYCOST = -199002;

	public const int PROP_ID_DASHENERGYCOST = -199003;

	public const int PROP_ID_RUSHENERGYCOST = -199004;

	public const int PROP_ID_BASEHSPEED = -199005;

	public const int PROP_ID_DASHHSPEED = -199006;

	public const int PROP_ID_BASEVSPEED = -199007;

	public const int PROP_ID_RUSHVSPEED = -199008;

	public const int PROP_ID_DISTANCETOREADY = -199009;

	public const int PROP_ID_FALLINGDAMAGESCALE = -199010;

	public const int PROP_ID_CURENERGY = -199011;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnMaxEnergyChangeEvent;

	public Action<float> OnBaseHSpeedChangeEvent;

	public Action<float> OnDashHSpeedChangeEvent;

	public Action<float> OnBaseVSpeedChangeEvent;

	public Action<float> OnRushVSpeedChangeEvent;

	public Action<float> OnDistanceToReadyChangeEvent;

	private int _003CMaxEnergy_003Ek__BackingField;

	private float _003CBaseHSpeed_003Ek__BackingField;

	private float _003CDashHSpeed_003Ek__BackingField;

	private float _003CBaseVSpeed_003Ek__BackingField;

	private float _003CRushVSpeed_003Ek__BackingField;

	private float _003CDistanceToReady_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int MaxEnergy
	{
		get
		{
			return _003CMaxEnergy_003Ek__BackingField;
		}
		private set
		{
			_003CMaxEnergy_003Ek__BackingField = value;
		}
	}

	public float BaseHSpeed
	{
		get
		{
			return _003CBaseHSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CBaseHSpeed_003Ek__BackingField = value;
		}
	}

	public float DashHSpeed
	{
		get
		{
			return _003CDashHSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CDashHSpeed_003Ek__BackingField = value;
		}
	}

	public float BaseVSpeed
	{
		get
		{
			return _003CBaseVSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CBaseVSpeed_003Ek__BackingField = value;
		}
	}

	public float RushVSpeed
	{
		get
		{
			return _003CRushVSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CRushVSpeed_003Ek__BackingField = value;
		}
	}

	public float DistanceToReady
	{
		get
		{
			return _003CDistanceToReady_003Ek__BackingField;
		}
		private set
		{
			_003CDistanceToReady_003Ek__BackingField = value;
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

	public UGCJetPackRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
