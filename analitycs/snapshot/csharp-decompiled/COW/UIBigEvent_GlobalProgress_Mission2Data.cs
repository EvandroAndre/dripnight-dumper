using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class UIBigEvent_GlobalProgress_Mission2Data : IComparable<UIBigEvent_GlobalProgress_Mission2Data>
{
	private List<ClientActivityDesc> activitys;

	public int Count => 0;

	public bool isEmpty => false;

	public bool isFinish => false;

	// C# has no syntax for parameterized property 'Item'.
	public ClientActivityDesc get_Item(int index)
	{
		return null;
	}

	public void AddClientDesc(ClientActivityDesc desc)
	{
	}

	public int CompareActivityDesc(ClientActivityDesc a, ClientActivityDesc b)
	{
		return 0;
	}

	public int GetMissionState()
	{
		return 0;
	}

	public uint GetMissionSortID()
	{
		return 0u;
	}

	public int CompareTo(UIBigEvent_GlobalProgress_Mission2Data other)
	{
		return 0;
	}
}
