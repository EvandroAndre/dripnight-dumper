using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public interface IMatchTeam : IBridgingEntity
{
	uint GetTeamIndex();

	bool IsACE();

	int GetAliveTeammateCount();

	List<IUGCMatchHumanPlayer> GetUGCAllPlayers();
}
