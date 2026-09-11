using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICSPeakTournamentRankIconController : UIBaseController
{
	private UICSPeakTournamentRankIconView m_View;

	private GameObject m_VFX;

	public bool ShowUIFX;

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

	public void SetCSPeakTournamentViewData(uint points, uint rankPos = 0u, bool isMAXUnlimited = true)
	{
	}

	public void SetCSPeakTournamentRankViewData(AccountInfoBasic info)
	{
	}

	public void SetCSPeakTournamentHistoryViewData(PlayerCSPeakStatsHistory historyInfo)
	{
	}

	private void SetCSPeakTournamentRankIcon(uint points)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
