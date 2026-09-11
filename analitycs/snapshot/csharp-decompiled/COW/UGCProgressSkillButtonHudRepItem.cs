using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCProgressSkillButtonHudRepItem
{
	public const int PROP_ID_ICON = -260000;

	public const int PROP_ID_COLOR = -260001;

	public const int PROP_ID_VALUE = -260002;

	public const int PROP_ID_SPEED = -260003;

	public const int PROP_ID_EFFECTACTIVE = -260004;

	public const int PROP_ID_NORMALIZEDPOSITION = -260005;

	public const int PROP_ID_INITIALVALUE = -260006;

	public const int PROP_ID_EFFECTCOLOR = -260007;

	public const int PROP_ID_SCALE = -260008;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnIconChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<float> OnValueChangeEvent;

	public Action<float> OnSpeedChangeEvent;

	public Action<bool> OnEffectActiveChangeEvent;

	public Action<Vector3> OnNormalizedPositionChangeEvent;

	public Action<float> OnInitialValueChangeEvent;

	public Action<int> OnEffectColorChangeEvent;

	public Action<float> OnScaleChangeEvent;

	private string _003CIcon_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private float _003CValue_003Ek__BackingField;

	private float _003CSpeed_003Ek__BackingField;

	private bool _003CEffectActive_003Ek__BackingField;

	private Vector3 _003CNormalizedPosition_003Ek__BackingField;

	private float _003CInitialValue_003Ek__BackingField;

	private int _003CEffectColor_003Ek__BackingField;

	private float _003CScale_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Icon
	{
		get
		{
			return _003CIcon_003Ek__BackingField;
		}
		private set
		{
			_003CIcon_003Ek__BackingField = value;
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

	public float Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		private set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}

	public float Speed
	{
		get
		{
			return _003CSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CSpeed_003Ek__BackingField = value;
		}
	}

	public bool EffectActive
	{
		get
		{
			return _003CEffectActive_003Ek__BackingField;
		}
		private set
		{
			_003CEffectActive_003Ek__BackingField = value;
		}
	}

	public Vector3 NormalizedPosition
	{
		get
		{
			return _003CNormalizedPosition_003Ek__BackingField;
		}
		private set
		{
			_003CNormalizedPosition_003Ek__BackingField = value;
		}
	}

	public float InitialValue
	{
		get
		{
			return _003CInitialValue_003Ek__BackingField;
		}
		private set
		{
			_003CInitialValue_003Ek__BackingField = value;
		}
	}

	public int EffectColor
	{
		get
		{
			return _003CEffectColor_003Ek__BackingField;
		}
		private set
		{
			_003CEffectColor_003Ek__BackingField = value;
		}
	}

	public float Scale
	{
		get
		{
			return _003CScale_003Ek__BackingField;
		}
		private set
		{
			_003CScale_003Ek__BackingField = value;
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

	public UGCProgressSkillButtonHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
