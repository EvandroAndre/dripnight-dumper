using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCEradicateZoneRepItem
{
	public const int PROP_ID_STARTTIME = -392000;

	public const int PROP_ID_SHRINKTIME = -392001;

	public const int PROP_ID_DAMAGETIMESPAN = -392002;

	public const int PROP_ID_DAMAGEVALUE = -392003;

	public const int PROP_ID_PLAYERS = -392004;

	public const int PROP_ID_CLOSETIME = -392005;

	public const int PROP_ID_GROUPID = -392006;

	public const int PROP_ID_STARTRADIUS = -392007;

	public const int PROP_ID_ISEND = -392008;

	public const int PROP_ID_STATE = -392009;

	public const int PROP_ID_SHRINKENDTIME = -392010;

	public const int PROP_ID_EFFECTCOLOR = -392011;

	public const int PROP_ID_ENDRADIUS = -392012;

	public const int PROP_ID_STARTSHRINKTIME = -392013;

	public const int PROP_ID_DAMAGETIMEINTERVAL = -392014;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnStartTimeChangeEvent;

	public Action<int> OnShrinkTimeChangeEvent;

	public Action<float> OnDamageTimeSpanChangeEvent;

	public Action<int> OnDamageValueChangeEvent;

	public Action<List<object>> OnPlayersChangeEvent;

	public Action<int> OnCloseTimeChangeEvent;

	public Action<int> OnGroupIDChangeEvent;

	public Action<float> OnStartRadiusChangeEvent;

	public Action<bool> OnIsEndChangeEvent;

	public Action<int> OnStateChangeEvent;

	public Action<int> OnShrinkEndTimeChangeEvent;

	public Action<int> OnEffectColorChangeEvent;

	public Action<float> OnEndRadiusChangeEvent;

	public Action<int> OnStartShrinkTimeChangeEvent;

	public Action<int> OnDamageTimeIntervalChangeEvent;

	private int _003CStartTime_003Ek__BackingField;

	private int _003CShrinkTime_003Ek__BackingField;

	private float _003CDamageTimeSpan_003Ek__BackingField;

	private int _003CDamageValue_003Ek__BackingField;

	private List<object> _003CPlayers_003Ek__BackingField;

	private int _003CCloseTime_003Ek__BackingField;

	private int _003CGroupID_003Ek__BackingField;

	private float _003CStartRadius_003Ek__BackingField;

	private bool _003CIsEnd_003Ek__BackingField;

	private int _003CState_003Ek__BackingField;

	private int _003CShrinkEndTime_003Ek__BackingField;

	private int _003CEffectColor_003Ek__BackingField;

	private float _003CEndRadius_003Ek__BackingField;

	private int _003CStartShrinkTime_003Ek__BackingField;

	private int _003CDamageTimeInterval_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int StartTime
	{
		get
		{
			return _003CStartTime_003Ek__BackingField;
		}
		private set
		{
			_003CStartTime_003Ek__BackingField = value;
		}
	}

	public int ShrinkTime
	{
		get
		{
			return _003CShrinkTime_003Ek__BackingField;
		}
		private set
		{
			_003CShrinkTime_003Ek__BackingField = value;
		}
	}

	public float DamageTimeSpan
	{
		get
		{
			return _003CDamageTimeSpan_003Ek__BackingField;
		}
		private set
		{
			_003CDamageTimeSpan_003Ek__BackingField = value;
		}
	}

	public int DamageValue
	{
		get
		{
			return _003CDamageValue_003Ek__BackingField;
		}
		private set
		{
			_003CDamageValue_003Ek__BackingField = value;
		}
	}

	public List<object> Players
	{
		get
		{
			return _003CPlayers_003Ek__BackingField;
		}
		private set
		{
			_003CPlayers_003Ek__BackingField = value;
		}
	}

	public int CloseTime
	{
		get
		{
			return _003CCloseTime_003Ek__BackingField;
		}
		private set
		{
			_003CCloseTime_003Ek__BackingField = value;
		}
	}

	public int GroupID
	{
		get
		{
			return _003CGroupID_003Ek__BackingField;
		}
		private set
		{
			_003CGroupID_003Ek__BackingField = value;
		}
	}

	public float StartRadius
	{
		get
		{
			return _003CStartRadius_003Ek__BackingField;
		}
		private set
		{
			_003CStartRadius_003Ek__BackingField = value;
		}
	}

	public bool IsEnd
	{
		get
		{
			return _003CIsEnd_003Ek__BackingField;
		}
		private set
		{
			_003CIsEnd_003Ek__BackingField = value;
		}
	}

	public int State
	{
		get
		{
			return _003CState_003Ek__BackingField;
		}
		private set
		{
			_003CState_003Ek__BackingField = value;
		}
	}

	public int ShrinkEndTime
	{
		get
		{
			return _003CShrinkEndTime_003Ek__BackingField;
		}
		private set
		{
			_003CShrinkEndTime_003Ek__BackingField = value;
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

	public float EndRadius
	{
		get
		{
			return _003CEndRadius_003Ek__BackingField;
		}
		private set
		{
			_003CEndRadius_003Ek__BackingField = value;
		}
	}

	public int StartShrinkTime
	{
		get
		{
			return _003CStartShrinkTime_003Ek__BackingField;
		}
		private set
		{
			_003CStartShrinkTime_003Ek__BackingField = value;
		}
	}

	public int DamageTimeInterval
	{
		get
		{
			return _003CDamageTimeInterval_003Ek__BackingField;
		}
		private set
		{
			_003CDamageTimeInterval_003Ek__BackingField = value;
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

	public UGCEradicateZoneRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
