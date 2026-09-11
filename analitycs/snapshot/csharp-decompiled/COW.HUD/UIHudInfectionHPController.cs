using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudInfectionHPController : UIHudNameBaseController, IHudNameController
{
	private UIHudInfectionHPView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private float m_Counter;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	public void UnbindPlayer()
	{
	}

	public void OnHpChanged(GEvent data)
	{
	}

	private void Update()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}
}
