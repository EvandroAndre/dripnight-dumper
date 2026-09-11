using System;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCResourceIndexEntry
{
	public ulong ResourceId;

	public int Version;

	public string ResourceCode;

	public string ResourceName;

	public string ResourceDesc;

	public int ResourceType;

	public int MainCategory;

	public int SubCategory;

	public int Recreation;
}
