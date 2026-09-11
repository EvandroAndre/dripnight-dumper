using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class StackVarsMem : IUGCObjectPoolItem
{
	public QuickObjectPoolMap objPoolMgr;

	public ScriptScope scope;

	public Dictionary<string, int> name2Index;

	public List<StackVar> items;

	public int topLayer;

	public string lastKey;

	public StackVar lastItem;

	public StackVarsMem Create(QuickObjectPoolMap quickObjectPoolMap, ScriptScope scope)
	{
		return null;
	}

	public void Reset()
	{
	}

	public void ReverseIterator(Func<int, StackVar, IteratorResultType> delegateFunc)
	{
	}

	public StackVar AddVarBool(long typeID, string varName, bool varValue)
	{
		return null;
	}

	public StackVar AddVarInt(long typeID, string varName, int varValue)
	{
		return null;
	}

	public StackVar AddVarInt64(long typeID, string varName, long varValue)
	{
		return null;
	}

	public StackVar AddVarFloat(long typeID, string varName, float varValue)
	{
		return null;
	}

	public StackVar AddVarVec2(long typeID, string varName, Vector2 varValue)
	{
		return null;
	}

	public StackVar AddVarQuaternion(long typeID, string varName, Quaternion varValue)
	{
		return null;
	}

	public StackVar AddVarVec3(long typeID, string varName, Vector3 varValue)
	{
		return null;
	}

	public StackVar AddVarInterface(StackContext upStack, long typeID, string varName, object varValue, byte option)
	{
		return null;
	}

	public StackVar AddVar(StackContext upStack, long typeID, string varName, UGCSimpleValue varValue, byte options)
	{
		return null;
	}

	public bool Exist(string key)
	{
		return false;
	}

	public Tuple2<StackVar, bool> TryGet(string key)
	{
		return default(Tuple2<StackVar, bool>);
	}

	public StackVar Get(string key)
	{
		return null;
	}

	public Tuple2<StackVar, bool> TryGetByIndex(int index)
	{
		return default(Tuple2<StackVar, bool>);
	}

	public void PushStack()
	{
	}

	public void PopStack()
	{
	}

	private void _DelRange(int startIndex)
	{
	}

	public int Length()
	{
		return 0;
	}
}
