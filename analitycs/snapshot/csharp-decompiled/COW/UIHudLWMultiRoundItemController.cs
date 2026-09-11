using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudLWMultiRoundItemController : UIBaseController
{
	private UIHudLWMultiRoundItemView m_View;

	private GameObject[] m_ScoreGameObjects;

	private UILabel[] m_ScoreLabels;

	private List<BHGGAEEHJCO> m_PlayerIDs;

	private int m_Score;

	private int m_Rank;

	private int m_OldRank;

	private bool m_IsSelf;

	private string m_AnimationEnter;

	private string m_AnimationFlash;

	private string m_AnimationBig;

	private string m_AnimationSmall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public int GetOldRank()
	{
		return 0;
	}

	public int GetRank()
	{
		return 0;
	}

	public void InitItem(byte teamId, List<BHGGAEEHJCO> playerids, int defaultRank, bool isSelf)
	{
	}

	private void InitPlayer(int i, BHGGAEEHJCO playerID)
	{
	}

	public void BeforeAnimationRestUI()
	{
	}

	public void SetScoreInfoAnimation(int score, int[] roundAddScore)
	{
	}

	private void PlayAnimation(string name)
	{
	}

	public void PlayRankChange(bool isUp)
	{
	}

	public void ShowMvp(BHGGAEEHJCO mvpPlayerId)
	{
	}

	public void AfterAnimation(bool close)
	{
	}

	private void ShowScore(int[] roundAddScore)
	{
	}

	private void SetTeamCololr(int index)
	{
	}

	public void SetRank(int rank)
	{
	}

	public void RefreshRank()
	{
	}

	private void SetRankView(int rank)
	{
	}

	public UIListAnimQueueItem GetAnimQueueItem()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
