using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCStropShelfRepItem
{
	public const int PROP_ID_SPEED = -207000;

	public const int PROP_ID_STARTPOSITION = -207001;

	public const int PROP_ID_ENDPOSITION = -207002;

	public const int PROP_ID_STROPID = -207003;

	public const int PROP_ID_GROUPID = -207004;

	public const int PROP_ID_ISEND = -207005;

	public const int PROP_ID_STARTPOSITIONVEC3 = -207006;

	public const int PROP_ID_ENDPOSITIONVEC3 = -207007;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnSpeedChangeEvent;

	public Action<string> OnStartPositionChangeEvent;

	public Action<string> OnEndPositionChangeEvent;

	public Action<int> OnStropIDChangeEvent;

	public Action<int> OnGroupIDChangeEvent;

	public Action<bool> OnIsEndChangeEvent;

	public Action<Vector3> OnStartPositionVec3ChangeEvent;

	public Action<Vector3> OnEndPositionVec3ChangeEvent;

	private float _003CSpeed_003Ek__BackingField;

	private string _003CStartPosition_003Ek__BackingField;

	private string _003CEndPosition_003Ek__BackingField;

	private int _003CStropID_003Ek__BackingField;

	private int _003CGroupID_003Ek__BackingField;

	private bool _003CIsEnd_003Ek__BackingField;

	private Vector3 _003CStartPositionVec3_003Ek__BackingField;

	private Vector3 _003CEndPositionVec3_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public string StartPosition
	{
		get
		{
			return _003CStartPosition_003Ek__BackingField;
		}
		private set
		{
			_003CStartPosition_003Ek__BackingField = value;
		}
	}

	public string EndPosition
	{
		get
		{
			return _003CEndPosition_003Ek__BackingField;
		}
		private set
		{
			_003CEndPosition_003Ek__BackingField = value;
		}
	}

	public int StropID
	{
		get
		{
			return _003CStropID_003Ek__BackingField;
		}
		private set
		{
			_003CStropID_003Ek__BackingField = value;
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

	public Vector3 StartPositionVec3
	{
		get
		{
			return _003CStartPositionVec3_003Ek__BackingField;
		}
		private set
		{
			_003CStartPositionVec3_003Ek__BackingField = value;
		}
	}

	public Vector3 EndPositionVec3
	{
		get
		{
			return _003CEndPositionVec3_003Ek__BackingField;
		}
		private set
		{
			_003CEndPositionVec3_003Ek__BackingField = value;
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

	public UGCStropShelfRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
