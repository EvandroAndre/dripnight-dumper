using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class MapPatchLayer_LevelObject
{
	private Dictionary<int[], List<ABLevelObjectInfo>> addedLevelObjectDict;

	public void Deserialize(string bytePath, AssetBundle abScene = null, int version = 0)
	{
	}

	public void CombineWithLayerPatch(MapDiffPatch diffPath)
	{
	}
}
