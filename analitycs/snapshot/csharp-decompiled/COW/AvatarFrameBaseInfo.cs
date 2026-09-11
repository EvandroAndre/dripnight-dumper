using System;
using proto;

namespace COW;

public class AvatarFrameBaseInfo : CollectionBaseInfo, IComparable<AvatarFrameBaseInfo>
{
	public uint avatarFrameId;

	public CollectionAvatarFrameData avatarFrameData;

	public Item avatarFrameItem;

	public bool isPrime;

	public bool isEquip;

	public AvatarFrameBaseInfo(uint avatarFrameId)
	{
	}

	public static implicit operator AvatarFrameBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator AvatarFrameBaseInfo(CollectionAvatarFrameData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(AvatarFrameBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
