using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRoomOBNameController : UIBaseController
{
	private UIHudRoomOBNameView m_View;

	private BHGGAEEHJCO m_BindPlayerID;

	private Player m_Player;

	private Camera m_GameCamera;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void UnbindPlayer()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	private void ApplyRoomOBTeamBgColors(byte scTeamId)
	{
	}

	private void ApplyBindData(PlayerData bindData)
	{
	}

	private void ApplyFromPlayer(Player p)
	{
	}

	private void SyncHpFromPlayer(Player p)
	{
	}

	private void OnBoundPlayerHpChanged(GEvent data)
	{
	}

	private void OnBoundPlayerMaxHpChanged(object[] data)
	{
	}

	private void OnBoundPlayerKnockdownStateChanged(uint playerID)
	{
	}

	private void LateUpdate()
	{
	}

	private void OnRoomOBIsCamTypeFree(bool isFree)
	{
	}

	private void OnRoomOBToggleNameplate()
	{
	}

	private static Vector3 GetObserverReferencePosition()
	{
		return default(Vector3);
	}

	private bool IsBindPlayerWithinRoomOBNearbyRange()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
