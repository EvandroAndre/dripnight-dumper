using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class LimitedPoolDrawShopDesc : IMessage
{
	public List<DrawShopLimitedPoolSettingDesc> setting_descs;

	public List<ClientDrawShopLimitedPoolGoodsDesc> goods_descs;

	public List<DrawShopLimitedPoolChangeSkinDesc> change_skin_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
