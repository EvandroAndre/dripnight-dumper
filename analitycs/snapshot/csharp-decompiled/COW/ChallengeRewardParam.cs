using System.Collections.Generic;

namespace COW;

public class ChallengeRewardParam
{
	public List<uint> ChallengeIDs;

	public ChallengeType ChallengeType;

	public uint ChallengeGroup;

	public ChallengeRewardParam(List<uint> challengeIDs, ChallengeType challengeType, uint challengeGroup)
	{
	}
}
