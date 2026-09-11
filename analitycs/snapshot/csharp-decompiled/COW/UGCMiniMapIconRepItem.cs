using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCMiniMapIconRepItem
{
	public const int PROP_ID_ICONPATH = -274000;

	public const int PROP_ID_SCALE = -274001;

	public const int PROP_ID_OFFSET = -274002;

	public const int PROP_ID_FOLLOWTARGET = -274003;

	public const int PROP_ID_DEPTH = -274004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnIconPathChangeEvent;

	public Action<float> OnScaleChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<int> OnDepthChangeEvent;

	private string _003CIconPath_003Ek__BackingField;

	private float _003CScale_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private int _003CDepth_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string IconPath
	{
		get
		{
			return _003CIconPath_003Ek__BackingField;
		}
		private set
		{
			_003CIconPath_003Ek__BackingField = value;
		}
	}

	public float Scale
	{
		get
		{
			return _003CScale_003Ek__BackingField;
		}
		private set
		{
			_003CScale_003Ek__BackingField = value;
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

	public string FollowTarget
	{
		get
		{
			return _003CFollowTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFollowTarget_003Ek__BackingField = value;
		}
	}

	public int Depth
	{
		get
		{
			return _003CDepth_003Ek__BackingField;
		}
		private set
		{
			_003CDepth_003Ek__BackingField = value;
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

	public UGCMiniMapIconRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
