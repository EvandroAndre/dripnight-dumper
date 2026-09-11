using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCResCombineMeshRendererFFItemCache : MonoBehaviour
{
	public class OneRenderer
	{
		public Mesh sharedMesh;

		public Material[] sharedMaterials;

		public Matrix4x4 localToRootMatrix;
	}

	public class CacheItem
	{
		public GameObject m_cacheGO;

		public List<OneRenderer> m_renderers;
	}

	private static UGCResCombineMeshRendererFFItemCache _instance;

	private Dictionary<int, CacheItem> m_cache;

	public static UGCResCombineMeshRendererFFItemCache Instance()
	{
		return null;
	}

	public CacheItem GetFFItem(int ffItemID)
	{
		return null;
	}
}
