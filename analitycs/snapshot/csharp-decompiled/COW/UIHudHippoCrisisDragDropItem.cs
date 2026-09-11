using UnityEngine;

namespace COW;

public class UIHudHippoCrisisDragDropItem : UIDragDropItem
{
	private UIHippoCrisisCanDragItem m_Ctrl;

	public void Init(UIHippoCrisisCanDragItem ctrl)
	{
	}

	public override bool StartDragging()
	{
		return false;
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}
}
