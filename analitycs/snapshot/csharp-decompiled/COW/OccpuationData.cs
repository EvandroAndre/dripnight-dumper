using proto;

namespace COW;

public class OccpuationData
{
	public ulong AccountID;

	public OccupationDetailInfo CSCareerOccupationInfo;

	public OccupationDetailInfo CSSeasonOccupationInfo;

	public OccupationDetailInfo BRCareerOccupationInfo;

	public OccupationDetailInfo BRSeasonOccupationInfo;

	public OccupationDetailInfo CSPeakCareerOccupationInfo;

	public OccupationDetailInfo CSPeakSeasonOccupationInfo;

	public ulong CacheTime;
}
