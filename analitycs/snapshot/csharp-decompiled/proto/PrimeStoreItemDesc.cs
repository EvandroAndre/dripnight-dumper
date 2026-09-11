using ProtoBuf;

namespace proto;

public class PrimeStoreItemDesc : IMessage
{
	public uint store_id;

	public uint commodity_id;

	public uint item_type;

	public uint item_id;

	public uint sort_id;

	public uint award_num;

	public uint award_time;

	public uint coins_price;

	public uint gems_price;

	public uint discount_price;

	public string tag_key;

	public string language;

	public string image_url;

	public EInventory.AwardType return_type;

	public uint return_id;

	public uint return_num;

	public uint purchase_times;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
