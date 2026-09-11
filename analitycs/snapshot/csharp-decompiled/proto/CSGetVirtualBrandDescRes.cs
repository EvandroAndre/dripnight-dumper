using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetVirtualBrandDescRes : IMessage
{
	public List<VirtualBrandLogoDesc> virtual_brand_logo_list;

	public List<VirtualBrandCollectionReward> virtual_brand_rewards;

	public List<VirtualBrandClothes> virtual_brand_clothes;

	public List<VirtualBrandCollectionValueDesc> virtual_brand_collection_values;

	public List<VirtualBrandStoryDesc> virtual_brand_story_list;

	public List<VirtualBrandTagDesc> virtual_brand_tag_list;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
