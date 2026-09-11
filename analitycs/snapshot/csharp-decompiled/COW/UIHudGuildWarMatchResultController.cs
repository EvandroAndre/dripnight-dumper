using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGuildWarMatchResultController : UIHudTeamBattleMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override int[] GetInfoTypes()
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

	protected override Transform GetItemTransform(bool localTeam, int index)
	{
		return null;
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public Transform _003C_003EiFixBaseProxy_GetItemTransform(bool P0, int P1)
	{
		return null;
	}
}
