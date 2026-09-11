using System;
using UnityEngine;

namespace COW;

public class PhotoWallDraggableFrame : MonoBehaviour
{
	private enum InteractionMode
	{
		None,
		Move,
		ResizeBottomLeft,
		ResizeTopLeft,
		ResizeTopRight,
		ResizeBottomRight
	}

	public UIWidget targetWidget;

	public UIWidget dragBoundsWidget;

	public UIWidget secondaryDragBoundsWidget;

	public bool enableDrag;

	public bool enableResize;

	public bool keepInsideBounds;

	public bool createBoxColliderIfMissing;

	public Action onWidgetChanged;

	public PhotoWallDraggableFrame forwardedDragTarget;

	public int minWidth;

	public int minHeight;

	public float cornerHitSize;

	private bool m_Pressed;

	private bool m_Started;

	private int m_TouchID;

	private Plane m_DragPlane;

	private Camera m_DragCamera;

	private Vector3 m_LastWorldPosition;

	private InteractionMode m_Mode;

	private bool m_IsForwardingDrag;

	private Rect m_PressLocalRect;

	private Vector2 m_FixedCornerInParent;

	private Vector2 m_ResizeAxisX;

	private Vector2 m_ResizeAxisY;

	private void Awake()
	{
	}

	public void RefreshBounds()
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	public void BeginForwardedDrag(int touchId, Vector3 pressWorldPosition, Camera dragCamera)
	{
	}

	public void UpdateForwardedDrag(int touchId, Vector2 screenPosition)
	{
	}

	public void EndForwardedDrag(int touchId)
	{
	}

	private void CacheComponents()
	{
	}

	private void EnsureBoxColliderExists()
	{
	}

	private Camera ResolveDragCamera()
	{
		return null;
	}

	private void NotifyWidgetChanged()
	{
	}

	private void ClampToBounds()
	{
	}

	private Rect GetDragBoundsRect(Transform relativeTo)
	{
		return default(Rect);
	}

	private void ResizeFromCorner(Vector2 dragPoint, Transform relativeTo)
	{
	}

	private Rect GetProjectedDragBoundsRect(Transform relativeTo, Vector2 origin, Vector2 axisX, Vector2 axisY)
	{
		return default(Rect);
	}

	private static Rect IntersectRects(Rect a, Rect b)
	{
		return default(Rect);
	}

	private Vector2 GetLocalPointInWidgetSpace(Vector3 worldPoint)
	{
		return default(Vector2);
	}

	private InteractionMode ResolveInteractionMode(Vector2 pressPoint, Rect targetRect)
	{
		return InteractionMode.None;
	}

	private static Vector2 GetFixedCornerForResize(InteractionMode mode, Rect targetRect)
	{
		return default(Vector2);
	}

	private Vector2 GetLocalPointOnDragPlane(Vector3 worldPoint, Transform relativeTo)
	{
		return default(Vector2);
	}

	private static Rect GetWidgetLocalRect(UIWidget widget)
	{
		return default(Rect);
	}

	private static Vector2 GetPointInRelativeSpace(Transform widgetTransform, Transform relativeTo, Vector2 widgetLocalPoint)
	{
		return default(Vector2);
	}

	private static Vector2 GetDirectionInRelativeSpace(Transform widgetTransform, Transform relativeTo, Vector3 widgetLocalDirection)
	{
		return default(Vector2);
	}

	private static Rect GetProjectedBoundsRect(UIWidget widget, Transform relativeTo, Vector2 origin, Vector2 axisX, Vector2 axisY)
	{
		return default(Rect);
	}

	private static int GetAxisSignX(InteractionMode mode)
	{
		return 0;
	}

	private static int GetAxisSignY(InteractionMode mode)
	{
		return 0;
	}

	private static Rect GetRectInSpace(UIWidget widget, Transform relativeTo)
	{
		return default(Rect);
	}
}
