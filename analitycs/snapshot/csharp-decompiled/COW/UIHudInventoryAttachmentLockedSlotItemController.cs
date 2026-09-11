using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryAttachmentLockedSlotItemController : UIHudInventoryAttachmentSlotItemController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIOpen()
	{
	}

	public override void SetDrapDropType(OOOMOIADBFJ type, GameObject emptyBG, UIInventoryItemDragDropContainer parentContainer)
	{
	}

	public override void OnDrapStart()
	{
	}

	public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_SetDrapDropType(OOOMOIADBFJ P0, GameObject P1, UIInventoryItemDragDropContainer P2)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDrapStart()
	{
	}

	public new bool _003C_003EiFixBaseProxy_OnDrapRelease(UIInventoryItemDragDropContainer P0)
	{
		return false;
	}
}
