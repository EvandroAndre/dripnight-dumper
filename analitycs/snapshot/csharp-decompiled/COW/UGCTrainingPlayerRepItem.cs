using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCTrainingPlayerRepItem
{
	public const int PROP_ID_HP = -459000;

	public const int PROP_ID_HPMAX = -459001;

	public const int PROP_ID_HELMETLEVEL = -459002;

	public const int PROP_ID_VESTLEVEL = -459003;

	public const int PROP_ID_MOVEMODE = -459004;

	public const int PROP_ID_ONLYHEADSHOT = -459005;

	public const int PROP_ID_POSITION = -459006;

	public const int PROP_ID_MOVESPEED = -459007;

	public const int PROP_ID_INITDIRECTION = -459008;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnHPChangeEvent;

	public Action<int> OnHPMaxChangeEvent;

	public Action<int> OnHelmetLevelChangeEvent;

	public Action<int> OnVestLevelChangeEvent;

	public Action<int> OnMoveModeChangeEvent;

	public Action<bool> OnOnlyHeadshotChangeEvent;

	public Action<Vector3> OnPositionChangeEvent;

	public Action<float> OnMoveSpeedChangeEvent;

	public Action<Vector3> OnInitDirectionChangeEvent;

	private int _003CHP_003Ek__BackingField;

	private int _003CHPMax_003Ek__BackingField;

	private int _003CHelmetLevel_003Ek__BackingField;

	private int _003CVestLevel_003Ek__BackingField;

	private int _003CMoveMode_003Ek__BackingField;

	private bool _003COnlyHeadshot_003Ek__BackingField;

	private Vector3 _003CPosition_003Ek__BackingField;

	private float _003CMoveSpeed_003Ek__BackingField;

	private Vector3 _003CInitDirection_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int HP
	{
		get
		{
			return _003CHP_003Ek__BackingField;
		}
		private set
		{
			_003CHP_003Ek__BackingField = value;
		}
	}

	public int HPMax
	{
		get
		{
			return _003CHPMax_003Ek__BackingField;
		}
		private set
		{
			_003CHPMax_003Ek__BackingField = value;
		}
	}

	public int HelmetLevel
	{
		get
		{
			return _003CHelmetLevel_003Ek__BackingField;
		}
		private set
		{
			_003CHelmetLevel_003Ek__BackingField = value;
		}
	}

	public int VestLevel
	{
		get
		{
			return _003CVestLevel_003Ek__BackingField;
		}
		private set
		{
			_003CVestLevel_003Ek__BackingField = value;
		}
	}

	public int MoveMode
	{
		get
		{
			return _003CMoveMode_003Ek__BackingField;
		}
		private set
		{
			_003CMoveMode_003Ek__BackingField = value;
		}
	}

	public bool OnlyHeadshot
	{
		get
		{
			return _003COnlyHeadshot_003Ek__BackingField;
		}
		private set
		{
			_003COnlyHeadshot_003Ek__BackingField = value;
		}
	}

	public Vector3 Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		private set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	public float MoveSpeed
	{
		get
		{
			return _003CMoveSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CMoveSpeed_003Ek__BackingField = value;
		}
	}

	public Vector3 InitDirection
	{
		get
		{
			return _003CInitDirection_003Ek__BackingField;
		}
		private set
		{
			_003CInitDirection_003Ek__BackingField = value;
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

	public UGCTrainingPlayerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
