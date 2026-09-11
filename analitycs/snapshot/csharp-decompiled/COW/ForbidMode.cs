namespace COW;

public class ForbidMode
{
	public uint matchMode;

	public uint groupMode;

	public uint gameMode;

	public ForbidMode(uint matchMode, uint groupMode, uint gameMode)
	{
	}

	public static bool operator ==(ForbidMode a, ForbidMode b)
	{
		return false;
	}

	public static bool operator !=(ForbidMode a, ForbidMode b)
	{
		return false;
	}
}
