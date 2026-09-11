using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPropertyFormulaRepItem
{
	public const int PROP_ID_BINDENTITYID = -70000;

	public const int PROP_ID_BINDPROPERTYID = -70001;

	public const int PROP_ID_MINVALUE = -70002;

	public const int PROP_ID_MAXVALUE = -70003;

	public const int PROP_ID_BASEMULTIPLIER = -70004;

	public const int PROP_ID_BEFOREACCUMULATOR = -70005;

	public const int PROP_ID_MULTIPLIER = -70006;

	public const int PROP_ID_SUMMULTIPLIER = -70007;

	public const int PROP_ID_AFTERACCUMULATOR = -70008;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnBindEntityIDChangeEvent;

	public Action<long> OnBindPropertyIDChangeEvent;

	public Action<float> OnMinValueChangeEvent;

	public Action<float> OnMaxValueChangeEvent;

	public Action<float> OnBaseMultiplierChangeEvent;

	public Action<float> OnBeforeAccumulatorChangeEvent;

	public Action<float> OnMultiplierChangeEvent;

	public Action<float> OnSumMultiplierChangeEvent;

	public Action<float> OnAfterAccumulatorChangeEvent;

	private string _003CBindEntityID_003Ek__BackingField;

	private long _003CBindPropertyID_003Ek__BackingField;

	private float _003CMinValue_003Ek__BackingField;

	private float _003CMaxValue_003Ek__BackingField;

	private float _003CBaseMultiplier_003Ek__BackingField;

	private float _003CBeforeAccumulator_003Ek__BackingField;

	private float _003CMultiplier_003Ek__BackingField;

	private float _003CSumMultiplier_003Ek__BackingField;

	private float _003CAfterAccumulator_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string BindEntityID
	{
		get
		{
			return _003CBindEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CBindEntityID_003Ek__BackingField = value;
		}
	}

	public long BindPropertyID
	{
		get
		{
			return _003CBindPropertyID_003Ek__BackingField;
		}
		private set
		{
			_003CBindPropertyID_003Ek__BackingField = value;
		}
	}

	public float MinValue
	{
		get
		{
			return _003CMinValue_003Ek__BackingField;
		}
		private set
		{
			_003CMinValue_003Ek__BackingField = value;
		}
	}

	public float MaxValue
	{
		get
		{
			return _003CMaxValue_003Ek__BackingField;
		}
		private set
		{
			_003CMaxValue_003Ek__BackingField = value;
		}
	}

	public float BaseMultiplier
	{
		get
		{
			return _003CBaseMultiplier_003Ek__BackingField;
		}
		private set
		{
			_003CBaseMultiplier_003Ek__BackingField = value;
		}
	}

	public float BeforeAccumulator
	{
		get
		{
			return _003CBeforeAccumulator_003Ek__BackingField;
		}
		private set
		{
			_003CBeforeAccumulator_003Ek__BackingField = value;
		}
	}

	public float Multiplier
	{
		get
		{
			return _003CMultiplier_003Ek__BackingField;
		}
		private set
		{
			_003CMultiplier_003Ek__BackingField = value;
		}
	}

	public float SumMultiplier
	{
		get
		{
			return _003CSumMultiplier_003Ek__BackingField;
		}
		private set
		{
			_003CSumMultiplier_003Ek__BackingField = value;
		}
	}

	public float AfterAccumulator
	{
		get
		{
			return _003CAfterAccumulator_003Ek__BackingField;
		}
		private set
		{
			_003CAfterAccumulator_003Ek__BackingField = value;
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

	public UGCPropertyFormulaRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
