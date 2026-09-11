using UnityEngine;

namespace COW;

public class UINewVaultEmoteDragDropItem : UIDragDropItem
{
	public EmoteDragDropItemType type;

	private UINewVaultEmoteSlotController slotController;

	private UINewVaultEmoteItemController emoteItemController;

	private UINewVaultEmoteSlotItemController NewSlotItemController;

	protected override void Start()
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

	public override void OnDragOverObject(GameObject obj)
	{
	}

	private void VaultEmoteStartDrag()
	{
	}

	public void _003C_003EiFixBaseProxy_Start()
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

	public void _003C_003EiFixBaseProxy_OnDragOverObject(GameObject P0)
	{
	}
}
