using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudDreamlandBoyPetHPController : UIHudNameBaseController
{
	private UIHudDreamlandBoyPetHPView m_View;

	private LevelDreamlandBoyPet m_BindPet;

	private float m_RaycastShowCheckInterval;

	private float m_NextRaycastShowCheckTime;

	private bool m_IsRaycastShow;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPet(uint petUID)
	{
	}

	public void UnBindPet()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	private bool NeedShow()
	{
		return false;
	}

	protected override void UpdateNamePosition()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private void UpdateHP()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
