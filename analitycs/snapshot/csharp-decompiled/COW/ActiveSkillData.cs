using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

[Serializable]
public class ActiveSkillData : CSVBaseData
{
	private class AfterParseDataContext
	{
		public string[] ActiveSkillTableHeader;
	}

	private uint _003CSkillID_003Ek__BackingField;

	private float _003CCastingTime_003Ek__BackingField;

	private float[] m_KeepingTimes;

	private float _003CPreStopTime_003Ek__BackingField;

	private bool _003CCanInterrupt_003Ek__BackingField;

	private string _003CConflictSkillTypes_003Ek__BackingField;

	private bool _003CKeepAlways_003Ek__BackingField;

	private float _003CCancelSkillDelayTime_003Ek__BackingField;

	private float _003CDragButton_003Ek__BackingField;

	private float _003CContinuousCDtime_003Ek__BackingField;

	private uint _003CMaxRetriggerTimes_003Ek__BackingField;

	private float _003CAreaIndicatorRadius_003Ek__BackingField;

	private float _003CAreaIndicatorXAngle_003Ek__BackingField;

	private string _003CSkillHUDButtonHint_003Ek__BackingField;

	private uint _003CCallObjectDataID_003Ek__BackingField;

	private float _003CCDTime_003Ek__BackingField;

	public float RefreshCdConditionTimeLimit;

	public float AutoStartCdDuration;

	private List<float> m_RetriggerCD;

	public ResourceID CastAnimMaleResID;

	public ResourceID CastAnimFemaleResID;

	public ResourceID CastCameraAnimResID;

	private ActiveSkillJsonData m_JsonData;

	[NonSerialized]
	private AfterParseDataContext context;

	public uint SkillID
	{
		get
		{
			return _003CSkillID_003Ek__BackingField;
		}
		private set
		{
			_003CSkillID_003Ek__BackingField = value;
		}
	}

	public float CastingTime
	{
		get
		{
			return _003CCastingTime_003Ek__BackingField;
		}
		private set
		{
			_003CCastingTime_003Ek__BackingField = value;
		}
	}

	public float PreStopTime
	{
		get
		{
			return _003CPreStopTime_003Ek__BackingField;
		}
		private set
		{
			_003CPreStopTime_003Ek__BackingField = value;
		}
	}

	public int PhaseCount => 0;

	public bool CanInterrupt
	{
		get
		{
			return _003CCanInterrupt_003Ek__BackingField;
		}
		private set
		{
			_003CCanInterrupt_003Ek__BackingField = value;
		}
	}

	public string ConflictSkillTypes
	{
		get
		{
			return _003CConflictSkillTypes_003Ek__BackingField;
		}
		private set
		{
			_003CConflictSkillTypes_003Ek__BackingField = value;
		}
	}

	public bool KeepAlways
	{
		get
		{
			return _003CKeepAlways_003Ek__BackingField;
		}
		private set
		{
			_003CKeepAlways_003Ek__BackingField = value;
		}
	}

	public float CancelSkillDelayTime
	{
		get
		{
			return _003CCancelSkillDelayTime_003Ek__BackingField;
		}
		private set
		{
			_003CCancelSkillDelayTime_003Ek__BackingField = value;
		}
	}

	public float DragButton
	{
		get
		{
			return _003CDragButton_003Ek__BackingField;
		}
		private set
		{
			_003CDragButton_003Ek__BackingField = value;
		}
	}

	public float ContinuousCDtime
	{
		get
		{
			return _003CContinuousCDtime_003Ek__BackingField;
		}
		set
		{
			_003CContinuousCDtime_003Ek__BackingField = value;
		}
	}

	public uint MaxRetriggerTimes
	{
		get
		{
			return _003CMaxRetriggerTimes_003Ek__BackingField;
		}
		set
		{
			_003CMaxRetriggerTimes_003Ek__BackingField = value;
		}
	}

	public float AreaIndicatorRadius
	{
		get
		{
			return _003CAreaIndicatorRadius_003Ek__BackingField;
		}
		set
		{
			_003CAreaIndicatorRadius_003Ek__BackingField = value;
		}
	}

	public float AreaIndicatorXAngle
	{
		get
		{
			return _003CAreaIndicatorXAngle_003Ek__BackingField;
		}
		set
		{
			_003CAreaIndicatorXAngle_003Ek__BackingField = value;
		}
	}

	public string SkillHUDButtonHint
	{
		get
		{
			return _003CSkillHUDButtonHint_003Ek__BackingField;
		}
		set
		{
			_003CSkillHUDButtonHint_003Ek__BackingField = value;
		}
	}

	public uint CallObjectDataID
	{
		get
		{
			return _003CCallObjectDataID_003Ek__BackingField;
		}
		set
		{
			_003CCallObjectDataID_003Ek__BackingField = value;
		}
	}

	public float CDTime
	{
		get
		{
			return _003CCDTime_003Ek__BackingField;
		}
		set
		{
			_003CCDTime_003Ek__BackingField = value;
		}
	}

	public ActiveSkillJsonData JsonData => null;

	public float GetRetriggerCD(int retriggerTimes)
	{
		return 0f;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public float GetKeepingTime(int phase)
	{
		return 0f;
	}

	public float GetMaxKeepingTime()
	{
		return 0f;
	}

	public float GetTotalKeepingTime()
	{
		return 0f;
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public ActiveSkillData DeepClone()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
