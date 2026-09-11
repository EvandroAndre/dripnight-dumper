using System;
using proto;

namespace COW;

public class TitleInfo : CollectionBaseInfo, IComparable<TitleInfo>
{
	public TitleData title_data;

	public TitleInfo(uint itemid)
	{
	}

	public static implicit operator TitleInfo(Item it)
	{
		return null;
	}

	public static implicit operator TitleInfo(TitleData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(TitleInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
