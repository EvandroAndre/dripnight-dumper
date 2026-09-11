using System;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class MapContentWinterlandIconController : UIManagedMapContentIconController
{
	private MapContentWinterlandIconView m_View;

	private uint? m_IslandState;

	private Vector3 m_CurMapLocalPos;

	private Func<Vector3, float, Vector3?> m_CalEdgeWorldPos;

	private Vector3? m_CurViewWorldPos;

	private float m_HideArrorTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void RestoreBeforeRecycled()
	{
	}

	public override void SetViewData(object viewData)
	{
	}

	public void SetCalEdgePosAction(Func<Vector3, float, Vector3?> getEdgeIntersectPoint)
	{
	}

	public uint GetLevelObjectId()
	{
		return 0u;
	}

	public override void SetLocalScale(Vector3 localScale)
	{
	}

	public override bool IconBoundsContainsPos(Vector3 position)
	{
		return false;
	}

	protected override Bounds? GetIconBounds()
	{
		return null;
	}

	private void UpdateEdgePos(CJILMLAAAKC state, bool stateChanged)
	{
	}

	public void SetIslandState(CJILMLAAAKC state, Vector3 mapPos, Vector3? viewWorldPos = null)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetLocalScale(Vector3 P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IconBoundsContainsPos(Vector3 P0)
	{
		return false;
	}

	public Bounds? _003C_003EiFixBaseProxy_GetIconBounds()
	{
		return null;
	}
}
