namespace proto;

public class CustomCardInfo
{
	public enum WishState
	{
		NONE,
		WISH,
		RECEIVE
	}

	public uint id;

	public uint num;

	public WishState state;
}
