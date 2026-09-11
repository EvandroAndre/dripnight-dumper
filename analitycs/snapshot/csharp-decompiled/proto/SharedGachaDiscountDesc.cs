using System.Collections.Generic;

namespace proto;

public class SharedGachaDiscountDesc
{
	public uint chest_id;

	public uint chest_sub_id;

	public uint discount_type;

	public long discount_start_time_stamp;

	public long discount_end_time_stamp;

	public uint[] discount_price_one;

	public List<DiscountMultiPrice> discount_multi_price_list;
}
