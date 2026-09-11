using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHUDRushingPetsMatchInfoController : UIBaseController
{
	private UIHUDRushingPetsMatchInfoView m_View;

	private ADJGKGIEEBL m_CurPhaseType;

	private float m_EndTime;

	private Dictionary<string, RushingPetsLevelData> m_LevelMap;

	private float m_LastSecond;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnNewPhase(object[] data)
	{
	}

	private void OnPhaseEndTimeCome(object[] data)
	{
	}

	private void OnRoundAndTypeCome(object[] data)
	{
	}

	private void OnRoundPlayerCountCome(object[] data)
	{
	}

	private void Update()
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void InitLevelData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
