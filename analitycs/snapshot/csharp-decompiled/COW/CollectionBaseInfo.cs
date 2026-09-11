using System;
using proto;

namespace COW;

public class CollectionBaseInfo : IComparable<CollectionBaseInfo>
{
	public uint id;

	public uint sort_id;

	public bool is_default;

	public bool is_owned;

	public Item item;

	public CSSharedItemData item_data;

	public virtual uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(CollectionBaseInfo other)
	{
		return 0;
	}
}
