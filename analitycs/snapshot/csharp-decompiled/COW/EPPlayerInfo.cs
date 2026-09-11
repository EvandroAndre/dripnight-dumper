using COW.GamePlay;
using message;

namespace COW;

internal class EPPlayerInfo
{
	public ulong userID;

	public BHGGAEEHJCO playerID;

	public string playerName;

	public uint badgeCount;

	public uint badgeId;

	public bool isAI;

	public uint pinId;

	public AvatarManager.JEGKOJDIKEL avatarData;

	public uint role;

	public BadgeInfoInGame BadgeInfoInGame;

	public bool isFP;

	public EPPlayerInfo(ulong uID, BHGGAEEHJCO pID, bool isBot, COEDKLIGPPD info, bool isReplay = false)
	{
	}

	public EPPlayerInfo(ulong uID, BHGGAEEHJCO pID, bool isBot, AvatarManager.JEGKOJDIKEL avatar)
	{
	}

	public bool IsLocalPlayer()
	{
		return false;
	}

	public bool IsCelebrity()
	{
		return false;
	}

	public bool IsFemale()
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}
}
