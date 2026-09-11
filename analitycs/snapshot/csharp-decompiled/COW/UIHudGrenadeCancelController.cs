using GCommon;
using UnityEngine;

namespace COW;

public class UIHudGrenadeCancelController : UIHudButtonBaseController
{
	private UIHudCancelView m_View;

	private Vector3 m_pos;

	private Vector3 m_Offset;

	private Vector3 m_OffsetSocial2;

	public Vector3 GetOffset()
	{
		return default(Vector3);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ResetVisibilityOnOpenHud()
	{
	}

	private void OnDragUseGrenade(object[] param)
	{
	}

	private void OnDragUseIceWall(object[] param)
	{
	}

	private void OnChangeVisibleBySpecialPos(object[] param)
	{
	}

	public bool WeaponOnHandIsIceWall()
	{
		return false;
	}

	public bool ItemOnHandIsLobbySocial()
	{
		return false;
	}

	protected override string GetMappingName()
	{
		return null;
	}

	public void SetDefaultPos(Vector3 pos)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
