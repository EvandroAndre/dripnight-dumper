using System.Collections.Generic;

namespace ReactUI;

public sealed class SignalHandle
{
	private LinkedList<SignalDelegate> m_ownerList;

	private LinkedListNode<SignalDelegate> m_signalNode;

	internal SignalHandle(LinkedList<SignalDelegate> list, LinkedListNode<SignalDelegate> node)
	{
	}
}
