using System.Collections.Generic;

namespace COW;

public class ClientReissueData
{
	public readonly List<ClientReissueItemData> CurrentPeriodReissueData;

	public readonly List<ClientReissueItemData> FutureReviewData;

	public void Reset()
	{
	}
}
