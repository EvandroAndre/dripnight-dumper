using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHUDUGC_SingleLeaderboardController : UIHUDUGC_BaseLeaderboardController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<PlayerLeaderBoardData> _003C_003E9__20_0;

		public static Comparison<PlayerLeaderBoardData> _003C_003E9__21_0;

		internal bool _003COnPlayersChanged_003Eb__20_0(PlayerLeaderBoardData x)
		{
			return false;
		}

		internal int _003COnPlayerRanksChanged_003Eb__21_0(PlayerLeaderBoardData a, PlayerLeaderBoardData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public int pid;

		internal bool _003COnPlayersChanged_003Eb__1(PlayerLeaderBoardData d)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public uint pid;

		internal bool _003COnPlayerRanksChanged_003Eb__1(PlayerLeaderBoardData d)
		{
			return false;
		}
	}

	private UIHUDUGC_SingleLeaderboardView m_View;

	private UGCSingleLeaderboardHudRepItem m_ViewData;

	private Dictionary<BHGGAEEHJCO, UIHUDUGC_SingleLeaderboard_ItemController> m_PlayerDict;

	private UIDetailTipsInUGCMatchResultController m_HelpTips;

	private Dictionary<int, UILabel> m_LabelDict;

	private UIHUDUGC_SingleLeaderboard_ItemController m_SelfRankItem;

	private List<int> m_ScoreTypeList;

	private int m_EasyListSelfItemIndex;

	private List<PlayerLeaderBoardData> m_PlayerDataList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override UIHUDUGC_BaseLeaderboard_TeamItemController GetTeamItem(int teamIndex)
	{
		return null;
	}

	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController FindTeammateItem(BHGGAEEHJCO playerId)
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnSpaceBtnClick()
	{
	}

	private uint GetPlayerID(int index)
	{
		return 0u;
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnPlayersChanged(List<object> cur)
	{
	}

	private void OnPlayerRanksChanged(List<object> cur)
	{
	}

	private void OnPlayerScoreTypesChanged(List<object> cur)
	{
	}

	private void UpdateTitles(List<int> scoreTypes)
	{
	}

	private string GetInfoTitle(HPGAEEBKCIE infoType)
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnScrollViewDragMoving()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
