using System.Collections.Generic;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct StreamerTypeComparer : IEqualityComparer<int>
{
	public bool Equals(int x, int y)
	{
		return false;
	}

	public int GetHashCode(int obj)
	{
		return 0;
	}
}
