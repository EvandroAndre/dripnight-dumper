using System.Collections.Generic;

namespace proto;

public class FestivalAttendanceItem
{
	public uint id;

	public uint signed;

	public List<AwardDesc> awards;

	public uint drop_max_num;
}
