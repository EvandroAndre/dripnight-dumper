using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudPanelRepItem
{
	public const int PROP_ID_ALPHA = -265000;

	public const int PROP_ID_BGFILL = -265001;

	public const int PROP_ID_BGNAME = -265002;

	public const int PROP_ID_BGCOLOR = -265003;

	public const int PROP_ID_BGSIZEDELTA = -265004;

	public const int PROP_ID_BGALPHA = -265005;

	public const int PROP_ID_CLIPPINGTYPE = -265006;

	public const int PROP_ID_MASKNAME = -265007;

	public const int PROP_ID_SOFTNESS = -265008;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnAlphaChangeEvent;

	public Action<bool> OnBgFillChangeEvent;

	public Action<string> OnBgNameChangeEvent;

	public Action<int> OnBgColorChangeEvent;

	public Action<Vector2> OnBgSizeDeltaChangeEvent;

	public Action<float> OnBgAlphaChangeEvent;

	public Action<int> OnClippingTypeChangeEvent;

	public Action<string> OnMaskNameChangeEvent;

	public Action<Vector2> OnSoftnessChangeEvent;

	private float _003CAlpha_003Ek__BackingField;

	private bool _003CBgFill_003Ek__BackingField;

	private string _003CBgName_003Ek__BackingField;

	private int _003CBgColor_003Ek__BackingField;

	private Vector2 _003CBgSizeDelta_003Ek__BackingField;

	private float _003CBgAlpha_003Ek__BackingField;

	private int _003CClippingType_003Ek__BackingField;

	private string _003CMaskName_003Ek__BackingField;

	private Vector2 _003CSoftness_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Alpha
	{
		get
		{
			return _003CAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CAlpha_003Ek__BackingField = value;
		}
	}

	public bool BgFill
	{
		get
		{
			return _003CBgFill_003Ek__BackingField;
		}
		private set
		{
			_003CBgFill_003Ek__BackingField = value;
		}
	}

	public string BgName
	{
		get
		{
			return _003CBgName_003Ek__BackingField;
		}
		private set
		{
			_003CBgName_003Ek__BackingField = value;
		}
	}

	public int BgColor
	{
		get
		{
			return _003CBgColor_003Ek__BackingField;
		}
		private set
		{
			_003CBgColor_003Ek__BackingField = value;
		}
	}

	public Vector2 BgSizeDelta
	{
		get
		{
			return _003CBgSizeDelta_003Ek__BackingField;
		}
		private set
		{
			_003CBgSizeDelta_003Ek__BackingField = value;
		}
	}

	public float BgAlpha
	{
		get
		{
			return _003CBgAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CBgAlpha_003Ek__BackingField = value;
		}
	}

	public int ClippingType
	{
		get
		{
			return _003CClippingType_003Ek__BackingField;
		}
		private set
		{
			_003CClippingType_003Ek__BackingField = value;
		}
	}

	public string MaskName
	{
		get
		{
			return _003CMaskName_003Ek__BackingField;
		}
		private set
		{
			_003CMaskName_003Ek__BackingField = value;
		}
	}

	public Vector2 Softness
	{
		get
		{
			return _003CSoftness_003Ek__BackingField;
		}
		private set
		{
			_003CSoftness_003Ek__BackingField = value;
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

	public UGCHudPanelRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
