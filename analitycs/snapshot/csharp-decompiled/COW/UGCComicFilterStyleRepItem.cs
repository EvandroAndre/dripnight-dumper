using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCComicFilterStyleRepItem
{
	public const int PROP_ID_THRESHOLD = -481000;

	public const int PROP_ID_RANGE = -481001;

	public const int PROP_ID_FLASHSPEED = -481002;

	public const int PROP_ID_LINEINTENSITY = -481003;

	public const int PROP_ID_LINESIZE = -481004;

	public const int PROP_ID_PENCILSIZE = -481005;

	public const int PROP_ID_PENCILCORRECTION = -481006;

	public const int PROP_ID_PENCILCOLOR = -481007;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnThresholdChangeEvent;

	public Action<float> OnRangeChangeEvent;

	public Action<float> OnFlashSpeedChangeEvent;

	public Action<float> OnLineIntensityChangeEvent;

	public Action<float> OnLineSizeChangeEvent;

	public Action<float> OnPencilSizeChangeEvent;

	public Action<float> OnPencilCorrectionChangeEvent;

	public Action<int> OnPencilColorChangeEvent;

	private float _003CThreshold_003Ek__BackingField;

	private float _003CRange_003Ek__BackingField;

	private float _003CFlashSpeed_003Ek__BackingField;

	private float _003CLineIntensity_003Ek__BackingField;

	private float _003CLineSize_003Ek__BackingField;

	private float _003CPencilSize_003Ek__BackingField;

	private float _003CPencilCorrection_003Ek__BackingField;

	private int _003CPencilColor_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Threshold
	{
		get
		{
			return _003CThreshold_003Ek__BackingField;
		}
		private set
		{
			_003CThreshold_003Ek__BackingField = value;
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

	public float FlashSpeed
	{
		get
		{
			return _003CFlashSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CFlashSpeed_003Ek__BackingField = value;
		}
	}

	public float LineIntensity
	{
		get
		{
			return _003CLineIntensity_003Ek__BackingField;
		}
		private set
		{
			_003CLineIntensity_003Ek__BackingField = value;
		}
	}

	public float LineSize
	{
		get
		{
			return _003CLineSize_003Ek__BackingField;
		}
		private set
		{
			_003CLineSize_003Ek__BackingField = value;
		}
	}

	public float PencilSize
	{
		get
		{
			return _003CPencilSize_003Ek__BackingField;
		}
		private set
		{
			_003CPencilSize_003Ek__BackingField = value;
		}
	}

	public float PencilCorrection
	{
		get
		{
			return _003CPencilCorrection_003Ek__BackingField;
		}
		private set
		{
			_003CPencilCorrection_003Ek__BackingField = value;
		}
	}

	public int PencilColor
	{
		get
		{
			return _003CPencilColor_003Ek__BackingField;
		}
		private set
		{
			_003CPencilColor_003Ek__BackingField = value;
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

	public UGCComicFilterStyleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
