using System;
using System.Collections.Generic;

namespace COW;

public class ClientReissueItemData
{
	public EClientReissueItemType ClientReissueItemType;

	public DateTime DateTime;

	public uint ClaimTime;

	public Dictionary<uint, uint> AwardStatusDic;

	public List<ClientReissueAward> Awards;

	public Dictionary<uint, List<ClientReissueAward>> AwardsDic;

	public EClientReissueAwardStatus GetAwardStatus()
	{
		return EClientReissueAwardStatus.HasNotCliamAll;
	}

	public List<ClientReissueAward> GetShowAwards()
	{
		return null;
	}
}
