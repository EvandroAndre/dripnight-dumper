using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class ScriptScope : IUGCGraph
{
	private GKGNPJEOEGP scriptData;

	public QuickObjectPoolMap objPoolMgr;

	private int concurrencyMax;

	private Dictionary<string, UGCSimpleValue> scriptVars;

	private Dictionary<string, DOMDODOIOBI> functions;

	private List<UGCEventRecord> eventRecords;

	private List<UGCCoroutine> coroutines;

	private int coroutineCnt;

	private ulong lastCoroutineErrorTick;

	private ulong tickCount;

	private bool isDone;

	public UGCLogicEntity owner;

	public UGCRuntime runtime;

	public void UnloadGraph(bool dispatchEvent)
	{
	}

	public GKGNPJEOEGP GraphData()
	{
		return null;
	}

	public ScriptScope Create(GKGNPJEOEGP scriptData, UGCLogicEntity owner, UGCRuntime runtime, int concurrencyMax)
	{
		return null;
	}

	public UGCLogicEntity OwnerEntity()
	{
		return null;
	}

	public QuickObjectPoolMap ObjectPool()
	{
		return null;
	}

	public void LoadGraph(GKGNPJEOEGP graph)
	{
	}

	public long GetPropertyType(string propertyID)
	{
		return 0L;
	}

	public void SetScriptVar(string varName, UGCSimpleValue varValue)
	{
	}

	public UGCSimpleValue GetScriptVar(string varName)
	{
		return null;
	}

	public DOMDODOIOBI GetFunction(string funcID)
	{
		return null;
	}

	public DOMDODOIOBI GetFunctionByIndex(int funcIndex)
	{
		return null;
	}

	public void Reset()
	{
	}

	public void OnTick()
	{
	}

	public bool IsDone()
	{
		return false;
	}

	public bool CheckCoroutineConcurrencyMax()
	{
		return false;
	}

	public IIterator StartCoroutineArgs(DOMDODOIOBI target, List<UGCSimpleValue> args, StackContext upStack)
	{
		return null;
	}

	public IIterator StartCoroutinePackedArgs(DOMDODOIOBI target, List<UGCVarValueDataV2> args, StackContext upStack)
	{
		return null;
	}

	private IIterator StartCoroutineInternal(DOMDODOIOBI target, StackContext invokeStack, StackContext upStack)
	{
		return null;
	}

	public bool GetPropertyBool(string propertyID)
	{
		return false;
	}

	public int GetPropertyInt(string propertyID)
	{
		return 0;
	}

	public long GetPropertyInt64(string propertyID)
	{
		return 0L;
	}

	public float GetPropertyFloat(string propertyID)
	{
		return 0f;
	}

	public Vector2 GetPropertyVector2(string propertyID)
	{
		return default(Vector2);
	}

	public Vector3 GetPropertyVector3(string propertyID)
	{
		return default(Vector3);
	}

	public void SetProperty(string propertyID, object value)
	{
	}

	public void SetPropertyBool(string propertyID, bool value)
	{
	}

	public void SetPropertyInt(string propertyID, int value)
	{
	}

	public void SetPropertyInt64(string propertyID, long value)
	{
	}

	public void SetPropertyFloat(string propertyID, float value)
	{
	}

	public void SetPropertyVector2(string propertyID, Vector2 value)
	{
	}

	public void SetPropertyVector3(string propertyID, Vector3 value)
	{
	}

	public void SetPropertyQuaternion(string propertyID, Quaternion value)
	{
	}
}
