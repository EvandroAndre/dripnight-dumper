using UnityEngine;

namespace COW;

public class ProfileCustomDragDropItem : UIDragDropItem
{
	public UIProfileCustomCollectionItemBaseController ParentCtrl;

	public void InitConfig(GameObject template, UIProfileCustomCollectionItemBaseController parentCtrl, Restriction restrict)
	{
	}

	public override bool StartDragging()
	{
		return false;
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	private void AjustCloned()
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
