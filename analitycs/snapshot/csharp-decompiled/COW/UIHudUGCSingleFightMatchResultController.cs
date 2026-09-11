using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudUGCSingleFightMatchResultController : UIHudMatchResultBaseController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TeammateStats> _003C_003E9__25_0;

		internal int _003CProcesssStatesList_003Eb__25_0(TeammateStats a, TeammateStats b)
		{
			return 0;
		}
	}

	protected UIHudUGCSingleFightMatchResultView m_View;

	private UIHudUGCSingleFightMatchResultItemController m_SelfUIItem;

	protected int m_LocalPlayerItemIndex;

	private const int ShowSelfItemRank = 4;

	private const int ShowAvatarPlayerRank = 3;

	public int LocalPlayerItemIndex => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override void OnShowAvatarInfoUI()
	{
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	protected virtual void UpdateInfoTitles()
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected virtual PlayerData GetPlayerData(TeammateStats stats)
	{
		return null;
	}

	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return 0;
	}

	protected override EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return EMatchResultIsWin.Win;
	}

	protected override void ShowInFrontEndUpdateBtn()
	{
	}

	protected override void AdjustCountDownLabelPos()
	{
	}

	protected virtual UIHudUGCSingleFightMatchResultItemController OpenItemController(TeammateStats data, bool single)
	{
		return null;
	}

	protected virtual List<TeammateStats> ProcesssStatesList(List<TeammateStats> orgList, ulong localAccountID)
	{
		return null;
	}

	protected void UpdatePlayerListInfo(List<TeammateStats> players, ulong localplayerID)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0)
	{
	}

	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public EMatchResultIsWin _003C_003EiFixBaseProxy_CheckIsWin(MatchStats P0)
	{
		return EMatchResultIsWin.Win;
	}

	public void _003C_003EiFixBaseProxy_ShowInFrontEndUpdateBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_AdjustCountDownLabelPos()
	{
	}
}
