using System;
using UnityEngine;

namespace COW;

public class UIHudSceneEditItemDragDropItem : UIDragDropItem
{
	public Transform OutRangeTrans;

	public Action OnAddPrefab;

	protected override void OnDragDropEnd()
	{
	}

	public override bool StartDragging()
	{
		return false;
	}

	protected override void OnDragDropMove(Vector2 delta)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropEnd()
	{
	}

	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDragDropMove(Vector2 P0)
	{
	}
}
