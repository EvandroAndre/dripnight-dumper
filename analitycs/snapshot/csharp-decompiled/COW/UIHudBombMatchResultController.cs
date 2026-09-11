using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

internal class UIHudBombMatchResultController : UIHudTeamBattleMatchResultController
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public BHGGAEEHJCO playerID;

		internal bool _003CCheckIsWinTeamPlayerForSpectator_003Eb__0(TeamData t)
		{
			return false;
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return 0;
	}

	protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	public static int SortBombTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected override List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	protected override bool CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return 0;
	}

	public List<PlayerData> _003C_003EiFixBaseProxy_CreateShowAvatarPlayerData()
	{
		return null;
	}

	public new bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO P0)
	{
		return false;
	}
}
