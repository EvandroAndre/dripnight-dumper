using System;

namespace GCommon;

public struct Pair<T1, T2>(T1 v1, T2 v2) : IEquatable<Pair<T1, T2>>
{
	public T1 v1 = default(T1);

	public T2 v2 = default(T2);

	public bool Equals(Pair<T1, T2> other)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
