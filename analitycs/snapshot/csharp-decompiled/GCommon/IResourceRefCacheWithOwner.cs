using System;
using UnityEngine;

namespace GCommon;

public interface IResourceRefCacheWithOwner
{
	void Clear();

	UnityEngine.Object TryGet(ResourceID resId);

	UnityEngine.Object GetAndRegister(object owner, ResourceID resId);

	void Register(object owner, UnityEngine.Object res);

	void UnRegisterAll(object owner);

	bool HasUnRefedRes();

	bool UnloadOneUnRefedRes();

	bool IsAsyncLoading();

	uint GetAndRegisterAsync(object owner, ResourceID resId, uint ticket, Action<uint, UnityEngine.Object> callback);

	void CancelAsyncs(object owner);

	void CancelAllAsyncs();

	void RemoveOwner(object owner);
}
