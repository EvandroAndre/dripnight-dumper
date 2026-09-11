using System.Collections.Generic;

namespace proto;

public class Create25BPeriodDesc
{
	public uint period;

	public uint[] building_ids;

	public List<string> formulas;

	public long start_time;

	public long end_time;

	public uint true_building;
}
