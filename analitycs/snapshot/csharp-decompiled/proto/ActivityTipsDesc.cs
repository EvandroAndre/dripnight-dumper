using ProtoBuf;

namespace proto;

public class ActivityTipsDesc : IMessage
{
	public string language;

	public uint activity_id;

	public uint is_show_tips;

	public uint tips_id;

	public uint show_award_id;

	public uint tips_order_id;

	public uint general_tips_start_show;

	public uint general_tips_end_show;

	public uint show_lower_limit;

	public string lobby_tips_title;

	public string tips_text;

	public uint show_award_num;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
