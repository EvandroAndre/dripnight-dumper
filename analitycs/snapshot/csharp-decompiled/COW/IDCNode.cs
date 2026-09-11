namespace COW;

public class IDCNode
{
	public string Address;

	public string IDCName;

	public int PingTime;

	public int PingCount;

	public int LossCount;

	public bool IsProxy;

	public IDCNode(string IP, string iDCName, bool isProxy = false)
	{
	}

	public int GetPingTime()
	{
		return 0;
	}

	public void SetPingTime(int pingTime, bool isLoss)
	{
	}

	public void ClearPingCount()
	{
	}
}
