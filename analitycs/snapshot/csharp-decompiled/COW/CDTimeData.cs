namespace COW;

public class CDTimeData
{
	public ulong RequestTime;

	public int CdSecond;

	public CDTimeData(ulong _RequestTime, int _CdSecond)
	{
	}

	public bool CheckOutofCd()
	{
		return false;
	}
}
