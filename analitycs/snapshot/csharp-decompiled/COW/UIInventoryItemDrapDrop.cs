using UnityEngine;

namespace COW;

public class UIInventoryItemDrapDrop : UIDragDropItem
{
	private static ItemDragDropEvent ItemDDEvent;

	private UIInventoryItemControllerBase m_BaseController;

	private int m_SiblingIndex;

	protected override void Start()
	{
	}

	private bool CanDragInOfflineMode()
	{
		return false;
	}

	protected override void OnDragStart()
	{
	}

	protected override void OnDragDropStart()
	{
	}

	protected override void ForceStopDragging(GameObject go)
	{
	}

	public void OnDragFocus()
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	private void OnResetSiblingIndex()
	{
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	public void _003C_003EiFixBaseProxy_ForceStopDragging(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}
}
