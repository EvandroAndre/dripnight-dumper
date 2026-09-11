using System;
using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class QuickObjectPoolMap
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<object> _003C_003E9__16_0;

		internal object _003CCreate_003Eb__16_0()
		{
			return null;
		}
	}

	private UGCRuntime ugcRuntime;

	private UGCObjectPool<UGCArchTypeFilter> archTypeFilterPool;

	private UGCObjectPool<UGCSimpleValue> ugcValuePool;

	private UGCObjectPool<UGCEntityRepData> entityRepDataPool;

	private UGCObjectPool<UGCEntityRepDataItem> entityRepDataItemPool;

	private UGCObjectPool<StackVar> stackVarPool;

	private UGCObjectPool<PCaller> pCallerPool;

	private UGCObjectPool<StackVarsMem> stackVarsMemPool;

	private UGCObjectPool<CallStackMem> callStackMemPool;

	private UGCObjectPool<StackContext> stackContextInterpreterPool;

	private UGCObjectPool<UGCCoroutine> coroutinePool;

	private UGCObjectPool<WaitForNextFrame> waitForNextFrameAdapterPool;

	private UGCObjectPool<UGCWaitForSecondsV2> waitForSecondsAdapterPool;

	private UGCObjectPool<WaitForCondition> waitForConditionAdapterPool;

	private Dictionary<int, List<List<UGCSimpleValue>>> paramListPool;

	private SimplePool entityListPool;

	private int lastListCapcity;

	private List<List<UGCSimpleValue>> lastList;

	public QuickObjectPoolMap Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void AddInitItemOnTick()
	{
	}

	public void StartWarmUp(JOEANMPIFAB gameData)
	{
	}

	private float CalculateInitRatio(int entityCount)
	{
		return 0f;
	}

	public void StopWarmUp()
	{
	}

	public void LogPoolStatistics()
	{
	}

	public UGCArchTypeFilter GetArchTypeFilterObjFromPool()
	{
		return null;
	}

	public void PutArchTypeFilterObjToPool(IUGCObjectPoolItem item)
	{
	}

	public UGCSimpleValue GetUGCValueFromPool()
	{
		return null;
	}

	public void PutUGCValueToPool(IUGCValue item)
	{
	}

	public UGCEntityRepData GetEntityRepData()
	{
		return null;
	}

	public void ResetPutEntityRepData(UGCEntityRepData obj)
	{
	}

	public UGCEntityRepDataItem GetEntityRepDataItem()
	{
		return null;
	}

	public void ResetPutEntityRepDataItem(UGCEntityRepDataItem obj)
	{
	}

	public UGCSimpleValue GetCoreValue()
	{
		return null;
	}

	public void PutCoreValue(UGCSimpleValue item)
	{
	}

	public StackVar GetStackVar()
	{
		return null;
	}

	public void PutStackVar(StackVar item)
	{
	}

	public PCaller GetPCaller()
	{
		return null;
	}

	public void PutPCaller(PCaller item)
	{
	}

	public StackVarsMem GetStackVarsMem()
	{
		return null;
	}

	public void PutStackVarsMem(StackVarsMem item)
	{
	}

	public CallStackMem GetCallStackMem()
	{
		return null;
	}

	public void PutCallStackMem(CallStackMem item)
	{
	}

	public StackContext GetStackContext()
	{
		return null;
	}

	public void PutStackContext(StackContext item)
	{
	}

	public UGCCoroutine GetCoroutine()
	{
		return null;
	}

	public void PutCoroutine(UGCCoroutine item)
	{
	}

	public WaitForNextFrame GetWaitForNextFrame()
	{
		return null;
	}

	public void PutWaitForNextFrame(IUGCObjectPoolItem item)
	{
	}

	public UGCWaitForSecondsV2 GetWaitForSeconds()
	{
		return null;
	}

	public void PutWaitForSeconds(IUGCObjectPoolItem item)
	{
	}

	public WaitForCondition GetWaitForCondition()
	{
		return null;
	}

	public void PutWaitForCondition(IUGCObjectPoolItem item)
	{
	}

	public List<UGCSimpleValue> GetListUGCValue(int capacity)
	{
		return null;
	}

	public void PutListUGCValue(List<UGCSimpleValue> item)
	{
	}

	public List<UGCLogicEntity> GetEntityList()
	{
		return null;
	}

	public void PutEntityList(List<UGCLogicEntity> item)
	{
	}
}
