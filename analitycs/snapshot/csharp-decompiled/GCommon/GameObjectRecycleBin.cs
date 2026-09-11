using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class GameObjectRecycleBin
{
	private Transform m_BinRoot;

	private Dictionary<int, GameObjectRecycleInfo> m_Caches;

	private ObjectPool<GameObjectRecycleInfo> m_InfoPool;

	public Action<GameObject> onRestore;

	public Action<GameObject> onRecycle;

	public GameObjectRecycleBin(Transform binRoot)
	{
	}

	public void SetRecycleBinRoot(Transform binRoot)
	{
	}

	public void Restore(GameObject item)
	{
	}

	public void Recycle(GameObject item)
	{
	}

	public void Clear(GameObject item)
	{
	}

	public void ClearAll()
	{
	}
}
