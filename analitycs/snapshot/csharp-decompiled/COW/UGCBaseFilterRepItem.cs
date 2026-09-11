using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBaseFilterRepItem
{
	public const int PROP_ID_TYPE = -480000;

	public const int PROP_ID_BRIGHTNESS = -480001;

	public const int PROP_ID_SATURATION = -480002;

	public const int PROP_ID_CONTRAST = -480003;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnTypeChangeEvent;

	public Action<float> OnBrightnessChangeEvent;

	public Action<float> OnSaturationChangeEvent;

	public Action<float> OnContrastChangeEvent;

	private int _003CType_003Ek__BackingField;

	private float _003CBrightness_003Ek__BackingField;

	private float _003CSaturation_003Ek__BackingField;

	private float _003CContrast_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		private set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	public float Brightness
	{
		get
		{
			return _003CBrightness_003Ek__BackingField;
		}
		private set
		{
			_003CBrightness_003Ek__BackingField = value;
		}
	}

	public float Saturation
	{
		get
		{
			return _003CSaturation_003Ek__BackingField;
		}
		private set
		{
			_003CSaturation_003Ek__BackingField = value;
		}
	}

	public float Contrast
	{
		get
		{
			return _003CContrast_003Ek__BackingField;
		}
		private set
		{
			_003CContrast_003Ek__BackingField = value;
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

	public UGCBaseFilterRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
