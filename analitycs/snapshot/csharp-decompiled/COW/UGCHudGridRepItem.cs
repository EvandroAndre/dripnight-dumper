using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudGridRepItem
{
	public const int PROP_ID_LAYOUTTYPE = -266000;

	public const int PROP_ID_CONTENTORIGIN = -266001;

	public const int PROP_ID_FILLDIRECTION = -266002;

	public const int PROP_ID_CELLSIZE = -266003;

	public const int PROP_ID_SPACE = -266004;

	public const int PROP_ID_CONSTRAINT = -266005;

	public const int PROP_ID_CONSTRAINTCOUNT = -266006;

	public const int PROP_ID_OFFSETUPDOWN = -266007;

	public const int PROP_ID_OFFSETLEFTRIGHT = -266008;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLayoutTypeChangeEvent;

	public Action<int> OnContentOriginChangeEvent;

	public Action<int> OnFillDirectionChangeEvent;

	public Action<Vector2> OnCellSizeChangeEvent;

	public Action<Vector2> OnSpaceChangeEvent;

	public Action<int> OnConstraintChangeEvent;

	public Action<int> OnConstraintCountChangeEvent;

	public Action<Vector2> OnOffsetUpDownChangeEvent;

	public Action<Vector2> OnOffsetLeftRightChangeEvent;

	private int _003CLayoutType_003Ek__BackingField;

	private int _003CContentOrigin_003Ek__BackingField;

	private int _003CFillDirection_003Ek__BackingField;

	private Vector2 _003CCellSize_003Ek__BackingField;

	private Vector2 _003CSpace_003Ek__BackingField;

	private int _003CConstraint_003Ek__BackingField;

	private int _003CConstraintCount_003Ek__BackingField;

	private Vector2 _003COffsetUpDown_003Ek__BackingField;

	private Vector2 _003COffsetLeftRight_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LayoutType
	{
		get
		{
			return _003CLayoutType_003Ek__BackingField;
		}
		private set
		{
			_003CLayoutType_003Ek__BackingField = value;
		}
	}

	public int ContentOrigin
	{
		get
		{
			return _003CContentOrigin_003Ek__BackingField;
		}
		private set
		{
			_003CContentOrigin_003Ek__BackingField = value;
		}
	}

	public int FillDirection
	{
		get
		{
			return _003CFillDirection_003Ek__BackingField;
		}
		private set
		{
			_003CFillDirection_003Ek__BackingField = value;
		}
	}

	public Vector2 CellSize
	{
		get
		{
			return _003CCellSize_003Ek__BackingField;
		}
		private set
		{
			_003CCellSize_003Ek__BackingField = value;
		}
	}

	public Vector2 Space
	{
		get
		{
			return _003CSpace_003Ek__BackingField;
		}
		private set
		{
			_003CSpace_003Ek__BackingField = value;
		}
	}

	public int Constraint
	{
		get
		{
			return _003CConstraint_003Ek__BackingField;
		}
		private set
		{
			_003CConstraint_003Ek__BackingField = value;
		}
	}

	public int ConstraintCount
	{
		get
		{
			return _003CConstraintCount_003Ek__BackingField;
		}
		private set
		{
			_003CConstraintCount_003Ek__BackingField = value;
		}
	}

	public Vector2 OffsetUpDown
	{
		get
		{
			return _003COffsetUpDown_003Ek__BackingField;
		}
		private set
		{
			_003COffsetUpDown_003Ek__BackingField = value;
		}
	}

	public Vector2 OffsetLeftRight
	{
		get
		{
			return _003COffsetLeftRight_003Ek__BackingField;
		}
		private set
		{
			_003COffsetLeftRight_003Ek__BackingField = value;
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

	public UGCHudGridRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
