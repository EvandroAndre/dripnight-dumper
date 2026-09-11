using System;
using proto;

namespace COW;

public class BannerBaseInfo : CollectionBaseInfo, IComparable<BannerBaseInfo>
{
	public uint banner_id;

	public BannerData banner_data;

	public Item banner_item;

	public BannerBaseInfo(uint bannerId)
	{
	}

	public static implicit operator BannerBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator BannerBaseInfo(BannerData bd)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(BannerBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
