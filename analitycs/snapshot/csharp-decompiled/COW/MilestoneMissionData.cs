using System;
using proto;

namespace COW;

public class MilestoneMissionData : IComparable<MilestoneMissionData>
{
	private ClientActivityDesc[] activitys;

	private int length;

	public uint type => 0u;

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

	public void Clear()
	{
	}

	public int CompareTo(MilestoneMissionData other)
	{
		return 0;
	}
}
