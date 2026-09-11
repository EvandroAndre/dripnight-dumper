using System.Collections.Generic;

namespace COW;

public class MapDiffPatch
{
	public int[] SceneID;

	public bool HasTilePrefab;

	public Dictionary<int, List<TilePrefabSearchKey>> RemovedTilePrefabNodes;

	public List<ABSceneGOInfo> AddedTileSceneGO;

	public List<ABSceneGOInfo> RemovedTileSceneGO;

	public List<int> AddedSharedTileSceneGO;

	public List<int> RemovedSharedTileSceneGO;
}
