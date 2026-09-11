using UnityEngine;

namespace COW;

public class UIMapThrowerSelectWndDragDropItem : UIDragDropItem
{
	public enum EMapThrowerDragDropType
	{
		EMapThrowerDragDropType_Start,
		EMapThrowerDragDropType_Failure,
		EMapThrowerDragDropType_Move,
		EMapThrowerDragDropType_End
	}

	private bool m_DragDropMove;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private UIWidget m_DragBoundsWidget;

	private float m_DragBoundsOffset;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void SetDragBounds(UIWidget widget, float offset)
	{
	}

	private void UpdateDragBounds()
	{
	}

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	protected override void OnDragDropEnd()
	{
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	protected override void OnPress(bool isPressed)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPress(bool P0)
	{
	}
}
