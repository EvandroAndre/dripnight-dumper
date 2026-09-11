using System.Collections.Generic;

namespace GCommon;

public class ObjectPoolRepository : Singleton<ObjectPoolRepository>
{
	private List<PoolWrapper> mRepositories;

	private bool m_EnablePool;

	private bool _003CbRunTime_003Ek__BackingField;

	public bool EnablePool => false;

	public bool bRunTime
	{
		get
		{
			return _003CbRunTime_003Ek__BackingField;
		}
		private set
		{
			_003CbRunTime_003Ek__BackingField = value;
		}
	}

	public override void Init()
	{
	}

	private void InitAllObjectPoolType()
	{
	}

	public void EnsureRegistered<T>() where T : PooledClassObject, new()
	{
	}

	public void ClearAll(bool clearRef = true)
	{
	}

	public void ClearUnUsed()
	{
	}

	public void SetRuntimeFlag(bool InbRunTime)
	{
	}

	public IObjectPool GetPool(int InClassID)
	{
		return null;
	}
}
