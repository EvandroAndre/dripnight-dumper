using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetRelayMartDescRes : IMessage
{
	public RelayMartSettingDesc setting_desc;

	public List<RelayMartShopDesc> shop_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
