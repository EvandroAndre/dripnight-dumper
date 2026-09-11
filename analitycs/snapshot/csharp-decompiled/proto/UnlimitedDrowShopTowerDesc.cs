using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class UnlimitedDrowShopTowerDesc : IMessage
{
	public DrawShopTowerTypeDesc type_desc;

	public List<DrawShopTowerDiscountDesc> discount_descs;

	public List<ClientDrawShopTowerGoodsDesc> goods_descs;

	public List<DrawShopTowerRewardDesc> reward_desc;

	public DrawShopTowerChangeSkinDesc skin_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
