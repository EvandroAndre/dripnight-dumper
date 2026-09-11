namespace tcp;

public class InviteSocialReq
{
	public ulong invitee_id;

	public ulong match_id;

	public ulong shard_key;

	public EMatch.GameMode game_mode;

	public bool join_lonewolf;
}
