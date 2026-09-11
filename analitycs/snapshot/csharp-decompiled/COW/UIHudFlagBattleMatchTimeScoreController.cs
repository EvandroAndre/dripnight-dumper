using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFlagBattleMatchTimeScoreController : UIBaseController
{
	private UIHudFlagBattleMatchTimeScoreView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private int targetScore;

	private int m_ShowEffectScore;

	private UIModelMatch m_ModelMatch;

	private List<GameObject> m_MyTeamEnergyStoneList;

	private List<GameObject> m_OppoTeamEnergyStoneList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitScoreUI()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnPhaseTimeChange(object[] data)
	{
	}

	private void OnEnergyStoneCountChange(object[] data)
	{
	}

	private void OnShowWinGOalTutorial(object[] param)
	{
	}

	private void Update()
	{
	}

	private void OnLeaderBoardClick()
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void ClearUIShow()
	{
	}

	private void PlayLocalOccupyEffect()
	{
	}

	private void PlayOppOccupyEffect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
