using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public struct UGCGameDataCreatorTrace
{
	public ulong ProjectOriginalCreatorId;

	public ulong ProjectCreateTs;

	public List<string> ProjectModificationRecords;
}
