using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCHudWidget : UGCUIWidget
{
	public enum HorizontalAlignmentEnum
	{
		Left,
		Center,
		Right
	}

	public enum VerticalAlignmentEnum
	{
		Top,
		Center,
		Bottom
	}

	public Action<HorizontalAlignmentEnum> onHorizontalAlignmentChangedAction;

	public Action<VerticalAlignmentEnum> onVerticalAlignmentChangedAction;

	private HorizontalAlignmentEnum m_HorizontalAlignment;

	private VerticalAlignmentEnum m_VerticalAlignment;

	private UIWidget.Pivot m_AlignmentPivot;

	private bool m_CustomAdapt;

	public bool ColliderEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UGCHudWidget ParentWidget => null;

	public HorizontalAlignmentEnum AlignmentHorizontal
	{
		get
		{
			return HorizontalAlignmentEnum.Left;
		}
		set
		{
		}
	}

	public VerticalAlignmentEnum AlignmentVertical
	{
		get
		{
			return VerticalAlignmentEnum.Top;
		}
		set
		{
		}
	}

	public Vector2 AlignmentPivotOffset => default(Vector2);

	public float LocalEulerAngleZ
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool CustomAdapt
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsFirstChild => false;

	private void UpdateAnchor()
	{
	}

	private void SetHorizontalAlignmentDirty()
	{
	}

	private void SetVerticalAlignmentDirty()
	{
	}

	protected override void OnInternalDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnInternalDestroy()
	{
	}
}
