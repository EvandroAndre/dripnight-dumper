using System.Collections.Generic;

namespace GCommon;

internal class UDPMessagePool<T> : UPDMessagePoolInterface where T : UDPClientMessageBase, new()
{
	private Queue<T> m_FreeList;

	public T Get()
	{
		return null;
	}

	public void Put(T v)
	{
	}

	public void Clear()
	{
	}
}
