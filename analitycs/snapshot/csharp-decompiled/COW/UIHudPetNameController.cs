using COW.GamePlay;
using COW.HUD;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPetNameController : UIHudEntityPosControllerBase
{
	private UIHudPetNameView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private bool m_ShowForRole;

	private bool m_PetShowing;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnRegisterEvents()
	{
	}

	protected override void OnUnRegisterEvents()
	{
	}

	public override void BindTarget(Entity e)
	{
	}

	protected override Vector3 GetRefPos(Entity e)
	{
		return default(Vector3);
	}

	protected override void UpdateTargetPlayer()
	{
	}

	private void UpdateHideForRole()
	{
	}

	private void OnObserverChange(object[] data)
	{
	}

	private void OnPetDelete(object[] data)
	{
	}

	private void OnPetShowHide(object[] data)
	{
	}

	private void UpdateShowHide()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnRegisterEvents()
	{
	}

	public void _003C_003EiFixBaseProxy_BindTarget(Entity P0)
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_GetRefPos(Entity P0)
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_UpdateTargetPlayer()
	{
	}
}
