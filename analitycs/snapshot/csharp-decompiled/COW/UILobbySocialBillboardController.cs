using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbySocialBillboardController : UIBaseController
{
	private struct LeaderBoardEntry
	{
		public uint PlayerID;

		public string PlayerName;

		public uint WinStreak;
	}

	public enum EOtherContainerState
	{
		Empty,
		LeaderBoard,
		Provoke
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LeaderBoardEntry> _003C_003E9__29_0;

		internal int _003CCollectLeaderBoardEntries_003Eb__29_0(LeaderBoardEntry a, LeaderBoardEntry b)
		{
			return 0;
		}
	}

	private const uint DEFAULT_TITLE_OUTLINE_COLOR = 2886712063u;

	private const uint PRIME_TITLE_OUTLINE_COLOR = 2504273151u;

	private UILobbySocialBillboardView m_View;

	private UIModelMatch m_ModelMatch;

	private UIInGameRankBillboardController.JIOLBAOFPOD m_CurRankType;

	private bool m_IsInitedRankType;

	private List<ulong> m_CurTopUserID;

	private List<UIPrivilegeIconController> m_UIPrivilegeIconCtrlList;

	private string m_CurRankTypeIconSpriteName;

	private List<ElitePassWaittingRoomRanking> m_TopUIList;

	private Texture m_OriginalBgTexture;

	private const int LEADERBOARD_MAX_RANK_NUM = 5;

	private List<UILobbySocialBillBoardLeaderBoardItemController> m_LeaderBoardItems;

	private List<LeaderBoardEntry> m_LeaderBoardCache;

	private EOtherContainerState m_OtherContainerState;

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

	private void OnPlayerNameRefresh(object[] data)
	{
	}

	private void ShowOtherContainer()
	{
	}

	public void ShowGroupAnimContainer()
	{
	}

	public void HideGroupAnimContainer()
	{
	}

	public void SetOtherContainerState(EOtherContainerState state)
	{
	}

	public EOtherContainerState GetOtherContainerState()
	{
		return EOtherContainerState.Empty;
	}

	public void SetMVPRenderTexture(RenderTexture rt)
	{
	}

	public void ClearMVPRenderTexture()
	{
	}

	public void RefreshLeaderBoard()
	{
	}

	private void CollectLeaderBoardEntries(List<LeaderBoardEntry> outEntries)
	{
	}

	private void FillLeaderBoardItems(List<LeaderBoardEntry> entries)
	{
	}

	private void CloseAllLeaderBoardItems()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
