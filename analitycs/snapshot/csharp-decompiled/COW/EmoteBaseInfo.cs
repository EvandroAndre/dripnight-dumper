using System;
using proto;

namespace COW;

public class EmoteBaseInfo : CollectionBaseInfo, IComparable<EmoteBaseInfo>
{
	public EmoteData emote_data;

	public uint emoteId;

	public EmoteBaseInfo(uint itemid)
	{
	}

	public static implicit operator EmoteBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator EmoteBaseInfo(EmoteData data)
	{
		return null;
	}

	public int CompareTo(EmoteBaseInfo other)
	{
		return 0;
	}
}
