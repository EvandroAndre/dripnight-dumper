using GCommon;
using proto;

namespace COW;

internal class UIHudHGMatchResultController : UIHudNormalMatchResultController
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

	protected override uint GetKillCount(TeammateStats stats)
	{
		return 0u;
	}

	protected override uint GetDamage(TeammateStats stats)
	{
		return 0u;
	}

	protected override void SetResultDescTextByRank(MatchStats stats)
	{
	}

	private void ShowNewRecordNode()
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
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

	public static int SortHGTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected override EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return EMatchResultIsWin.Win;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetKillCount(TeammateStats P0)
	{
		return 0u;
	}

	public uint _003C_003EiFixBaseProxy_GetDamage(TeammateStats P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_SetResultDescTextByRank(MatchStats P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public new int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public new int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return 0;
	}

	public new EMatchResultIsWin _003C_003EiFixBaseProxy_CheckIsWin(MatchStats P0)
	{
		return EMatchResultIsWin.Win;
	}
}
