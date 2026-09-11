using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudLWMultiRoundTransitionController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LWRankScoreSortData> _003C_003E9__29_0;

		internal int _003COnRoundItemSetRank_003Eb__29_0(LWRankScoreSortData a, LWRankScoreSortData b)
		{
			return 0;
		}
	}

	private AMEEGELHGFG mGame;

	private UIHudLWMultiRoundTransitionView m_View;

	private Dictionary<byte, UIHudLWMultiRoundItemController> m_RoundTeamCtrls;

	private Dictionary<byte, TweenPosition> m_RankItemTweens;

	private JEFNJMJMAPF[] m_CacheScoreDatas;

	private int[] m_RoundAddScore;

	private BHGGAEEHJCO m_MvpPlayerId;

	private int m_PlayingAniCount;

	private bool m_InitGridFlag;

	private float m_Time;

	private uint m_DelayCallId;

	private bool m_RoundTeamKill;

	private bool m_HasGetResult;

	private byte m_SelfTeamId;

	private Transform[] m_Roots;

	private UIListAnimQueueItem[] m_AnimQueueItems;

	private RoundChangeStep m_RoundChangeStep;

	private string m_RoundEnd;

	private string m_RoundNext;

	private LWRankScoreSortData[] m_SortRankCache;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPlayerJoin(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void CheckAnimationEnd()
	{
	}

	private void ShowResult()
	{
	}

	private void ShowScores()
	{
	}

	private void PlayScoreChange()
	{
	}

	private void PlayUpDownAnimtion()
	{
	}

	private void OnRoundItemSetRank()
	{
	}

	private void OnRankChanged(byte teamId, int newRank, int oldRank, UIHudLWMultiRoundItemController item)
	{
	}

	private Vector3 GetRankItemPos(int oldRank, int newrank)
	{
		return default(Vector3);
	}

	private void PlayTweenPosition(TweenPosition tweenPos, Vector3 from, Vector3 to, float duration, EventDelegate.Callback end)
	{
	}

	private void OnTotalAnimFinished()
	{
	}

	private void RoundItemAnimationEnd(bool close)
	{
	}

	private void RoundAnimationEnd(bool isPlayed)
	{
	}

	private void ShowMvp()
	{
	}

	private void SetTeamKill(bool flag)
	{
	}

	private void HideScoreContainer()
	{
	}

	private void InitGridItems()
	{
	}

	private void SetTeamInfo(byte tid, List<BHGGAEEHJCO> playerids, Transform parent)
	{
	}

	private void ResetScoreAnimation()
	{
	}

	private void RefreshMatchPointNode()
	{
	}

	public void OnRoundResultShow(FHCKGNCNMCA msg)
	{
	}

	private void OnGameZoneIndexChanged(object[] data)
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnMatchPoint(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void OnAddScoreChanged(object[] data)
	{
	}

	private void SetUIVisibleByStep(AnimationStep step)
	{
	}

	public void ShowTest(int cmd)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
