namespace proto;

public class DebrisDetail
{
	public enum Source
	{
		NONE,
		AVATAR,
		SKILL
	}

	public Item debris;

	public uint debris_gained_today;

	public uint debris_gain_limit;

	public bool debris_reach_avatar_limit;

	public Source source;
}
