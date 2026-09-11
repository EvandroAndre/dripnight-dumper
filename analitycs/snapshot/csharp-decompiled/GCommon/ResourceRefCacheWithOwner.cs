using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class ResourceRefCacheWithOwner : ResourceRefCacheWithOwnerNoRefCnt
{
	protected class ObjectRef
	{
		public UnityEngine.Object Res;

		public ResourceID ResID;

		public LinkedList<ResourceID> ResIDList;

		public short RefCnt;
	}

	private const object AnonymousOwner = null;

	private Dictionary<ResourceID, ObjectRef> m_IdToRef;

	private Dictionary<UnityEngine.Object, ObjectRef> m_ResToRefs;

	private Dictionary<object, HashSet<ObjectRef>> m_OwnerToRef;

	private List<ObjectRef> m_PendingUnloadReses;

	private const bool SkipUnloadingWhileAsyncLoading = true;

	public override bool NoCache
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void Clear()
	{
	}

	public override UnityEngine.Object TryGet(ResourceID resId)
	{
		return null;
	}

	public override UnityEngine.Object GetAndRegister(object owner, ResourceID resId)
	{
		return null;
	}

	public override void Register(object owner, UnityEngine.Object res)
	{
	}

	protected ObjectRef Register(object owner, ResourceID resId, UnityEngine.Object res)
	{
		return null;
	}

	public override void UnRegisterAll(object owner)
	{
	}

	public override bool HasUnRefedRes()
	{
		return false;
	}

	public override bool UnloadOneUnRefedRes()
	{
		return false;
	}

	private ObjectRef GetObjRef(UnityEngine.Object res, bool create)
	{
		return null;
	}

	private HashSet<ObjectRef> GetOwnerSet(object owner, bool create)
	{
		return null;
	}

	private HashSet<ObjectRef> GetAndRemoveOwnerSet(object owner)
	{
		return null;
	}

	private bool IncreaseRefInNeed(ObjectRef objRef, object owner)
	{
		return false;
	}

	private void DecreaseRef(ObjectRef objRef)
	{
	}

	private bool TryUnloadRes(ObjectRef objRef)
	{
		return false;
	}

	public override uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback)
	{
		return 0u;
	}

	protected override void RemoveAndInvokeAsyncCallback(uint ticket, bool success, UnityEngine.Object obj)
	{
	}
}
