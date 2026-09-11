using UnityEngine;

namespace COW;

public class UIMapAstrolGateDragDropItem : UIDragDropItem
{
	public enum EMapAstrolGateDragDropType
	{
		EMapAstrolGateDragDropType_Start,
		EMapAstrolGateDragDropType_Failure,
		EMapAstrolGateDragDropType_Move,
		EMapAstrolGateDragDropType_End
	}

	private bool m_DragDropMove;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

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

	public void InitByMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	private Vector3 ClampToAstrolGateTeleportRadius(Vector3 worldPos)
	{
		return default(Vector3);
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
