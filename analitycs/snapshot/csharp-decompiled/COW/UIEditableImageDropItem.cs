using System;
using UnityEngine;

namespace COW;

public class UIEditableImageDropItem : UIDragDropItem
{
	private Transform curIconTrans;

	private Action curDropEndAction;

	private Action curOnDropMoveAction;

	private Action curOnDropStartAction;

	private float originDistance;

	public EditableIconDropType CurType;

	public float MinScale;

	public float MaxScale;

	public void InitDropItem(UIWidget widgetBound, EditableIconDropType dropType, Transform iconTrans, Action dropEndAction = null, Action onDropMoveAction = null, bool isVertial = false, Action dropStartAction = null)
	{
	}

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	private Vector3 GetNewWorldPos(Transform moveObjTrans, Vector2 delta)
	{
		return default(Vector3);
	}

	protected override void OnDragDropEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropEnd()
	{
	}
}
