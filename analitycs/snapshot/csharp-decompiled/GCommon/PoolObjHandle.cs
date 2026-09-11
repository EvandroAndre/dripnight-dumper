using System;

namespace GCommon;

public struct PoolObjHandle<T>(T obj) : IEquatable<PoolObjHandle<T>> where T : PooledClassObject
{
	public uint _handleSeq = 0u;

	public T _handleObj = null;

	public bool HasValue => false;

	public T handle => null;

	public void Validate()
	{
	}

	public void Release()
	{
	}

	public static implicit operator bool(PoolObjHandle<T> ptr)
	{
		return false;
	}

	public static bool operator ==(PoolObjHandle<T> lhs, PoolObjHandle<T> rhs)
	{
		return false;
	}

	public static bool operator !=(PoolObjHandle<T> lhs, PoolObjHandle<T> rhs)
	{
		return false;
	}

	public bool Equals(PoolObjHandle<T> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static implicit operator T(PoolObjHandle<T> ptr)
	{
		return null;
	}
}
