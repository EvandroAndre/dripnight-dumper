using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCCustomHudRepItem
{
	public const int PROP_ID_OPENSTATE = -22000;

	public const int PROP_ID_PREFABID = -22001;

	public const int PROP_ID_MAXWIDGETID = -22002;

	public const int PROP_ID_DEPTH = -22003;

	public const int PROP_ID_OPENPLAYERVIEW = -22004;

	public const int PROP_ID_WORLDPOSITION = -22005;

	public const int PROP_ID_INSCENE = -22006;

	public const int PROP_ID_ROTATION = -22007;

	public const int PROP_ID_SCALE = -22008;

	public const int PROP_ID_HUDASSETID = -22009;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnPrefabIDChangeEvent;

	public Action<int> OnMaxWidgetIDChangeEvent;

	public Action<int> OnDepthChangeEvent;

	public Action<bool> OnOpenPlayerViewChangeEvent;

	public Action<Vector3> OnWorldPositionChangeEvent;

	public Action<bool> OnInSceneChangeEvent;

	public Action<Vector3> OnRotationChangeEvent;

	public Action<Vector3> OnScaleChangeEvent;

	public Action<string> OnHudAssetIDChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CPrefabID_003Ek__BackingField;

	private int _003CMaxWidgetID_003Ek__BackingField;

	private int _003CDepth_003Ek__BackingField;

	private bool _003COpenPlayerView_003Ek__BackingField;

	private Vector3 _003CWorldPosition_003Ek__BackingField;

	private bool _003CInScene_003Ek__BackingField;

	private Vector3 _003CRotation_003Ek__BackingField;

	private Vector3 _003CScale_003Ek__BackingField;

	private string _003CHudAssetID_003Ek__BackingField;

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

	public int PrefabID
	{
		get
		{
			return _003CPrefabID_003Ek__BackingField;
		}
		private set
		{
			_003CPrefabID_003Ek__BackingField = value;
		}
	}

	public int MaxWidgetID
	{
		get
		{
			return _003CMaxWidgetID_003Ek__BackingField;
		}
		private set
		{
			_003CMaxWidgetID_003Ek__BackingField = value;
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

	public bool OpenPlayerView
	{
		get
		{
			return _003COpenPlayerView_003Ek__BackingField;
		}
		private set
		{
			_003COpenPlayerView_003Ek__BackingField = value;
		}
	}

	public Vector3 WorldPosition
	{
		get
		{
			return _003CWorldPosition_003Ek__BackingField;
		}
		private set
		{
			_003CWorldPosition_003Ek__BackingField = value;
		}
	}

	public bool InScene
	{
		get
		{
			return _003CInScene_003Ek__BackingField;
		}
		private set
		{
			_003CInScene_003Ek__BackingField = value;
		}
	}

	public Vector3 Rotation
	{
		get
		{
			return _003CRotation_003Ek__BackingField;
		}
		private set
		{
			_003CRotation_003Ek__BackingField = value;
		}
	}

	public Vector3 Scale
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

	public string HudAssetID
	{
		get
		{
			return _003CHudAssetID_003Ek__BackingField;
		}
		private set
		{
			_003CHudAssetID_003Ek__BackingField = value;
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

	public UGCCustomHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
