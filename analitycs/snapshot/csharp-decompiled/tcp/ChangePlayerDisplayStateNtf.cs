namespace tcp;

public class ChangePlayerDisplayStateNtf
{
	public ulong changed_account_id;

	public EGroup.PlayerDisplayState display_state;

	public bool ready;
}
