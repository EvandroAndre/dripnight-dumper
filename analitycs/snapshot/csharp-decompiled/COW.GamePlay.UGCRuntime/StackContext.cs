using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public class StackContext : IUGCObjectPoolItem
{
	public ScriptScope scope;

	public QuickObjectPoolMap objPoolMgr;

	public EUGCFuncState invokeState;

	public UGCSimpleValue invokeValue;

	public IIterator invokeIter;

	public List<UGCSimpleValue> invokeArgs;

	public CallStackMem callStacks;

	public StackVarsMem variables;

	public StackContext upStack;

	public uint generation;

	public UGCVMDebugger vmDebugger;

	public bool CanRecycle;

	public int LoopMax;

	public UGCRuntime UGCRuntime => null;

	public StackContext Create(StackContext upStack, ScriptScope scope)
	{
		return null;
	}

	public void DetachUpStack()
	{
	}

	public void Reset()
	{
	}

	public ScriptScope GetScope()
	{
		return null;
	}

	public UGCVMDebugger GetVMDebugger()
	{
		return null;
	}

	public List<UGCSimpleValue> InvokeArgs()
	{
		return null;
	}

	public void SetInvokeArgsPackedArgs(List<UGCVarValueDataV2> args, StackContext stack)
	{
	}

	public void SetInvokeArgs(List<UGCSimpleValue> args)
	{
	}

	public EUGCFuncState InvokeState()
	{
		return EUGCFuncState.Unknown;
	}

	public void SetInvokeState(EUGCFuncState state)
	{
	}

	public UGCSimpleValue InvokeValue()
	{
		return null;
	}

	public void SetInvokeValue(object v)
	{
	}

	public EUGCFuncState SetInvokeStateWithValue(EUGCFuncState state, object v)
	{
		return EUGCFuncState.Unknown;
	}

	public void SetInvokeCoreValue(UGCSimpleValue v)
	{
	}

	public void SetInvokeValueBool(bool v)
	{
	}

	public void SetInvokeValueInt(int v)
	{
	}

	public void SetInvokeValueInt64(long v)
	{
	}

	public void SetInvokeValueFloat(float v)
	{
	}

	public IIterator InvokeIter()
	{
		return null;
	}

	public void SetInvokeIter(IIterator iter)
	{
	}

	public PCaller PushStack(DOMDODOIOBI target, bool popLayerWhenPop)
	{
		return null;
	}

	public PCaller PopStack()
	{
		return null;
	}

	public void PushStackLayer()
	{
	}

	public void PopStackLayer()
	{
	}

	public PCaller GetTopPCaller()
	{
		return null;
	}

	public StackVar DefUpStackVar(long typeID, string varName, UGCSimpleValue varValue, byte options)
	{
		return null;
	}

	public StackVar DefStackVar(long typeID, string varName, UGCSimpleValue varValue, byte options)
	{
		return null;
	}

	public StackVar DefStackVarBool(string varName, bool varValue)
	{
		return null;
	}

	public StackVar DefStackVarInt(string varName, int varValue)
	{
		return null;
	}

	public StackVar DefStackVarInt64(string varName, long varValue)
	{
		return null;
	}

	public StackVar DefStackVarFloat(string varName, float varValue)
	{
		return null;
	}

	public StackVar DefStackVariable(string varName, object varValue)
	{
		return null;
	}

	public StackVar DefCurStackVariable(long typeID, string varName, object varValue, uint option)
	{
		return null;
	}

	public Tuple2<UGCSimpleValue, bool> GetStackVar(string varName)
	{
		return default(Tuple2<UGCSimpleValue, bool>);
	}

	public Tuple2<UGCSimpleValue, bool> GetStackVarByIndex(int index)
	{
		return default(Tuple2<UGCSimpleValue, bool>);
	}

	public object GetStackVariable(string varName)
	{
		return null;
	}

	public void SetStackVar(string varName, object varValue, byte option)
	{
	}

	public void SetStackVarByIndex(string varName, int varIndex, object varValue)
	{
	}

	public Tuple2<UGCSimpleValue, bool> GetScriptVar(string varName)
	{
		return default(Tuple2<UGCSimpleValue, bool>);
	}

	public void SetStackVarBool(string varName, bool varValue)
	{
	}

	public void SetStackVarBoolByIndex(string varName, int varIndex, bool varValue)
	{
	}

	public bool GetStackVarBool(string varName)
	{
		return false;
	}

	public void SetStackVarInt(string varName, int varValue)
	{
	}

	public void SetStackVarIntByIndex(string varName, int index, int varValue)
	{
	}

	public int GetStackVarInt(string varName)
	{
		return 0;
	}

	public void SetStackVarInt64(string varName, long varValue)
	{
	}

	public void SetStackVarInt64ByIndex(string varName, int varIndex, long varValue)
	{
	}

	public long GetStackVarInt64(string varName)
	{
		return 0L;
	}

	public void SetStackVarFloat(string varName, float varValue)
	{
	}

	public void SetStackVarFloatByIndex(string varName, int varIndex, float varValue)
	{
	}

	public float GetStackVarFloat(string varName)
	{
		return 0f;
	}

	public void ResetLoopCountInOneFrame()
	{
	}

	public void SetStackVarVec2(string varName, Vector2 varValue)
	{
	}

	public void SetStackVarVec2ByIndex(string varName, int varIndex, Vector2 varValue)
	{
	}

	public void SetStackVarVec3(string varName, Vector3 varValue)
	{
	}

	public void SetStackVarVec3ByIndex(string varName, int varIndex, Vector3 varValue)
	{
	}

	public void SetStackVarQuaternion(string varName, Quaternion varValue)
	{
	}

	public void SetStackVarQuaternionByIndex(string varName, int varIndex, Quaternion varValue)
	{
	}

	public DOMDODOIOBI GetFuncTarget(string funcID)
	{
		return null;
	}

	public string DebugGetStackIDString()
	{
		return null;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, object v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, bool v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, int v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, long v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, float v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, Vector2 v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, Vector3 v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionStateWithValue(EUGCFuncState state, Quaternion v)
	{
		return EUGCFuncState.Unknown;
	}

	public EUGCFuncState InitFunctionEndState()
	{
		return EUGCFuncState.Unknown;
	}

	public IGameBridge BridgingGame()
	{
		return null;
	}

	public void SetStackVariable(string varName, object varValue, uint option = 0u)
	{
	}

	public DOMDODOIOBI TopStackFuncCaller()
	{
		return null;
	}

	public List<string> DebugGetStackIDArray(string runningCodeID)
	{
		return null;
	}
}
