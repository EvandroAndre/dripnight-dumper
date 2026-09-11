using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudLayout : UGCHudWidget
{
	public enum Corner
	{
		UpperLeft,
		UpperRight,
		LowerLeft,
		LowerRight
	}

	public enum Axis
	{
		Horizontal,
		Vertical
	}

	public enum Cons
	{
		Flexible,
		FixedRowCount,
		FixedColumnCount
	}

	public enum LayoutSortType
	{
		SortByHierarchy,
		SortByPriorityHighToLow,
		SortByPriorityLowToHigh
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UGCUIBehaviour child;

		internal bool _003CRemoveChild_003Eb__0(UGCUIBehaviour e)
		{
			return false;
		}
	}

	private int m_LayoutType;

	private Corner m_ContentOrigin;

	private Axis m_FillDirection;

	private Vector2 m_CellSize;

	private Vector2 m_Space;

	private Cons m_Constraint;

	private Vector2 m_OffsetUpDown;

	private Vector2 m_OffsetLeftRight;

	private int m_ConstraintCount;

	private List<UGCUIBehaviour> m_Children;

	private readonly List<UGCUIBehaviour> m_SubtreeRefreshChildren;

	private bool m_NeedRefresh;

	private LayoutSortType m_SortType;

	private bool m_IgnoreInactive;

	public bool NeedRefresh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int SortType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IgnoreInactive => false;

	public List<UGCUIBehaviour> Children => null;

	public int LayoutType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ContentOrigin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int FillDirection
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector2 CellSize
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 Space
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public int Constraint
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ConstraintCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Vector2 OffsetUpDown
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 OffsetLeftRight
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public void SetIgnoreInactive(bool value)
	{
	}

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void AddChild(UGCUIBehaviour child)
	{
	}

	public void RemoveChild(UGCUIBehaviour child)
	{
	}

	private void OnChildActiveChanged()
	{
	}

	public override void RefreshGrid()
	{
	}

	public void RefreshLayout()
	{
	}

	private void Update()
	{
	}

	public void InorderSetSizeAndPosition(Transform trs)
	{
	}

	public void RefreshGridLayout()
	{
	}

	protected bool SetGridChildAlongAxis(UGCUIBehaviour child, int posX, int posY)
	{
		return false;
	}

	public void RefreshFillLayout()
	{
	}

	private int _003CRefreshLayout_003Eb__61_0(UGCUIBehaviour a, UGCUIBehaviour b)
	{
		return 0;
	}

	private int _003CRefreshLayout_003Eb__61_1(UGCUIBehaviour a, UGCUIBehaviour b)
	{
		return 0;
	}

	private int _003CRefreshLayout_003Eb__61_2(UGCUIBehaviour a, UGCUIBehaviour b)
	{
		return 0;
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_RefreshGrid()
	{
	}
}
