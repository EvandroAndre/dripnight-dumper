using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPointLightRepItem
{
	public const int PROP_ID_INTENSITY = -218000;

	public const int PROP_ID_RANGE = -218001;

	public const int PROP_ID_COLOR = -218002;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnIntensityChangeEvent;

	public Action<float> OnRangeChangeEvent;

	public Action<int> OnColorChangeEvent;

	private float _003CIntensity_003Ek__BackingField;

	private float _003CRange_003Ek__BackingField;

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

	public UGCPointLightRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
