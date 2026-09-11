using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHUDStationBattleTipController : UIBaseController
{
	public const uint VISIBILITY_STATE_KillCam_Hide = 1073741824u;

	public const uint VISIBILITY_STATE_Hide_All = 536870912u;

	public const uint VISIBILITY_STATE_MatchEnd_Hide = 268435456u;

	private UIHUDStationBattleTipView m_View;

	private float m_EndTime;

	private UITimeLabelHelper m_TimeHelper;

	private Dictionary<int, int> m_EnterStationUIDAndWaveIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshState(int stationUID, int stationWaveIndex, LDAFCKFGBBO teamState, float endTimeSec)
	{
	}

	private void Update()
	{
	}

	private void ProcessFightSound(int stationUID, int stationWaveIndex)
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
