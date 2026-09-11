namespace COW;

public class FastRoomWinRateMessage : FastMessage
{
	public uint GameMode;

	public uint PlayTimes;

	public int WinRatePercent;

	public ulong OwnerId;

	public string OwnerName;
}
