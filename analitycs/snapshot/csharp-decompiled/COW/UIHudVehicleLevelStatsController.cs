using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudVehicleLevelStatsController : UIBaseController
{
	private UIHudVehicleLevelStatsView m_View;

	private List<CSVBaseData> m_Datas;

	private Dictionary<uint, UIWidget> m_AlphaNodes;

	private Dictionary<uint, GameObject> m_FilledNodes;

	private Dictionary<uint, UILabel> m_LevelDescNodes;

	private const uint MaxLevel = 4u;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void BindView()
	{
	}

	public void SetView(uint routeID, uint level, bool showAnim)
	{
	}

	private VehicleLevelDescribe GetData(uint routeID)
	{
		return null;
	}

	private string GetLevelDesc(uint routeID, uint level)
	{
		return null;
	}

	private void SwitchTips(bool show)
	{
	}

	private void OnVehicleIconClick()
	{
	}

	private void _003CSwitchTips_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
