namespace GCommon;

public enum HttpRequestState
{
	NotSend,
	WaitResponse,
	WaitDeserializeinThread,
	Notify,
	Done
}
