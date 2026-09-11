using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHPbarHudRepItem
{
	public const int PROP_ID_OPENSTATE = -126000;

	public const int PROP_ID_OBJECTNAME = -126001;

	public const int PROP_ID_CURRENTVALUE = -126002;

	public const int PROP_ID_MAXVALUE = -126003;

	public const int PROP_ID_OFFSET = -126004;

	public const int PROP_ID_LENGTH = -126005;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<string> OnObjectNameChangeEvent;

	public Action<int> OnCurrentValueChangeEvent;

	public Action<int> OnMaxValueChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<int> OnLengthChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CObjectName_003Ek__BackingField;

	private int _003CCurrentValue_003Ek__BackingField;

	private int _003CMaxValue_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private int _003CLength_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public string ObjectName
	{
		get
		{
			return _003CObjectName_003Ek__BackingField;
		}
		private set
		{
			_003CObjectName_003Ek__BackingField = value;
		}
	}

	public int CurrentValue
	{
		get
		{
			return _003CCurrentValue_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentValue_003Ek__BackingField = value;
		}
	}

	public int MaxValue
	{
		get
		{
			return _003CMaxValue_003Ek__BackingField;
		}
		private set
		{
			_003CMaxValue_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public int Length
	{
		get
		{
			return _003CLength_003Ek__BackingField;
		}
		private set
		{
			_003CLength_003Ek__BackingField = value;
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

	public UGCHPbarHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
