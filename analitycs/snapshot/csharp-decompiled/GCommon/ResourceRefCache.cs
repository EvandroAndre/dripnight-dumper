using System;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace GCommon;

public class ResourceRefCache
{
	public delegate void ResourceClearCallback(ResourceID res_id, UnityEngine.Object obj);

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public ResourceRefCache _003C_003E4__this;

		public Action<uint, bool, UnityEngine.Object> callback;

		public ResourceID id;

		public bool record_ab_name;

		internal void _003CGetResourceAsync_003Eb__0(uint tk, bool succeeded, UnityEngine.Object res)
		{
		}
	}

	public bool ClearOnQualityChange;

	private MNMBLBKENMK m_CurrentQuality;

	private Dictionary<ResourceID, UnityEngine.Object> m_LoadedResources;

	private Dictionary<string, List<ResourceID>> m_LoadedABPathToUrls;

	private HashSet<uint> m_AsyncLoadTickets;

	public int LoadedResourcesCount => 0;

	public bool IsLoaded(ResourceID id)
	{
		return false;
	}

	public List<ResourceID> GetLoadedResourceIDs()
	{
		return null;
	}

	public UnityEngine.Object GetResource(ResourceID id, bool notUsingABForcefully = false, Type type = null, bool record_ab_name = false)
	{
		return null;
	}

	public uint GetResourceAsync(uint ticket, ResourceID id, bool notUsingABForcefully = false, Type type = null, bool record_ab_name = false, Action<uint, bool, UnityEngine.Object> callback = null, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal)
	{
		return 0u;
	}

	public void ClearResourcesByABPath(string ab_path, ResourceClearCallback clear_callBack)
	{
	}

	public void ClearResource(ResourceID id, ResourceClearCallback clear_callBack)
	{
	}

	public void Clear(ResourceClearCallback clear_callBack)
	{
	}

	public void OnClearResource(ResourceID id)
	{
	}

	public void Clear()
	{
	}
}
