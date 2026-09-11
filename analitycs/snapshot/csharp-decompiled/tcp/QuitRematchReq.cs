namespace tcp;

public class QuitRematchReq
{
	public ulong account_id;

	public ulong match_id;

	public ulong team_id;

	public ERematch.QuitReason quit_reason;
}
