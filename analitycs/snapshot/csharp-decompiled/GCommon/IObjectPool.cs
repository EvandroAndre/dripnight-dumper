using System;

namespace GCommon;

public interface IObjectPool
{
	int total { get; }

	int RTAllocCnt { get; }

	int Count { get; }

	int Capacity { get; }

	object Get(object constructData = null);

	void Init(PoolWrapper wrapper);

	void Release(PooledClassObject obj);

	void ClearUnused();

	void ClearAll(bool clearRef);

	Type GetElemType();
}
