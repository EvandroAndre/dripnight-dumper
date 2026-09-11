using System.Collections.Generic;
using UnityEngine;

namespace ReactUI;

public sealed class UIEventTable : MonoBehaviour
{
	public delegate void EventDelegate(object[] args);

	private string[] events;

	private Dictionary<string, SignalDelegateList> m_delegateMap;

	private Dictionary<string, LinkedList<Component>> m_componentMap;

	public string[] Events => null;

	private Dictionary<string, SignalDelegateList> GetDelegateMap()
	{
		return null;
	}

	public void Sort()
	{
	}

	public ICollection<Component> FindReferenced(string eventName)
	{
		return null;
	}

	public SignalHandle ListenEvent(string eventName, SignalDelegate callback)
	{
		return null;
	}

	internal LinkedListNode<Component> Add(string name, Component P_1)
	{
		return null;
	}

	internal void Remove(string name, LinkedListNode<Component> P_1)
	{
	}

	public SignalDelegateList GetDelegateByName(string name)
	{
		return null;
	}
}
