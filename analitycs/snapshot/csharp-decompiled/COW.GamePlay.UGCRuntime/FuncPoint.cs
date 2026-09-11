using System;
using message;

namespace COW.GamePlay.UGCRuntime;

public class FuncPoint : IEquatable<FuncPoint>
{
	public EntityIndex Entity;

	public string GraphID;

	public int FuncIndex;

	public DOMDODOIOBI CachedFunc;

	public bool Equals(FuncPoint other)
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

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}
}
