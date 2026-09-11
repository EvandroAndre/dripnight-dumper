using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudMultiTeamMatchResultController : UIHudSingleFightMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIOpen()
	{
	}

	protected override bool IsShowDetailBtn()
	{
		return false;
	}

	protected override void OnShowAvatarInfoUI()
	{
	}

	protected override void UpdateInfoTitles()
	{
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	private int SortForRank(List<TeammateStats> a, List<TeammateStats> b)
	{
		return 0;
	}

	private uint GetKill(List<TeammateStats> a)
	{
		return 0u;
	}

	private uint GetDamage(List<TeammateStats> a)
	{
		return 0u;
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public UIHudMultiTeamMatchResultPlayerItemController BuildPlayerItem(Transform parent, TeammateStats player, bool single)
	{
		return null;
	}

	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	protected override EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return EMatchResultIsWin.Win;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsShowDetailBtn()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	public new List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}

	public new EMatchResultIsWin _003C_003EiFixBaseProxy_CheckIsWin(MatchStats P0)
	{
		return EMatchResultIsWin.Win;
	}
}
