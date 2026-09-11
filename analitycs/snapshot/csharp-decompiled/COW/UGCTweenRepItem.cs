using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTweenRepItem
{
	public const int PROP_ID_TARGETENTITY = -203000;

	public const int PROP_ID_PROPID = -203001;

	public const int PROP_ID_SRCVAL = -203002;

	public const int PROP_ID_DESTVAL = -203003;

	public const int PROP_ID_STYLE = -203004;

	public const int PROP_ID_CURVE = -203005;

	public const int PROP_ID_DURATION = -203006;

	public const int PROP_ID_REVERSE = -203007;

	public const int PROP_ID_CONTROLPOINTS = -203008;

	public const int PROP_ID_STARTTICKCOUNT = -203010;

	public const int PROP_ID_STARTVALUE = -203011;

	public const int PROP_ID_ENDVALUE = -203012;

	public const int PROP_ID_ELAPSEDPERCENTAGE = -203013;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTargetEntityChangeEvent;

	public Action<long> OnPropIDChangeEvent;

	public Action<List<object>> OnSrcValChangeEvent;

	public Action<List<object>> OnDestValChangeEvent;

	public Action<int> OnStyleChangeEvent;

	public Action<string> OnCurveChangeEvent;

	public Action<float> OnDurationChangeEvent;

	public Action<bool> OnReverseChangeEvent;

	public Action<List<object>> OnControlPointsChangeEvent;

	public Action<int> OnStartTickCountChangeEvent;

	public Action<object> OnStartValueChangeEvent;

	public Action<object> OnEndValueChangeEvent;

	public Action<float> OnElapsedPercentageChangeEvent;

	private string _003CTargetEntity_003Ek__BackingField;

	private long _003CPropID_003Ek__BackingField;

	private List<object> _003CSrcVal_003Ek__BackingField;

	private List<object> _003CDestVal_003Ek__BackingField;

	private int _003CStyle_003Ek__BackingField;

	private string _003CCurve_003Ek__BackingField;

	private float _003CDuration_003Ek__BackingField;

	private bool _003CReverse_003Ek__BackingField;

	private List<object> _003CControlPoints_003Ek__BackingField;

	private int _003CStartTickCount_003Ek__BackingField;

	private object _003CStartValue_003Ek__BackingField;

	private object _003CEndValue_003Ek__BackingField;

	private float _003CElapsedPercentage_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string TargetEntity
	{
		get
		{
			return _003CTargetEntity_003Ek__BackingField;
		}
		private set
		{
			_003CTargetEntity_003Ek__BackingField = value;
		}
	}

	public long PropID
	{
		get
		{
			return _003CPropID_003Ek__BackingField;
		}
		private set
		{
			_003CPropID_003Ek__BackingField = value;
		}
	}

	public List<object> SrcVal
	{
		get
		{
			return _003CSrcVal_003Ek__BackingField;
		}
		private set
		{
			_003CSrcVal_003Ek__BackingField = value;
		}
	}

	public List<object> DestVal
	{
		get
		{
			return _003CDestVal_003Ek__BackingField;
		}
		private set
		{
			_003CDestVal_003Ek__BackingField = value;
		}
	}

	public int Style
	{
		get
		{
			return _003CStyle_003Ek__BackingField;
		}
		private set
		{
			_003CStyle_003Ek__BackingField = value;
		}
	}

	public string Curve
	{
		get
		{
			return _003CCurve_003Ek__BackingField;
		}
		private set
		{
			_003CCurve_003Ek__BackingField = value;
		}
	}

	public float Duration
	{
		get
		{
			return _003CDuration_003Ek__BackingField;
		}
		private set
		{
			_003CDuration_003Ek__BackingField = value;
		}
	}

	public bool Reverse
	{
		get
		{
			return _003CReverse_003Ek__BackingField;
		}
		private set
		{
			_003CReverse_003Ek__BackingField = value;
		}
	}

	public List<object> ControlPoints
	{
		get
		{
			return _003CControlPoints_003Ek__BackingField;
		}
		private set
		{
			_003CControlPoints_003Ek__BackingField = value;
		}
	}

	public int StartTickCount
	{
		get
		{
			return _003CStartTickCount_003Ek__BackingField;
		}
		private set
		{
			_003CStartTickCount_003Ek__BackingField = value;
		}
	}

	public object StartValue
	{
		get
		{
			return _003CStartValue_003Ek__BackingField;
		}
		private set
		{
			_003CStartValue_003Ek__BackingField = value;
		}
	}

	public object EndValue
	{
		get
		{
			return _003CEndValue_003Ek__BackingField;
		}
		private set
		{
			_003CEndValue_003Ek__BackingField = value;
		}
	}

	public float ElapsedPercentage
	{
		get
		{
			return _003CElapsedPercentage_003Ek__BackingField;
		}
		private set
		{
			_003CElapsedPercentage_003Ek__BackingField = value;
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

	public UGCTweenRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
