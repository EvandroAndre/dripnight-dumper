using System.Collections.Generic;

namespace COW.Gameplay.MultiplayerGame;

public class UGCScoreBlackboard
{
	private Dictionary<int, Dictionary<uint, Dictionary<uint, int>>> _playerScores;

	private Dictionary<int, Dictionary<uint, Dictionary<uint, int>>> _teamScores;

	public void OnPlayerSyncScore(int roundIndex, uint playerID, uint scoreType, int score)
	{
	}

	public void OnTeamSyncScore(int roundIndex, uint teamIndex, uint scoreType, int score)
	{
	}

	public int GetPlayerScore(uint playerID, uint scoreType)
	{
		return 0;
	}

	public int GetPlayerRoundScore(int roundIndex, uint playerID, uint scoreType)
	{
		return 0;
	}

	public int GetTeamScore(uint teamID, uint scoreType)
	{
		return 0;
	}

	public int GetTeamRoundScore(int roundIndex, uint teamIndex, uint scoreType)
	{
		return 0;
	}
}
