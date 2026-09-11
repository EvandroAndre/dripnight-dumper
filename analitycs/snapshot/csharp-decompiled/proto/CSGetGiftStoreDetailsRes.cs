using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetGiftStoreDetailsRes : IMessage
{
	public uint store_id;

	public List<GiftItem> items;

	public uint send_gift_times_today;

	public uint prime_send_gift_times_today;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
