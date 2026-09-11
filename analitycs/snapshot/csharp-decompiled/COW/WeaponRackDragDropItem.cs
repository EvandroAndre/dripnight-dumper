using System;
using UnityEngine;

namespace COW;

public class WeaponRackDragDropItem : UIDragDropItem
{
	public WeaponSkinBaseInfo DragDropBasicInfo;

	public UILobbyWeaponSlotController m_Slot;

	public Action m_ActionOnStart;

	protected override void Start()
	{
	}

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	public override void OnDragOverObject(GameObject go)
	{
	}

	public void OnDragOut()
	{
	}

	public override bool StartDragging()
	{
		return false;
	}

	public void OnApplicationPause(bool pauseState)
	{
	}

	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDragOverObject(GameObject P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return false;
	}
}
