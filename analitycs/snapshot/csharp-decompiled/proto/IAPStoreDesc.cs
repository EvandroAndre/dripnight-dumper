using ProtoBuf;

namespace proto;

public class IAPStoreDesc : IMessage
{
	public uint store_id;

	public uint bundle_id;

	public string bundle_name;

	public uint price_item_id;

	public float price;

	public uint discount_price_rebate_id;

	public uint discount_price_item_id;

	public float discount_price;

	public uint diamond_price;

	public uint discount_diamond_price;

	public uint diamond_bonus;

	public bool is_remain_diamond;

	public bool is_nonconsumable;

	public EStore.IapStoreType store_type;

	public string web_link;

	public uint activity_id;

	public bool is_not_test_owned;

	public string slogan;

	public uint bundle_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
