using System.Collections.Generic;

namespace proto;

public class ClientVeteranTaskDesc
{
	public uint task_id;

	public string act_text;

	public uint task_class;

	public uint cdt_value;

	public List<AwardDesc> awards;

	public uint pre_cdt_value3;

	public EActivity.CircleType circle_type;

	public uint activeness;

	public EAttendance.VeteranTaskType task_type;

	public uint go_pos;

	public string sub_gops;
}
