using System.Collections.Generic;

namespace proto;

public class AwakenTaskDesc
{
	public uint id;

	public uint task_type;

	public uint task_value;

	public List<AwardDesc> awards;

	public uint task_sub_value;
}
