using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class VipCardRebateDesc : IMessage
{
	public uint rebate_id;

	public List<EVipCard.RebateType> type;

	public uint start_time;

	public uint end_time;

	public uint purchase_times;

	public uint gem_return;

	public float price;

	public float discount_price;

	public string product_identifier;

	public bool is_drop_from_iap;

	public uint warn_time;

	public string cdn;

	public uint[] paid_level;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
