using System.Collections.Generic;
using COW.GamePlay;
using proto;

namespace COW;

public class LobbyLWOpponentInfo
{
	public BHGGAEEHJCO PlayerID;

	public string NickName;

	public ulong UserID;

	public string LockRegion;

	public uint AvatarID;

	public uint SkinColor;

	public List<uint> Cloth;

	public List<AccountCollectionCustomItemInfo> CustomData;

	public static LobbyLWOpponentInfo Capture(BHGGAEEHJCO opponentPlayerID)
	{
		return null;
	}
}
