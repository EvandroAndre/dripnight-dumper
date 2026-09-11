using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudHealRobotController : UIBaseController
{
	private UIHudHealRobotView m_View;

	private List<Player> m_TmpPendingPlayers;

	private BHGGAEEHJCO m_TargetRescueID;

	private BHGGAEEHJCO m_LockedRescueID;

	private bool m_IsRescuringVisile;

	private GAABJIDHPNB m_HealRobot;

	private bool m_IsHudActive;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void UpdateHealRobotLockPlayer(bool isActive)
	{
	}

	private void Update()
	{
	}

	private void InternalCollectPendingPlayers(Player localPlayer, List<Player> pendingPlayers)
	{
	}

	private void OnCanRescureChanged(object[] data)
	{
	}

	private void OnRescureBtnClicked()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
