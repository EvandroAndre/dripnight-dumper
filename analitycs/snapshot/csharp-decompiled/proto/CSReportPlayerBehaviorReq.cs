using System.Collections.Generic;

namespace proto;

public class CSReportPlayerBehaviorReq
{
	public ulong offender_id;

	public string offender_nickname;

	public ulong match_id;

	public List<ECreditScore.ReportType> report_types;

	public uint offender_head_pic;

	public ExternalIconInfo offender_external_icon_info;

	public uint game_mode;

	public uint match_mode;
}
