using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class MapPatchLayer
{
	private List<MapDiffPatch> tileScenePatches;

	public void Deserialize(string bytePath, AssetBundle abScene = null, int version = 0)
	{
	}

	public bool HasPatch()
	{
		return false;
	}

	public List<MapDiffPatch> GetPatches()
	{
		return null;
	}
}
