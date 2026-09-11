using System.Collections.Generic;

namespace proto;

public class BigEventBadgeDesc
{
	public uint event_id;

	public uint big_event_badge_id;

	public string name;

	public string desc;

	public string icon;

	public uint rare;

	public List<GoPosShow> go_pos_shows;
}
