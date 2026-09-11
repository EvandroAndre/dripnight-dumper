namespace tcp;

public class PlayerMatchmakingInfo
{
	public ulong account_id;

	public uint[] map_id;

	public EMatch.GameMode game_mode;

	public EMatch.MatchMode match_mode;

	public EMatchmaking.PlayerState state;

	public long create_time;

	public uint avg_wait_time_sec;

	public EMatch.GroupMode group_mode;

	public uint difficulty;
}
