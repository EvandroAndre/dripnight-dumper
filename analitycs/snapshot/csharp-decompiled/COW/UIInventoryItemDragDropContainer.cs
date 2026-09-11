using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIInventoryItemDragDropContainer : UIDragDropContainer
{
	public UIInventoryItemDragDropContainer ParentContainer;

	public OOOMOIADBFJ ContainerType;

	public object ExtraData;

	protected void OnDragOver(GameObject dragged)
	{
	}

	protected void OnDragOut(GameObject dragged)
	{
	}
}
