using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCGoldenAgeFilterStyleRepItem
{
	public const int PROP_ID_INTENSITY = -485000;

	public const int PROP_ID_WARMTH = -485001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnIntensityChangeEvent;

	public Action<float> OnWarmthChangeEvent;

	private float _003CIntensity_003Ek__BackingField;

	private float _003CWarmth_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Intensity
	{
		get
		{
			return _003CIntensity_003Ek__BackingField;
		}
		private set
		{
			_003CIntensity_003Ek__BackingField = value;
		}
	}

	public float Warmth
	{
		get
		{
			return _003CWarmth_003Ek__BackingField;
		}
		private set
		{
			_003CWarmth_003Ek__BackingField = value;
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

	public UGCGoldenAgeFilterStyleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
