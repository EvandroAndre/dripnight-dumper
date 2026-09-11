namespace proto;

public class EManual
{
	public enum State
	{
		State_COLLECTING,
		State_FINISHED,
		State_AWARDED
	}

	public enum EventType
	{
		EventType_NONE,
		EventType_WEAPON,
		EventType_MAP,
		EventType_SUP,
		EventType_MOV,
		EventType_EVE
	}
}
