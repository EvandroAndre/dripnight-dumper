using COW.GamePlay;

namespace COW;

public class CandidateReporteeData
{
	public string name;

	public ulong uID;

	public BHGGAEEHJCO playerID;

	public uint headPic;

	public CandidateReporteeType type;

	public string clientVersion;

	public uint clientType;

	public CandidateReporteeData(string name, ulong uID, BHGGAEEHJCO playerID, CandidateReporteeType type, uint headPic = 0u, string clientVersion = "", uint clientType = 0u)
	{
	}
}
