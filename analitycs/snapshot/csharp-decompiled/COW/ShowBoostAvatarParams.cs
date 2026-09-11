namespace COW;

public class ShowBoostAvatarParams
{
	public delegate BoostState CheckBoostStateDelegate(uint itemID);

	public CheckBoostStateDelegate CheckBoostState;
}
