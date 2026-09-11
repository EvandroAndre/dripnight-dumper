using ProtoBuf;

namespace proto;

public class GiftStoreCDNDesc : IMessage
{
	public string ff_ui_wishlist_store;

	public string ff_ui_quick_gift_bg;

	public string ff_ui_gift_bg;

	public string ff_ui_email_gift_bg;

	public string ui_prime_quality_slot_bg_01;

	public string ui_prime_quality_slot_bg_02;

	public string ui_prime_quality_slot_bg_03;

	public string ui_prime_quality_slot_bg_04;

	public string ui_prime_quality_slot_bg_05;

	public string ui_prime_quality_slot_bg_06;

	public string ui_prime_quality_slot_bg_07;

	public string ui_prime_quality_slot_bg_08;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
