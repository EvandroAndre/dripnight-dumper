using System;
using UnityEngine;

namespace COW;

public class UISparkPetInputHandler : UIItemInputHandler
{
	private Camera m_RaycastCamera;

	private Collider m_TargetCollider;

	public Action OnRotateEndCallback;

	protected override void OnDestroy()
	{
	}

	protected override void OnRotateEnd()
	{
	}

	public void Init(Collider targetCollider)
	{
	}

	public void SetRaycastCamera(Camera camera)
	{
	}

	public void SetTargetCollider(Collider collider)
	{
	}

	public override bool IsTargetArea(Vector2 screenPosition)
	{
		return false;
	}

	private bool IsRaycastHitSelf(Vector3 screenPosition)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRotateEnd()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsTargetArea(Vector2 P0)
	{
		return false;
	}
}
