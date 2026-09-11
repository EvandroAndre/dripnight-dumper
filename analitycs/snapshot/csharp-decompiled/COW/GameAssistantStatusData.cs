namespace COW;

public class GameAssistantStatusData
{
	public uint messageType;

	public bool hasReadSync;

	public bool hasSendLog;

	public ulong readEndTime;

	public ulong readStartTime;

	public bool IsExpire()
	{
		return false;
	}
}
