using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudGrid : UGCUIPanel
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UGCUIBehaviour> _003C_003E9__45_0;

		internal int _003CRefreshGrid_003Eb__45_0(UGCUIBehaviour a, UGCUIBehaviour b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
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

	public override void RefreshGrid()
	{
	}

	public void RefreshGridLayout()
	{
	}

	protected void SetGridChildAlongAxis(UGCUIBehaviour child, int posX, int posY)
	{
	}

	public void RefreshFillLayout()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_RefreshGrid()
	{
	}
}
