using System.Collections.Generic;
using GCommon;
using UnityEngine;

public class BackgroundCacher
{
	public const int GlobalOwnerId = 268435455;

	private const int DefaultMaxSimuCachingCount = 4;

	private const int CacherPoolSize = 32;

	private List<CacherNode> m_CacherPool;

	private int m_MaxSimuCachingCount;

	private Dictionary<ResourceID, CacherNode> m_Caching;

	private Dictionary<ResourceID, CacherNode> m_Pending;

	private bool m_Paused;

	private List<ResourceID> m_temp;

	public BackgroundCacher(int cap = 4)
	{
	}

	public void DoCache(ICollection<ResourceID> resIds, int insId, ResourceManager.LoadPriority priority = ResourceManager.LoadPriority.Normal, bool preload = false, int instCount = -1)
	{
	}

	public void DoCache(ResourceID rid, int insId, ResourceManager.LoadPriority priority = ResourceManager.LoadPriority.Normal, bool preload = false, int instCount = -1)
	{
	}

	public void UnCache(ICollection<ResourceID> resIds, int insId)
	{
	}

	public void UnCache(ResourceID rid, int insId)
	{
	}

	public void Tick()
	{
	}

	private void StartNextWithPriority(ResourceManager.LoadPriority loadPriority)
	{
	}

	private void OnResCached(uint ticket, bool ret, Object go)
	{
	}

	public void OnDestroy()
	{
	}

	private CacherNode PoolGetNode()
	{
		return null;
	}

	private void PoolReturnNode(CacherNode node)
	{
	}
}
