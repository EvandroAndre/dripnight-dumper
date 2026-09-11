namespace proto;

public class GPLEventDesc
{
	public uint event_id;

	public string gp_event_id;

	public long event_start_time;

	public long event_end_time;

	public EActivity.ConditionType cdt_type;

	public uint cdt_value;

	public EActivity.PreConditionType pre_cdt_type1;

	public uint pre_cdt_value1;

	public uint[] pre_cdt_values1;

	public EActivity.PreConditionType pre_cdt_type2;

	public uint pre_cdt_value2;

	public uint[] pre_cdt_values2;
}
