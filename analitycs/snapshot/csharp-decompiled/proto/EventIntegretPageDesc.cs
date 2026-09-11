using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class EventIntegretPageDesc : IMessage
{
	public uint event_id;

	public string event_name;

	public string event_start_time;

	public string event_end_time;

	public uint event_start_timestamp;

	public uint event_end_timestamp;

	public string language;

	public string lobby_icon;

	public string web_mission_url;

	public List<EventMissionDesc> event_missions;

	public string go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
