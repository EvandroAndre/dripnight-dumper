namespace proto;

public class NewbieExploreTaskDesc
{
	public uint task_id;

	public uint section_id;

	public string task_text;

	public EActivity.PreConditionType pre_cdt_type1;

	public uint[] pre_cdt_value1;

	public EActivity.PreConditionType pre_cdt_type2;

	public uint[] pre_cdt_value2;

	public EActivity.ConditionType cdt_type;

	public uint cdt_value;

	public string url;

	public string url_text;

	public string icon_res;
}
