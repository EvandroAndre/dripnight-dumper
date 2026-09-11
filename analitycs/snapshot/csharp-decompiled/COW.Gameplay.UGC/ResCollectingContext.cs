using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class ResCollectingContext
{
	public HashSet<string> ResourceNames;

	public HashSet<uint> LevelObjectIds;

	public HashSet<uint> CSSharedItemID;

	public HashSet<int> AITypes;

	public HashSet<string> CustomLevelObjectUUIDs;

	public Dictionary<string, MBFMAHGABDN> CustomLevelObjectPackageRefs;

	public HashSet<string> UGCAssetIds;
}
