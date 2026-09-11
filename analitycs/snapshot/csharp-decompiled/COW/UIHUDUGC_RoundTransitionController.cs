using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_RoundTransitionController : UIHUDUGC_InternalHudController
{
	private enum EResultType
	{
		Win = 1,
		Lose
	}

	private enum ETransitionStage
	{
		CurRound,
		NextRound
	}

	private struct RoundIncomeData
	{
		public string title;

		public int incomeValue;
	}

	private UIHUDUGC_RoundTransitionView m_View;

	private UGCRoundTransitionHudRepItem m_ViewData;

	private int m_MyScoreCached;

	private int m_OppoScoreCached;

	private float m_Time;

	private bool m_ScoreAnimTick;

	private List<GameObject> m_IncomeItemList;

	private int leftScoreOldValue;

	private int rightScoreOldValue;

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

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void ShowScores()
	{
	}

	private void ResetScoreAnimation()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnTransitionStageChanged(int cur)
	{
	}

	private void OnLeftTeamScoreChanged(int cur)
	{
	}

	private void OnRightTeamScoreChanged(int cur)
	{
	}

	private void OnLeftTeamNameChanged(string cur)
	{
	}

	private void OnRightTeamNameChanged(string cur)
	{
	}

	private void OnLeftIconSpriteNameChanged(string cur)
	{
	}

	private void OnRightIconSpriteNameChanged(string cur)
	{
	}

	private void OnResultTypeChanged(int cur)
	{
	}

	private void OnWinLocChanged(string cur)
	{
	}

	private void OnLoseLocChanged(string cur)
	{
	}

	private void OnRoundIncomeTitleChanged(string cur)
	{
	}

	private void OnRoundIncomeChanged(int cur)
	{
	}

	private void OnRoundIncomeDetailTitleListChanged(List<object> cur)
	{
	}

	private void OnRoundIncomeDetailListChanged(List<object> cur)
	{
	}

	private void OnMVPChanged(string cur)
	{
	}

	private void OnNextRoundIndexChanged(int cur)
	{
	}

	private void OnIsMatchPointChanged(bool cur)
	{
	}

	private void OnIsLastRoundChanged(bool cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
