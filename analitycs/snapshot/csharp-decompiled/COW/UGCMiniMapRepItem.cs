using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCMiniMapRepItem
{
	public const int PROP_ID_CENTER = -273000;

	public const int PROP_ID_MAPSIZE = -273001;

	public const int PROP_ID_USEDEPTHMAP = -273002;

	private UGCEntityDataStore _repDataMgr;

	public Action<Vector3> OnCenterChangeEvent;

	public Action<int> OnMapSizeChangeEvent;

	public Action<bool> OnUseDepthMapChangeEvent;

	private Vector3 _003CCenter_003Ek__BackingField;

	private int _003CMapSize_003Ek__BackingField;

	private bool _003CUseDepthMap_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public Vector3 Center
	{
		get
		{
			return _003CCenter_003Ek__BackingField;
		}
		private set
		{
			_003CCenter_003Ek__BackingField = value;
		}
	}

	public int MapSize
	{
		get
		{
			return _003CMapSize_003Ek__BackingField;
		}
		private set
		{
			_003CMapSize_003Ek__BackingField = value;
		}
	}

	public bool UseDepthMap
	{
		get
		{
			return _003CUseDepthMap_003Ek__BackingField;
		}
		private set
		{
			_003CUseDepthMap_003Ek__BackingField = value;
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

	public UGCMiniMapRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
