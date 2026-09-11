namespace proto;

public class CSReportWorkshopCodeReq
{
	public uint report_type;

	public string workshop_code;

	public uint report_channel;

	public ulong match_id;

	public uint map_scene;

	public uint[] violation_issues;

	public string violation_issue_text;

	public uint[] other_issues;

	public string other_issue_text;
}
