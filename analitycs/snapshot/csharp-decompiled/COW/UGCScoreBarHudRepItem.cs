using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCScoreBarHudRepItem
{
	public const int PROP_ID_LEFTCOLOR = -242000;

	public const int PROP_ID_RIGHTCOLOR = -242001;

	public const int PROP_ID_LEFTEFFECTACTIVE = -242002;

	public const int PROP_ID_RIGHTEFFECTACTIVE = -242003;

	public const int PROP_ID_CENTRALLINEACTIVE = -242004;

	public const int PROP_ID_VALUE = -242005;

	public const int PROP_ID_SPEED = -242006;

	public const int PROP_ID_NORMALIZEDPOSITION = -242007;

	public const int PROP_ID_CENTRALLINEPOS = -242008;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLeftColorChangeEvent;

	public Action<int> OnRightColorChangeEvent;

	public Action<bool> OnLeftEffectActiveChangeEvent;

	public Action<bool> OnRightEffectActiveChangeEvent;

	public Action<bool> OnCentralLineActiveChangeEvent;

	public Action<float> OnValueChangeEvent;

	public Action<float> OnSpeedChangeEvent;

	public Action<Vector3> OnNormalizedPositionChangeEvent;

	public Action<float> OnCentralLinePosChangeEvent;

	private int _003CLeftColor_003Ek__BackingField;

	private int _003CRightColor_003Ek__BackingField;

	private bool _003CLeftEffectActive_003Ek__BackingField;

	private bool _003CRightEffectActive_003Ek__BackingField;

	private bool _003CCentralLineActive_003Ek__BackingField;

	private float _003CValue_003Ek__BackingField;

	private float _003CSpeed_003Ek__BackingField;

	private Vector3 _003CNormalizedPosition_003Ek__BackingField;

	private float _003CCentralLinePos_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LeftColor
	{
		get
		{
			return _003CLeftColor_003Ek__BackingField;
		}
		private set
		{
			_003CLeftColor_003Ek__BackingField = value;
		}
	}

	public int RightColor
	{
		get
		{
			return _003CRightColor_003Ek__BackingField;
		}
		private set
		{
			_003CRightColor_003Ek__BackingField = value;
		}
	}

	public bool LeftEffectActive
	{
		get
		{
			return _003CLeftEffectActive_003Ek__BackingField;
		}
		private set
		{
			_003CLeftEffectActive_003Ek__BackingField = value;
		}
	}

	public bool RightEffectActive
	{
		get
		{
			return _003CRightEffectActive_003Ek__BackingField;
		}
		private set
		{
			_003CRightEffectActive_003Ek__BackingField = value;
		}
	}

	public bool CentralLineActive
	{
		get
		{
			return _003CCentralLineActive_003Ek__BackingField;
		}
		private set
		{
			_003CCentralLineActive_003Ek__BackingField = value;
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

	public float CentralLinePos
	{
		get
		{
			return _003CCentralLinePos_003Ek__BackingField;
		}
		private set
		{
			_003CCentralLinePos_003Ek__BackingField = value;
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

	public UGCScoreBarHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
