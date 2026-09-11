using System;
using UnityEngine;

namespace COW;

public class UGCTimelineScrollView : UIScrollView
{
	public enum Direction
	{
		None,
		Horizontal,
		Vertical
	}

	private Direction lockedDire;

	public Action BindDragFinished;

	public Direction CurrentDire => Direction.None;

	protected bool shouldVerticalMove => false;

	public new virtual Bounds bounds => default(Bounds);

	public override void Init()
	{
	}

	public void MoveHorizontal(float x)
	{
	}

	public override void MoveRelative(Vector3 relative)
	{
	}

	public void OnDragStarted()
	{
	}

	public void OnDragFinished()
	{
	}

	public bool RestrictWithinBounds()
	{
		return false;
	}

	public override bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical, bool tryFakeBounds = false)
	{
		return false;
	}

	public Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max, bool snapToTopOfGrid = false, UIWidget.Pivot contentPivot = UIWidget.Pivot.TopLeft)
	{
		return default(Vector3);
	}

	private Bounds CalculateRelativeWidgetBounds(Transform relativeTo, Transform content, bool considerInactive, bool considerChildren = true)
	{
		return default(Bounds);
	}

	private void CalculateRelativeWidgetBounds(Transform content, bool considerInactive, bool isRoot, ref Matrix4x4 toLocal, ref Vector3 vMin, ref Vector3 vMax, ref bool isSet, bool considerChildren)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_MoveRelative(Vector3 P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_RestrictWithinBounds(bool P0, bool P1, bool P2, bool P3)
	{
		return false;
	}
}
