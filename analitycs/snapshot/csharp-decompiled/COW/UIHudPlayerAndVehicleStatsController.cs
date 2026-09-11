using System.Collections.Generic;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPlayerAndVehicleStatsController : UIBaseController
{
	private UIHudPlayerAndVehicleStatsView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private uint m_BindVehicleShieldId;

	private Player m_Player;

	private UIModelMatch m_ModelMatch;

	private uint m_UpdateCallID;

	private List<UIHudVehicleBufferController> m_BufferCtrls;

	public readonly float ColorPlayerStatsAlpha;

	public readonly Color ColorDisableEquipmentStat;

	public readonly Vector3 VehicleHPBarThumbOffset;

	private UIHudVehicleLevelStatsController m_LevelStatsCtrl;

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

	private void OnLocalVehicleUseSkillItem(object[] data)
	{
	}

	private void OnLocalVehicleGetBuff(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	private void OnPlayerPostInit(object[] data)
	{
	}

	private void OnHPChanged(GEvent data)
	{
	}

	private void OnMaxHPChanged(object[] args)
	{
	}

	private void OnVehicleShieldHPChanged(object[] data)
	{
	}

	private void OnGetOnVehicle(object[] data)
	{
	}

	private void RefreshHP(bool isDead)
	{
	}

	private void RefreshVehicleShieldHP(uint shieldHP, uint maxHP)
	{
	}

	private string MakeHPStr(uint cur, uint max)
	{
		return null;
	}

	private void OnAddPlayer(object[] data)
	{
	}

	private void OnObservePlayer(object[] data)
	{
	}

	private void BindAndRefreshVehicle()
	{
	}

	private void OnRemoveMapMark(object[] data)
	{
	}

	private void OnUpdateMapMark(object[] data)
	{
	}

	private void RefreshSkillStatus()
	{
	}

	private void OnVehicleEquipmentChanged(object[] data)
	{
	}

	private void RefreshVehicleEquipmentStats()
	{
	}

	private void RefreshVehicleEquipmentStats(LevelVehicle veh)
	{
	}

	private void UpdateBufferView()
	{
	}

	private void OnRouteChange(int routeID)
	{
	}

	private void OnLevelChange(object[] args)
	{
	}

	private void SetLevelView(bool showAnim = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
