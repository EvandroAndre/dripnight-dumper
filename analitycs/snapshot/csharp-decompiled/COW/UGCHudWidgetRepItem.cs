using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudWidgetRepItem
{
	public const int PROP_ID_HUDACTIVESELF = -13000;

	public const int PROP_ID_ANCHORPOSITION = -13001;

	public const int PROP_ID_WIDTH = -13002;

	public const int PROP_ID_HEIGHT = -13003;

	public const int PROP_ID_ANGLE = -13004;

	public const int PROP_ID_HOSTHUDENTITYID = -13005;

	public const int PROP_ID_FILEID = -13006;

	public const int PROP_ID_HOSTHUDENTITY = -13007;

	public const int PROP_ID_ANCHORMIN = -13008;

	public const int PROP_ID_ANCHORMAX = -13009;

	public const int PROP_ID_SIZEDELTA = -13010;

	public const int PROP_ID_PIVOT = -13011;

	public const int PROP_ID_DEPTH = -13012;

	public const int PROP_ID_PARENTWIDGETFILEID = -13013;

	public const int PROP_ID_CHILDINDEX = -13014;

	public const int PROP_ID_PARENTENTITYID = -13015;

	public const int PROP_ID_UNIQUEID = -13016;

	public const int PROP_ID_PRIORITY = -13017;

	public const int PROP_ID_ACTUALPOSITION = -13018;

	public const int PROP_ID_SIZE = -13019;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnHudActiveSelfChangeEvent;

	public Action<Vector3> OnAnchorPositionChangeEvent;

	public Action<float> OnAngleChangeEvent;

	public Action<string> OnHostHudEntityIDChangeEvent;

	public Action<int> OnFileIDChangeEvent;

	public Action<string> OnHostHudEntityChangeEvent;

	public Action<Vector2> OnAnchorMinChangeEvent;

	public Action<Vector2> OnAnchorMaxChangeEvent;

	public Action<Vector2> OnSizeDeltaChangeEvent;

	public Action<Vector2> OnPivotChangeEvent;

	public Action<int> OnDepthChangeEvent;

	public Action<int> OnParentWidgetFileIDChangeEvent;

	public Action<int> OnChildIndexChangeEvent;

	public Action<string> OnParentEntityIDChangeEvent;

	public Action<string> OnUniqueIDChangeEvent;

	public Action<int> OnPriorityChangeEvent;

	public Action<Vector3> OnActualPositionChangeEvent;

	public Action<Vector2> OnSizeChangeEvent;

	private bool _003CHudActiveSelf_003Ek__BackingField;

	private Vector3 _003CAnchorPosition_003Ek__BackingField;

	private float _003CAngle_003Ek__BackingField;

	private string _003CHostHudEntityID_003Ek__BackingField;

	private int _003CFileID_003Ek__BackingField;

	private string _003CHostHudEntity_003Ek__BackingField;

	private Vector2 _003CAnchorMin_003Ek__BackingField;

	private Vector2 _003CAnchorMax_003Ek__BackingField;

	private Vector2 _003CSizeDelta_003Ek__BackingField;

	private Vector2 _003CPivot_003Ek__BackingField;

	private int _003CDepth_003Ek__BackingField;

	private int _003CParentWidgetFileID_003Ek__BackingField;

	private int _003CChildIndex_003Ek__BackingField;

	private string _003CParentEntityID_003Ek__BackingField;

	private string _003CUniqueID_003Ek__BackingField;

	private int _003CPriority_003Ek__BackingField;

	private Vector3 _003CActualPosition_003Ek__BackingField;

	private Vector2 _003CSize_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool HudActiveSelf
	{
		get
		{
			return _003CHudActiveSelf_003Ek__BackingField;
		}
		private set
		{
			_003CHudActiveSelf_003Ek__BackingField = value;
		}
	}

	public Vector3 AnchorPosition
	{
		get
		{
			return _003CAnchorPosition_003Ek__BackingField;
		}
		private set
		{
			_003CAnchorPosition_003Ek__BackingField = value;
		}
	}

	public float Angle
	{
		get
		{
			return _003CAngle_003Ek__BackingField;
		}
		private set
		{
			_003CAngle_003Ek__BackingField = value;
		}
	}

	public string HostHudEntityID
	{
		get
		{
			return _003CHostHudEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CHostHudEntityID_003Ek__BackingField = value;
		}
	}

	public int FileID
	{
		get
		{
			return _003CFileID_003Ek__BackingField;
		}
		private set
		{
			_003CFileID_003Ek__BackingField = value;
		}
	}

	public string HostHudEntity
	{
		get
		{
			return _003CHostHudEntity_003Ek__BackingField;
		}
		private set
		{
			_003CHostHudEntity_003Ek__BackingField = value;
		}
	}

	public Vector2 AnchorMin
	{
		get
		{
			return _003CAnchorMin_003Ek__BackingField;
		}
		private set
		{
			_003CAnchorMin_003Ek__BackingField = value;
		}
	}

	public Vector2 AnchorMax
	{
		get
		{
			return _003CAnchorMax_003Ek__BackingField;
		}
		private set
		{
			_003CAnchorMax_003Ek__BackingField = value;
		}
	}

	public Vector2 SizeDelta
	{
		get
		{
			return _003CSizeDelta_003Ek__BackingField;
		}
		private set
		{
			_003CSizeDelta_003Ek__BackingField = value;
		}
	}

	public Vector2 Pivot
	{
		get
		{
			return _003CPivot_003Ek__BackingField;
		}
		private set
		{
			_003CPivot_003Ek__BackingField = value;
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

	public int ParentWidgetFileID
	{
		get
		{
			return _003CParentWidgetFileID_003Ek__BackingField;
		}
		private set
		{
			_003CParentWidgetFileID_003Ek__BackingField = value;
		}
	}

	public int ChildIndex
	{
		get
		{
			return _003CChildIndex_003Ek__BackingField;
		}
		private set
		{
			_003CChildIndex_003Ek__BackingField = value;
		}
	}

	public string ParentEntityID
	{
		get
		{
			return _003CParentEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CParentEntityID_003Ek__BackingField = value;
		}
	}

	public string UniqueID
	{
		get
		{
			return _003CUniqueID_003Ek__BackingField;
		}
		private set
		{
			_003CUniqueID_003Ek__BackingField = value;
		}
	}

	public int Priority
	{
		get
		{
			return _003CPriority_003Ek__BackingField;
		}
		private set
		{
			_003CPriority_003Ek__BackingField = value;
		}
	}

	public Vector3 ActualPosition
	{
		get
		{
			return _003CActualPosition_003Ek__BackingField;
		}
		private set
		{
			_003CActualPosition_003Ek__BackingField = value;
		}
	}

	public Vector2 Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		private set
		{
			_003CSize_003Ek__BackingField = value;
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

	public UGCHudWidgetRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
