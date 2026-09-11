using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHudLayoutRepItem
{
	public const int PROP_ID_ALPHA = -294000;

	public const int PROP_ID_LAYOUTTYPE = -294001;

	public const int PROP_ID_CONTENTORIGIN = -294002;

	public const int PROP_ID_FILLDIRECTION = -294003;

	public const int PROP_ID_CELLSIZE = -294004;

	public const int PROP_ID_SPACE = -294005;

	public const int PROP_ID_CONSTRAINT = -294006;

	public const int PROP_ID_CONSTRAINTCOUNT = -294007;

	public const int PROP_ID_OFFSETUPDOWN = -294008;

	public const int PROP_ID_OFFSETLEFTRIGHT = -294009;

	public const int PROP_ID_SORTTYPE = -294010;

	public const int PROP_ID_IGNOREINACTIVE = -294011;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnAlphaChangeEvent;

	public Action<int> OnLayoutTypeChangeEvent;

	public Action<int> OnContentOriginChangeEvent;

	public Action<int> OnFillDirectionChangeEvent;

	public Action<Vector2> OnCellSizeChangeEvent;

	public Action<Vector2> OnSpaceChangeEvent;

	public Action<int> OnConstraintChangeEvent;

	public Action<int> OnConstraintCountChangeEvent;

	public Action<Vector2> OnOffsetUpDownChangeEvent;

	public Action<Vector2> OnOffsetLeftRightChangeEvent;

	public Action<int> OnSortTypeChangeEvent;

	public Action<bool> OnIgnoreInactiveChangeEvent;

	private float _003CAlpha_003Ek__BackingField;

	private int _003CLayoutType_003Ek__BackingField;

	private int _003CContentOrigin_003Ek__BackingField;

	private int _003CFillDirection_003Ek__BackingField;

	private Vector2 _003CCellSize_003Ek__BackingField;

	private Vector2 _003CSpace_003Ek__BackingField;

	private int _003CConstraint_003Ek__BackingField;

	private int _003CConstraintCount_003Ek__BackingField;

	private Vector2 _003COffsetUpDown_003Ek__BackingField;

	private Vector2 _003COffsetLeftRight_003Ek__BackingField;

	private int _003CSortType_003Ek__BackingField;

	private bool _003CIgnoreInactive_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Alpha
	{
		get
		{
			return _003CAlpha_003Ek__BackingField;
		}
		private set
		{
			_003CAlpha_003Ek__BackingField = value;
		}
	}

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

	public int SortType
	{
		get
		{
			return _003CSortType_003Ek__BackingField;
		}
		private set
		{
			_003CSortType_003Ek__BackingField = value;
		}
	}

	public bool IgnoreInactive
	{
		get
		{
			return _003CIgnoreInactive_003Ek__BackingField;
		}
		private set
		{
			_003CIgnoreInactive_003Ek__BackingField = value;
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

	public UGCHudLayoutRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
