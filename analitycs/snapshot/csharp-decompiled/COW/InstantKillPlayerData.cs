using COW.GamePlay;

namespace COW;

internal class InstantKillPlayerData
{
	public string NickName;

	public BHGGAEEHJCO playerID;

	public ulong UserID;

	public int TeamIndex;

	public bool IsFriend;

	public bool IsConnected;

	public InstantKillPlayerData(string name, BHGGAEEHJCO id, int teamIndex, bool isFriend = false, ulong userID = 0uL)
	{
	}
}
