namespace tcp;

public class UpdateLbsBanInfoNtf
{
	public ELbs.BanOperation operation;

	public long ban_until;

	public uint ban_reason;
}
