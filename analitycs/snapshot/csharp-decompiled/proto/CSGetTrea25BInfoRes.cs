using System.Collections.Generic;

namespace proto;

public class CSGetTrea25BInfoRes
{
	public uint goldenshovel_count;

	public uint daily_be_helped_count;

	public List<Trea25BMapInfo> maps;

	public long help_send_time;

	public uint cur_progress;

	public uint[] claimed_progress;
}
