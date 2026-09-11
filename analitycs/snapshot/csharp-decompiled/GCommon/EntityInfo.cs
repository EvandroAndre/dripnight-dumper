namespace GCommon;

public struct EntityInfo
{
	public uint MainType;

	public uint SubType;

	public uint SubSubType;

	public uint UniqueID;

	private string formatStr;

	public static bool operator ==(EntityInfo a, EntityInfo b)
	{
		return false;
	}

	public static bool operator !=(EntityInfo a, EntityInfo b)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void ClearInfo()
	{
	}

	public bool IsNone()
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
}
