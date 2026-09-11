using System.Collections.Generic;

namespace tcp;

public class StartSocialMatchmakingReq
{
	public EMatch.GameMode game_mode;

	public MatchmakingStartReq solo_matchmaking;

	public MatchmakingGroupStartReq group_matchmaking;

	public bool is_solo_matchmaking;

	public ulong[] in_social_friends;

	public List<FriendIntimacy> friend_intimacys;

	public ulong[] recommend_social_players;
}
