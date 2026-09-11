using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class VirtualBrandStoryDesc : IMessage
{
	public uint brand_id;

	public uint sort_id;

	public List<string> brand_key_art;

	public string brand_logo_id;

	public string brand_introduce;

	public string brand_slogan;

	public uint go_pos;

	public string sub_go_pos;

	public List<string> coming_sketch;

	public uint like_award_id;

	public uint award_num;

	public EInventory.AwardType award_type;

	public uint expire_time;

	public bool coming_sketch_on;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
