using System.Collections.Generic;
using UnityEngine;

namespace ReactUI;

public abstract class UIEventBind : UIVariableBind
{
	private UIEventTable eventTable;

	private string paramEventID;

	private UIVariable m_eventIDVariable;

	private Dictionary<string, LinkedListNode<Component>> m_name2Node;

	private UIEventTable _003CEventTable_003Ek__BackingField;

	public UIEventTable EventTable
	{
		get
		{
			return _003CEventTable_003Ek__BackingField;
		}
		private set
		{
			_003CEventTable_003Ek__BackingField = value;
		}
	}

	internal SignalDelegateList Add(string name)
	{
		return null;
	}

	protected override void OnValidate()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected abstract void RefreshBind();

	protected override void Awake()
	{
	}

	internal override void Init()
	{
	}

	private void Clear()
	{
	}

	public UIVariable GetEventIDVar()
	{
		return null;
	}
}
