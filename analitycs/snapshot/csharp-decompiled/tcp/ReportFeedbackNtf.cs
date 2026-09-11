using System.Collections.Generic;

namespace tcp;

public class ReportFeedbackNtf
{
	public string nickname;

	public List<PunishRecord> punish_records;

	public uint current_credit_score;

	public bool is_success;

	public uint head_pic;

	public ExternalIconInfo external_icon_info;
}
