using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSpeedRoyaleTeammatesInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudSpeedRoyaleTeammatesInfoView m_View;

	private Dictionary<uint, UIHudSpeedRoyaleTeammateGroup> m_VehicleGroups;

	private Dictionary<ulong, UIHudSpeedRoyaleTeammateItem> m_TeammatesWithAccountID;

	private Dictionary<uint, uint> m_PlayerIDToVehicleID;

	private UIModelMatch m_MatchModel;

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

	protected override void OnUIDestory()
	{
	}

	private UIHudSpeedRoyaleTeammateItem AddTeammateItem(BHGGAEEHJCO playerID)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private UIHudSpeedRoyaleTeammateItem GetTeammateItem(BHGGAEEHJCO pId)
	{
		return null;
	}

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnVehicleHPChanged(object[] data)
	{
	}

	private void OnVehicleDead(object[] data)
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	private void OnRemoveMapMark(object[] data)
	{
	}

	private void OnUpdateMapMark(object[] data)
	{
	}

	private void OnTeammateQuit(object[] data)
	{
	}

	private void OnTeamateVadStateChange(object[] data)
	{
	}

	private void OnTeamateStateChange(object[] data)
	{
	}

	private void OnTeamInfoGet(object[] data)
	{
	}

	private bool CheckToShow(BHGGAEEHJCO pId)
	{
		return false;
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
