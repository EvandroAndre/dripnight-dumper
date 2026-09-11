using System.Collections.Generic;

namespace proto;

public class locationInfo
{
	public uint trigger_name;

	public uint damage;

	public List<wpIdAndKill> wp_ids_and_kill;

	public bool emote_used;

	public uint vehicle;

	public uint revival_count;
}
