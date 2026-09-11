namespace tcp;

public class QuitRematchBySystemReq
{
	public ulong team_id;

	public ulong quit_player_id;

	public ERematch.QuitReason quit_reason;
}
