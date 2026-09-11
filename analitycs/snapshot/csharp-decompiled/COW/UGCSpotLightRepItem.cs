using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSpotLightRepItem
{
	public const int PROP_ID_INTENSITY = -426000;

	public const int PROP_ID_RANGE = -426001;

	public const int PROP_ID_SPOTANGLE = -426002;

	public const int PROP_ID_COLOR = -426003;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnIntensityChangeEvent;

	public Action<float> OnRangeChangeEvent;

	public Action<float> OnSpotAngleChangeEvent;

	public Action<int> OnColorChangeEvent;

	private float _003CIntensity_003Ek__BackingField;

	private float _003CRange_003Ek__BackingField;

	private float _003CSpotAngle_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

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

	public float Range
	{
		get
		{
			return _003CRange_003Ek__BackingField;
		}
		private set
		{
			_003CRange_003Ek__BackingField = value;
		}
	}

	public float SpotAngle
	{
		get
		{
			return _003CSpotAngle_003Ek__BackingField;
		}
		private set
		{
			_003CSpotAngle_003Ek__BackingField = value;
		}
	}

	public int Color
	{
		get
		{
			return _003CColor_003Ek__BackingField;
		}
		private set
		{
			_003CColor_003Ek__BackingField = value;
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

	public UGCSpotLightRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
