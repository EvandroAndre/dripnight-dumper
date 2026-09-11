using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class ResourceRefCacheWithOwnerNoRefCnt : IResourceRefCacheWithOwner
{
	public class ResCallbackPair
	{
		public ResourceID ResId;

		public Action<uint, UnityEngine.Object> Callback;

		public ResCallbackPair(ResourceID resId, Action<uint, UnityEngine.Object> callback)
		{
		}
	}

	private bool _003CNoCache_003Ek__BackingField;

	private const int OwnerRequestsDefaultCapacity = 1;

	protected Dictionary<object, Dictionary<uint, ResCallbackPair>> m_OwnerToRequests;

	protected Dictionary<uint, object> m_TicketToOwner;

	public virtual bool NoCache
	{
		get
		{
			return _003CNoCache_003Ek__BackingField;
		}
		set
		{
			_003CNoCache_003Ek__BackingField = value;
		}
	}

	public virtual void Clear()
	{
	}

	public virtual UnityEngine.Object TryGet(ResourceID resId)
	{
		return null;
	}

	public virtual UnityEngine.Object GetAndRegister(object owner, ResourceID resId)
	{
		return null;
	}

	protected static UnityEngine.Object LoadImpl(ResourceID resId, bool noCache)
	{
		return null;
	}

	public virtual bool HasUnRefedRes()
	{
		return false;
	}

	public virtual void Register(object owner, UnityEngine.Object res)
	{
	}

	public virtual void UnRegisterAll(object owner)
	{
	}

	public virtual bool UnloadOneUnRefedRes()
	{
		return false;
	}

	public bool IsAsyncLoading()
	{
		return false;
	}

	protected static uint LoadAsyncImpl(uint ticket, ResourceID resId, Action<uint, bool, UnityEngine.Object> callback, bool noCache)
	{
		return 0u;
	}

	public virtual uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback)
	{
		return 0u;
	}

	protected uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback, bool checkCache)
	{
		return 0u;
	}

	protected virtual void RemoveAndInvokeAsyncCallback(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	protected void DoInvokeAsyncCallback(uint ticket, UnityEngine.Object obj, ResCallbackPair pair)
	{
	}

	public virtual void CancelAsyncs(object owner)
	{
	}

	public virtual void CancelAllAsyncs()
	{
	}

	public virtual void RemoveOwner(object owner)
	{
	}

	protected void CancelAsyncs(object owner, bool remove)
	{
	}

	protected void DoCancelAsync(uint ticket)
	{
	}

	protected void AddTicketOwner(object owner, uint ticket)
	{
	}

	protected object GetAndRemoveTicketOwner(uint ticket)
	{
		return null;
	}

	protected bool RemoveTicketOwner(uint ticket)
	{
		return false;
	}

	protected Dictionary<uint, ResCallbackPair> GetAsyncCallbacks(object owner, bool create)
	{
		return null;
	}

	protected Dictionary<uint, ResCallbackPair> RemoveAsyncCallbacks(object owner)
	{
		return null;
	}

	protected virtual void RegisterAsyncCallback(object owner, uint ticket, ResourceID resId, Action<uint, UnityEngine.Object> callback)
	{
	}

	protected ResCallbackPair RemoveAsyncCallback(uint ticket, out object owner)
	{
		owner = null;
		return null;
	}
}
