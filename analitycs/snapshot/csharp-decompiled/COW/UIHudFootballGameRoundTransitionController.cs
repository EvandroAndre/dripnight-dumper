using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFootballGameRoundTransitionController : UIBaseController
{
	private enum EResultType
	{
		Win = 1,
		Lose
	}

	private UIHudFootBallGameRoundTransitionView m_View;

	private string m_EntityID;

	private int m_MyScoreCached;

	private int m_OppoScoreCached;

	private float m_Time;

	private bool m_ScoreAnimTick;

	private List<GameObject> m_IncomeItemList;

	private UILabel m_WinTitle;

	private UILabel m_LoseTitle;

	private bool m_InitTeamInfo;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void InitTeamInfo()
	{
	}

	private void ShowScores()
	{
	}

	private void ResetScoreAnimation()
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
