using System.Collections.Generic;

namespace proto;

public class AttendanceItem
{
	public uint id;

	public uint signed;

	public List<AwardDesc> awards;

	public bool is_big_prize;
}
