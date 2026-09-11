using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class UnlimitedWheelDrawShopDesc : IMessage
{
	public DrawShopWheelTypeDesc wheel_type_desc;

	public List<ClientDrawShopWheelGoodsDesc> goods_descs;

	public List<DrawShopWheelDiscountDesc> discount_descs;

	public DrawShopWheelChangeSkinDesc change_skin_desc;

	public List<DrawShopWheelExchangeDesc> exchange_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
