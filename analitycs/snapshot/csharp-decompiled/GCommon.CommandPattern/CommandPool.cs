using System;
using System.Collections;

namespace GCommon.CommandPattern;

public class CommandPool
{
	private string m_TypeName;

	private Queue m_FreeObjects;

	public CommandPool(string name)
	{
	}

	public T AllocObject<T>() where T : Command, new()
	{
		return null;
	}

	public void CollectObject<T>(T obj) where T : CommandPoolCallback
	{
	}

	public void Clear()
	{
	}

	protected CommandPoolCallback AllocObjectInternal()
	{
		return null;
	}

	protected void CollectObjectInternal(object obj)
	{
	}

	private bool CheckType(Type type)
	{
		return false;
	}
}
