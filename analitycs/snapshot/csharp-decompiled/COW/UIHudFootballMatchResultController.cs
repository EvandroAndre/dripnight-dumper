using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIHudFootballMatchResultController : UIHudTeamBattleMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override void SetResultDescTextByRank(MatchStats stats)
	{
	}

	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return 0;
	}

	protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	public static int SortFootballTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected override EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return EMatchResultIsWin.Win;
	}

	protected override AvatarProfileInfo GetAvatarProfileData(PlayerData data)
	{
		return null;
	}

	protected override bool IsShowWin()
	{
		return false;
	}

	protected override void UpdateTeammateInfo(bool localTeam, List<TeammateStats> players)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetResultDescTextByRank(MatchStats P0)
	{
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return 0;
	}

	public EMatchResultIsWin _003C_003EiFixBaseProxy_CheckIsWin(MatchStats P0)
	{
		return EMatchResultIsWin.Win;
	}

	public AvatarProfileInfo _003C_003EiFixBaseProxy_GetAvatarProfileData(PlayerData P0)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsShowWin()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateTeammateInfo(bool P0, List<TeammateStats> P1)
	{
	}
}
