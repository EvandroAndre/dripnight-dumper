using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDUGC_CommonHudSwitchController : UIHUDUGC_InternalHudController
{
	public enum ECommonHudType
	{
		Crouch,
		Creep,
		Jump,
		Fire,
		MovingJoystick,
		TeammatesInfo,
		AttackGrenade,
		DefenceGrenade,
		SpeedUp
	}

	private Dictionary<int, List<UIBaseController>> m_CommonHuds;

	private UGCCommonHudSwitchHudRepItem m_LogicComponent;

	private Dictionary<int, bool> m_CommonHudSwitchs;

	private Dictionary<int, Action> m_PropertyActions;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	public void BindHud(ECommonHudType hudType, UIBaseController hud)
	{
	}

	private void OnHudUGCVisiablityChanged(ECommonHudType hudType, UIBaseController controller, bool cur)
	{
	}

	private void SetHudVisibility(ECommonHudType hudType, bool show)
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnCrouchSwitchChanged(bool cur)
	{
	}

	private void OnCreepSwitchChanged(bool cur)
	{
	}

	private void OnJumpSwitchChanged(bool cur)
	{
	}

	private void OnFireSwitchChanged(bool cur)
	{
	}

	private void OnMovingJoystickChanged(bool cur)
	{
	}

	private void OnTeammatesInfoChanged(bool cur)
	{
	}

	private void OnAttackGrenadeChanged(bool cur)
	{
	}

	private void OnDefenceGrenadeChanged(bool cur)
	{
	}

	private void OnSpeedUpChanged(bool cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
