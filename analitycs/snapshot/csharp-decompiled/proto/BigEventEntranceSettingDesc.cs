using ProtoBuf;

namespace proto;

public class BigEventEntranceSettingDesc : IMessage
{
	public ELimitedEvent.EventID event_id;

	public uint entrance_id;

	public uint start_timestamp;

	public uint end_timestamp;

	public bool display;

	public bool is_open;

	public string cdn;

	public uint go_pos;

	public string sub_go_pos;

	public string entrance_name;

	public uint[] abtest_playerid_remainder;

	public string entrance_bubble_cdn;

	public string entrance_bubble_key;

	public uint bubble_start_timestamp;

	public uint bubble_end_timestamp;

	public uint bubble_stay_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
