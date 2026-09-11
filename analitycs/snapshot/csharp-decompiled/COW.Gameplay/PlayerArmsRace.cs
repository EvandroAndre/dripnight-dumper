using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay;

internal class PlayerArmsRace : PlayerNetwork
{
	private UIModelMatch m_UIModelMatch;

	private GameObject m_LeaderIcon;

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private void OnPlayerLevelAndPointsChange(ushort oldValue, ushort newValue)
	{
	}

	private void OnPlayerRankChange(byte oldValue, byte newValue)
	{
	}

	private void OnPlayerIsLeaderChange(bool oldValue, bool newValue)
	{
	}

	private void OnOpponentLevelChange(byte oldLevel, byte newLevel)
	{
	}

	private void UpdateMatchModeLocalPlayerArmsLevel(int level)
	{
	}

	private void UpdateMatchModeOpponentArmsLevel(int level)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
