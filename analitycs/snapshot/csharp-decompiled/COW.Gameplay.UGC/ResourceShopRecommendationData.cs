using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class ResourceShopRecommendationData
{
	public uint TypeId;

	public uint EventId;

	public string Title;

	public string Description;

	public List<UGCResourceShopItem> Items;

	public HashSet<string> ExposedItemKeys;
}
