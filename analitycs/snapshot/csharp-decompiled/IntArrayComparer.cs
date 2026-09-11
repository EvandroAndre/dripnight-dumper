using System.Collections.Generic;

public class IntArrayComparer : IEqualityComparer<int[]>
{
	public bool Equals(int[] x, int[] y)
	{
		return false;
	}

	public int GetHashCode(int[] obj)
	{
		return 0;
	}
}
