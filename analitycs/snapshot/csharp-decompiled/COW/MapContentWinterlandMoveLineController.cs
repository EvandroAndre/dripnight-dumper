using GCommon;
using UnityEngine;
using message;

namespace COW;

public class MapContentWinterlandMoveLineController : UIManagedMapContentIconController
{
	private MapContentWinterlandMoveLineView m_View;

	private uint? m_IslandState;

	private Vector3? m_StartPos;

	private Vector3 m_RotUp;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object viewData)
	{
	}

	protected override void RestoreBeforeRecycled()
	{
	}

	public override void SetLocalScale(Vector3 localScale)
	{
	}

	public override void SetLocalRotation(Quaternion localRotation)
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

	public void Show(Vector3 start, Vector3 end)
	{
	}

	public void SetIslandState(CJILMLAAAKC state, Vector3 startPos, Vector3 endPos)
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

	public void _003C_003EiFixBaseProxy_SetLocalRotation(Quaternion P0)
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
