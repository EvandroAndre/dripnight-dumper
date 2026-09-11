using System.Collections.Generic;

namespace proto;

public class SpectatorInteractionInfo
{
	public ulong spectator_id;

	public string spectator_name;

	public bool is_friend;

	public bool liked;

	public uint gift_count;

	public List<SpectateRewardInfo> spectate_rewards;

	public bool is_lobby_visit;
}
