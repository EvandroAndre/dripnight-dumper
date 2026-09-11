using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCyberpunkFilterStyleRepItem
{
	public const int PROP_ID_EDGEINTENSITY = -486000;

	public const int PROP_ID_EDGESIZE = -486001;

	public const int PROP_ID_EDGESENSITIVITY = -486002;

	public const int PROP_ID_GLITCHINTERVAL = -486003;

	public const int PROP_ID_GLITCHDURATION = -486004;

	public const int PROP_ID_EDGECOLOR1 = -486005;

	public const int PROP_ID_EDGECOLOR2 = -486006;

	public const int PROP_ID_EDGENOISETEX = -486007;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnEdgeIntensityChangeEvent;

	public Action<float> OnEdgeSizeChangeEvent;

	public Action<float> OnEdgeSensitivityChangeEvent;

	public Action<float> OnGlitchIntervalChangeEvent;

	public Action<float> OnGlitchDurationChangeEvent;

	public Action<int> OnEdgeColor1ChangeEvent;

	public Action<int> OnEdgeColor2ChangeEvent;

	public Action<string> OnEdgeNoiseTexChangeEvent;

	private float _003CEdgeIntensity_003Ek__BackingField;

	private float _003CEdgeSize_003Ek__BackingField;

	private float _003CEdgeSensitivity_003Ek__BackingField;

	private float _003CGlitchInterval_003Ek__BackingField;

	private float _003CGlitchDuration_003Ek__BackingField;

	private int _003CEdgeColor1_003Ek__BackingField;

	private int _003CEdgeColor2_003Ek__BackingField;

	private string _003CEdgeNoiseTex_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float EdgeIntensity
	{
		get
		{
			return _003CEdgeIntensity_003Ek__BackingField;
		}
		private set
		{
			_003CEdgeIntensity_003Ek__BackingField = value;
		}
	}

	public float EdgeSize
	{
		get
		{
			return _003CEdgeSize_003Ek__BackingField;
		}
		private set
		{
			_003CEdgeSize_003Ek__BackingField = value;
		}
	}

	public float EdgeSensitivity
	{
		get
		{
			return _003CEdgeSensitivity_003Ek__BackingField;
		}
		private set
		{
			_003CEdgeSensitivity_003Ek__BackingField = value;
		}
	}

	public float GlitchInterval
	{
		get
		{
			return _003CGlitchInterval_003Ek__BackingField;
		}
		private set
		{
			_003CGlitchInterval_003Ek__BackingField = value;
		}
	}

	public float GlitchDuration
	{
		get
		{
			return _003CGlitchDuration_003Ek__BackingField;
		}
		private set
		{
			_003CGlitchDuration_003Ek__BackingField = value;
		}
	}

	public int EdgeColor1
	{
		get
		{
			return _003CEdgeColor1_003Ek__BackingField;
		}
		private set
		{
			_003CEdgeColor1_003Ek__BackingField = value;
		}
	}

	public int EdgeColor2
	{
		get
		{
			return _003CEdgeColor2_003Ek__BackingField;
		}
		private set
		{
			_003CEdgeColor2_003Ek__BackingField = value;
		}
	}

	public string EdgeNoiseTex
	{
		get
		{
			return _003CEdgeNoiseTex_003Ek__BackingField;
		}
		private set
		{
			_003CEdgeNoiseTex_003Ek__BackingField = value;
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

	public UGCCyberpunkFilterStyleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
