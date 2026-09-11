namespace COW;

public class TitleAccountParams
{
	public ulong AccountID;

	public int PeakRankPos;

	public int CsPeakRankPos;

	public string Region;

	public TitleAccountParams(ulong accountID, int peakRankPos, int csPeakRankPos, string region)
	{
	}

	public bool HasPeakRankPos()
	{
		return false;
	}
}
