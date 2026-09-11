using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLevelObjectRepItem
{
	public const int PROP_ID_NAME = -16000;

	public const int PROP_ID_ITEMID = -16001;

	public const int PROP_ID_ISNAVMESHSTATIC = -16002;

	public const int PROP_ID_ISDYNAMICOBSTACLE = -16003;

	public const int PROP_ID_ISASYNCLOAD = -16004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnNameChangeEvent;

	public Action<int> OnItemIDChangeEvent;

	public Action<bool> OnIsNavMeshStaticChangeEvent;

	public Action<bool> OnIsDynamicObstacleChangeEvent;

	public Action<bool> OnIsAsyncLoadChangeEvent;

	private string _003CName_003Ek__BackingField;

	private int _003CItemID_003Ek__BackingField;

	private bool _003CIsNavMeshStatic_003Ek__BackingField;

	private bool _003CIsDynamicObstacle_003Ek__BackingField;

	private bool _003CIsAsyncLoad_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		private set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public int ItemID
	{
		get
		{
			return _003CItemID_003Ek__BackingField;
		}
		private set
		{
			_003CItemID_003Ek__BackingField = value;
		}
	}

	public bool IsNavMeshStatic
	{
		get
		{
			return _003CIsNavMeshStatic_003Ek__BackingField;
		}
		private set
		{
			_003CIsNavMeshStatic_003Ek__BackingField = value;
		}
	}

	public bool IsDynamicObstacle
	{
		get
		{
			return _003CIsDynamicObstacle_003Ek__BackingField;
		}
		private set
		{
			_003CIsDynamicObstacle_003Ek__BackingField = value;
		}
	}

	public bool IsAsyncLoad
	{
		get
		{
			return _003CIsAsyncLoad_003Ek__BackingField;
		}
		private set
		{
			_003CIsAsyncLoad_003Ek__BackingField = value;
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

	public UGCLevelObjectRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
