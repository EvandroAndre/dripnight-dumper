using System;

namespace proto;

public class HyperBookPage : IComparable
{
	public uint sort_id;

	public bool unlocked;

	public HyperBookPage Clone()
	{
		return null;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}
}
