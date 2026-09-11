using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSpawnBoxRepItem
{
	public const int PROP_ID_SPAWNPOINTCOUNT = -2510000;

	public const int PROP_ID_TEAMINDEX = -2510001;

	public const int PROP_ID_TEAMSEQ = -2510002;

	public const int PROP_ID_ISMOVEMENTLOCKED = -2510003;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnSpawnPointCountChangeEvent;

	public Action<int> OnTeamIndexChangeEvent;

	public Action<bool> OnIsMovementLockedChangeEvent;

	private int _003CSpawnPointCount_003Ek__BackingField;

	private int _003CTeamIndex_003Ek__BackingField;

	private bool _003CIsMovementLocked_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int SpawnPointCount
	{
		get
		{
			return _003CSpawnPointCount_003Ek__BackingField;
		}
		private set
		{
			_003CSpawnPointCount_003Ek__BackingField = value;
		}
	}

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

	public bool IsMovementLocked
	{
		get
		{
			return _003CIsMovementLocked_003Ek__BackingField;
		}
		private set
		{
			_003CIsMovementLocked_003Ek__BackingField = value;
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

	public UGCSpawnBoxRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
