using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAIRepItem
{
	public const int PROP_ID_HP = -68000;

	public const int PROP_ID_HPMAX = -68001;

	public const int PROP_ID_HOSTTEAMENTITY = -68002;

	public const int PROP_ID_SPAWNPOS = -68003;

	public const int PROP_ID_ATTACKDAMAGE = -68004;

	public const int PROP_ID_ATTACKINTERVAL = -68005;

	public const int PROP_ID_ATTACKRANGE = -68006;

	public const int PROP_ID_WANDERRANGE = -68007;

	public const int PROP_ID_DETECTRANGE = -68008;

	public const int PROP_ID_RUNSPEED = -68009;

	public const int PROP_ID_ENABLEDEADDROP = -68010;

	public const int PROP_ID_ISGOD = -68011;

	public const int PROP_ID_INJUREDSCALE = -68012;

	public const int PROP_ID_AITYPE = -68013;

	public const int PROP_ID_CANCHASEENEMY = -68014;

	public const int PROP_ID_ACTIONTYPE = -68015;

	public const int PROP_ID_PATHID = -68016;

	public const int PROP_ID_CHASETARGET = -68017;

	public const int PROP_ID_ATTACKTARGET = -68018;

	public const int PROP_ID_SPAWNPOSVEC3 = -68019;

	public const int PROP_ID_TEAMINDEX = -68020;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnTeamIndexChangeEvent;

	private int _003CTeamIndex_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int TeamIndex
	{
		get
		{
			return _003CTeamIndex_003Ek__BackingField;
		}
		private set
		{
			_003CTeamIndex_003Ek__BackingField = value;
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

	public UGCAIRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
