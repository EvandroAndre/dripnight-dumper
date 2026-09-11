using System;

namespace COW.GamePlay.UGCRuntime;

public struct EntityIndex : IEquatable<EntityIndex>
{
	private string _003CID_003Ek__BackingField;

	private uint _003CIndex_003Ek__BackingField;

	public string ID
	{
		get
		{
			return _003CID_003Ek__BackingField;
		}
		set
		{
			_003CID_003Ek__BackingField = value;
		}
	}

	public uint Index
	{
		private get
		{
			return _003CIndex_003Ek__BackingField;
		}
		set
		{
			_003CIndex_003Ek__BackingField = value;
		}
	}

	public uint UnsafeIndex => 0u;

	public static EntityIndex FakeIndex(string entityID)
	{
		return default(EntityIndex);
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(EntityIndex obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
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
