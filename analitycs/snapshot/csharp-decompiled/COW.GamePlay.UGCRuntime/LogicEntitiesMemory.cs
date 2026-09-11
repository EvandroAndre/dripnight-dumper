using System;
using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class LogicEntitiesMemory
{
	public Dictionary<string, UGCLogicEntity> pairs;

	public List<UGCLogicEntity> cache;

	public LogicEntitiesMemory Create()
	{
		return null;
	}

	public void Reset()
	{
	}

	public void Iterator(Action<EntityIndex, UGCLogicEntity> @delegate)
	{
	}

	public void Add(UGCLogicEntity logicEntity)
	{
	}

	public void Del(EntityIndex entityIndex)
	{
	}

	public bool Exist(EntityIndex entityIndex)
	{
		return false;
	}

	public bool TryGet(EntityIndex entityIndex, out UGCLogicEntity logicEntity)
	{
		logicEntity = null;
		return false;
	}

	public bool TryGetByEntityID(string entityID, out UGCLogicEntity logicEntity)
	{
		logicEntity = null;
		return false;
	}

	public EntityIndex TryGetIndexByID(string entityID)
	{
		return default(EntityIndex);
	}

	public void Clean()
	{
	}

	public int Length()
	{
		return 0;
	}
}
