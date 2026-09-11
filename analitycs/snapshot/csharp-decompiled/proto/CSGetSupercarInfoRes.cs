using System.Collections.Generic;

namespace proto;

public class CSGetSupercarInfoRes
{
	public uint car_id;

	public uint exchange_tokens;

	public uint rewarded_to;

	public List<SupercarHelpPlayer> helpers;

	public uint drive_sum;

	public long update_time;

	public long next_reset_time;
}
