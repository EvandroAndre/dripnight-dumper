namespace proto;

public class EDevice
{
	public enum Quality
	{
		Quality_LOW,
		Quality_MEDIUM,
		Quality_HIGH
	}

	public enum State
	{
		State_NONE,
		State_OFTEN_USED,
		State_RARELY_USED,
		State_USING,
		State_UNKNOWN
	}
}
