using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetDrawShopDescRes : IMessage
{
	public List<DrawShopCommonDesc> common_descs;

	public LimitedPoolDrawShopDesc limited_pool_desc;

	public List<UnlimitedWheelDrawShopDesc> unlimited_wheel_desc;

	public List<UnlimitedDrowShopTowerDesc> unlimited_tower_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
