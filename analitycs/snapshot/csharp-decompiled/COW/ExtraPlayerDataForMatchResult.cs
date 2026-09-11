using System.Collections.Generic;
using proto;

namespace COW;

public class ExtraPlayerDataForMatchResult
{
	public ulong accountID;

	public string nickName;

	public bool isSamoAI;

	public uint likedCount;

	public bool hasLike;

	public bool isFriend;

	public bool isSelf;

	public bool hasAddFriend;

	public bool hasReport;

	public bool hasBlock;

	public bool hasInvite;

	public float inviteTimestamp;

	public MatchLikeSource likeSource;

	public string region;

	public bool isSameTeam;

	public List<SpectatorInteractionInfo> spectatorDataList;

	public List<SpectatorInteractionInfo> MatchResultDataList;
}
