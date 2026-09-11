using System.Collections.Generic;

namespace proto;

public class Carni25BAccountInfo
{
	public uint daily_msg_count;

	public long update_msg_time;

	public uint choose_progress_id;

	public uint fan_level;

	public List<Carni25BEvent> events;

	public List<Carni25BEvent> consume_events;
}
