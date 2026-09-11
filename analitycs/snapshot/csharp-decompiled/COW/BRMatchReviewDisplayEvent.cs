using System.Collections.Generic;
using message;

namespace COW;

public class BRMatchReviewDisplayEvent : HJNFDCJPPDE
{
	public int KillMergeCount;

	public bool IsKillMergeUpdate;

	public BRMatchReviewDisplayEvent MergeRootEvent;

	public string MapEventNameLocKeyOverride;

	public int DisplayOrder;

	public List<uint> RevivedPlayerIds;
}
