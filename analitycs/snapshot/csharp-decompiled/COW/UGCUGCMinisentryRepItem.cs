using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCUGCMinisentryRepItem
{
	public const int PROP_ID_TEAMID = -2507000;

	public const int PROP_ID_HP = -2507001;

	public const int PROP_ID_MAXHP = -2507002;

	public const int PROP_ID_ATTACK = -2507003;

	public const int PROP_ID_ATTACKINTERVAL = -2507004;

	public const int PROP_ID_ATTACKRANGE = -2507005;

	public const int PROP_ID_DEFENSE = -2507006;

	public const int PROP_ID_TARGET = -2507007;

	public const int PROP_ID_ROT_ANGLES = -2507008;

	public const int PROP_ID_STATUS = -2507009;

	public const int PROP_ID_OBJECTID = -2507010;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnTeamIDChangeEvent;

	public Action<int> OnMaxHPChangeEvent;

	public Action<int> OnTargetChangeEvent;

	public Action<int> OnRot_AnglesChangeEvent;

	public Action<int> OnStatusChangeEvent;

	public Action<int> OnObjectIDChangeEvent;

	private int _003CTeamID_003Ek__BackingField;

	private int _003CMaxHP_003Ek__BackingField;

	private int _003CTarget_003Ek__BackingField;

	private int _003CRot_Angles_003Ek__BackingField;

	private int _003CStatus_003Ek__BackingField;

	private int _003CObjectID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int TeamID
	{
		get
		{
			return _003CTeamID_003Ek__BackingField;
		}
		private set
		{
			_003CTeamID_003Ek__BackingField = value;
		}
	}

	public int MaxHP
	{
		get
		{
			return _003CMaxHP_003Ek__BackingField;
		}
		private set
		{
			_003CMaxHP_003Ek__BackingField = value;
		}
	}

	public int Target
	{
		get
		{
			return _003CTarget_003Ek__BackingField;
		}
		private set
		{
			_003CTarget_003Ek__BackingField = value;
		}
	}

	public int Rot_Angles
	{
		get
		{
			return _003CRot_Angles_003Ek__BackingField;
		}
		private set
		{
			_003CRot_Angles_003Ek__BackingField = value;
		}
	}

	public int Status
	{
		get
		{
			return _003CStatus_003Ek__BackingField;
		}
		private set
		{
			_003CStatus_003Ek__BackingField = value;
		}
	}

	public int ObjectID
	{
		get
		{
			return _003CObjectID_003Ek__BackingField;
		}
		private set
		{
			_003CObjectID_003Ek__BackingField = value;
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

	public UGCUGCMinisentryRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
